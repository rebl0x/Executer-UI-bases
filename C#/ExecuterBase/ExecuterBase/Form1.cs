using System.IO;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ExecuterBase
{       
    public partial class Form1 : Form
    {
        private MoveHelper moveHelper;
        public Form1()
        {
            InitializeComponent();

            moveHelper = new MoveHelper(this);
            moveHelper.InitializeMovablePanel();

            string HFP = Path.Combine(Directory.GetCurrentDirectory(), "Monaco", "index.html");
            webBrowser1.Navigate(new Uri($"file:///{HFP}"));

            string scriptsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "./Scripts");

            if (!Directory.Exists(scriptsDirectory))
            {
                Directory.CreateDirectory(scriptsDirectory);
            }

            foreach (FileInfo i in new DirectoryInfo("./Scripts").GetFiles("*.txt"))
                scriptsListBox.Items.Add(i.Name);
            foreach (FileInfo i in new DirectoryInfo("./Scripts").GetFiles("*.lua"))
                scriptsListBox.Items.Add(i.Name);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            TabPage activeTab = tabSystem.SelectedTab;
            if (activeTab != null)
            {
                WebBrowser editor = activeTab.Controls["newTab"] as WebBrowser;

                if (editor == null)
                {
                    foreach (Control control in activeTab.Controls)
                    {
                        if (control is WebBrowser)
                        {
                            editor = control as WebBrowser;
                            break;
                        }
                    }
                }
                if (editor != null)
                {
                    var src = editor.Document.InvokeScript("getValue").ToString();
                    //Acutally run execute here like Executer.Execute(src.ToString());
                    MessageBox.Show(src);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TabPage activeTab = tabSystem.SelectedTab;

            if (activeTab != null)
            {
                WebBrowser editor = activeTab.Controls["newTab"] as WebBrowser;

                if (editor == null)
                {
                    foreach (Control control in activeTab.Controls)
                    {
                        if (control is WebBrowser)
                        {
                            editor = control as WebBrowser;
                            break;
                        }
                    }
                }
                if (editor != null)
                {
                    editor.Document.InvokeScript("setValue", new object[] { "" });
                }
            }
        }

        private async void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string src = File.ReadAllText(dialog.FileName);
                TabPage newTab = new TabPage();
                WebBrowser NWB = new WebBrowser();

                NWB.Width = 800;
                NWB.Height = 600;
                NWB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                NWB.Name = "newTab";
                NWB.Parent = newTab;

                string HFP = Path.Combine(Directory.GetCurrentDirectory(), "Monaco", "index.html");
                NWB.Navigate(new Uri($"file:///{HFP}"));

                await Task.Delay(500);

                if (src != null)
                {
                    NWB.Document.InvokeScript("setValue", new object[] { src });

                    int newTabIndex = tabSystem.TabCount + 1;
                    newTab.Name = "Script" + newTabIndex;
                    newTab.Text = dialog.SafeFileName;
                    newTab.Parent = tabSystem;
                    tabSystem.SelectTab(newTab);
                }
                else
                {
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            var src = webBrowser1.Document.InvokeScript("getValue");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, src.ToString());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void scriptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scriptsListBox.SelectedItem != null)
            {
                TabPage newTab = new TabPage();
                WebBrowser NWB = new WebBrowser();

                NWB.Width = 800; // Set the width as desired
                NWB.Height = 600; // Set the height as desired
                NWB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Anchor the control to all sides

                NWB.Name = "newTab";
                NWB.Parent = newTab;

                string HFP = Path.Combine(Directory.GetCurrentDirectory(), "Monaco", "index.html");
                NWB.Navigate(new Uri($"file:///{HFP}"));

                await Task.Delay(500);

                string src = File.ReadAllText("./Scripts/" + scriptsListBox.SelectedItem);
                if (src != null)
                {
                    NWB.Document.InvokeScript("setValue", new object[] { src });

                    int newTabIndex = tabSystem.TabCount + 1;
                    newTab.Name = "Script" + newTabIndex;
                    newTab.Text = "Script " + newTabIndex;
                    newTab.Parent = tabSystem;
                    tabSystem.SelectTab(newTab);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void newTab_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            WebBrowser NWB = new WebBrowser();

            string HFP = Path.Combine(Directory.GetCurrentDirectory(), "Monaco", "index.html");
            NWB.Navigate(new Uri($"file:///{HFP}"));

            int newTabIndex = tabSystem.TabCount + 1;

            newTab.Name = "Script" + newTabIndex;
            newTab.Text = "Script " + newTabIndex;
            newTab.Parent = tabSystem;

            NWB.Dock = DockStyle.Fill;
            NWB.Name = "newTab";
            NWB.Parent = newTab;

            tabSystem.SelectTab(newTab);
        }

        private void removeTab_Click(object sender, EventArgs e)
        {
            if (tabSystem.TabCount > 0)
            {
                TabPage tabPageToRemove = tabSystem.SelectedTab;
                tabSystem.TabPages.Remove(tabPageToRemove);

                if (tabSystem.TabCount > 0)
                {
                    tabSystem.SelectTab(tabSystem.TabCount - 1);
                }
            }
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            //You need your own code for this sorry :p
        }
    }
    public class MoveHelper
    {
        private Form form;
        private Control topBar;

        public MoveHelper(Form form)
        {
            this.form = form;
            this.topBar = form.Controls["topBar"];
        }

        public void InitializeMovablePanel()
        {
            topBar.MouseDown += new MouseEventHandler(TopBar_MouseDown);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}

