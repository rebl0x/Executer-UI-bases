namespace ExecuterBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBar = new System.Windows.Forms.Panel();
            this.removeTab = new System.Windows.Forms.Button();
            this.newTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSystem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.scriptsListBox = new System.Windows.Forms.ListBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.AttachButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TopBar.Controls.Add(this.removeTab);
            this.TopBar.Controls.Add(this.newTab);
            this.TopBar.Controls.Add(this.label3);
            this.TopBar.Controls.Add(this.MinimiseButton);
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.Controls.Add(this.label2);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Location = new System.Drawing.Point(0, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(801, 49);
            this.TopBar.TabIndex = 0;
            // 
            // removeTab
            // 
            this.removeTab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeTab.FlatAppearance.BorderSize = 0;
            this.removeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTab.Location = new System.Drawing.Point(621, 7);
            this.removeTab.Name = "removeTab";
            this.removeTab.Size = new System.Drawing.Size(34, 40);
            this.removeTab.TabIndex = 13;
            this.removeTab.Text = "-";
            this.removeTab.UseVisualStyleBackColor = false;
            this.removeTab.Click += new System.EventHandler(this.removeTab_Click);
            // 
            // newTab
            // 
            this.newTab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newTab.FlatAppearance.BorderSize = 0;
            this.newTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTab.Location = new System.Drawing.Point(661, 7);
            this.newTab.Name = "newTab";
            this.newTab.Size = new System.Drawing.Size(34, 40);
            this.newTab.TabIndex = 12;
            this.newTab.Text = "+";
            this.newTab.UseVisualStyleBackColor = false;
            this.newTab.Click += new System.EventHandler(this.newTab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(701, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "|";
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimiseButton.FlatAppearance.BorderSize = 0;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseButton.Location = new System.Drawing.Point(724, 6);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(34, 40);
            this.MinimiseButton.TabIndex = 10;
            this.MinimiseButton.Text = "-";
            this.MinimiseButton.UseVisualStyleBackColor = false;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(764, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 40);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabSystem
            // 
            this.tabSystem.Controls.Add(this.tabPage1);
            this.tabSystem.Location = new System.Drawing.Point(12, 54);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.SelectedIndex = 0;
            this.tabSystem.Size = new System.Drawing.Size(653, 321);
            this.tabSystem.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(639, 289);
            this.webBrowser1.TabIndex = 0;
            // 
            // scriptsListBox
            // 
            this.scriptsListBox.FormattingEnabled = true;
            this.scriptsListBox.Items.AddRange(new object[] {
            "scriptsListBox"});
            this.scriptsListBox.Location = new System.Drawing.Point(671, 76);
            this.scriptsListBox.Name = "scriptsListBox";
            this.scriptsListBox.Size = new System.Drawing.Size(120, 368);
            this.scriptsListBox.TabIndex = 2;
            this.scriptsListBox.SelectedIndexChanged += new System.EventHandler(this.scriptsListBox_SelectedIndexChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(16, 398);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(110, 40);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // AttachButton
            // 
            this.AttachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachButton.Location = new System.Drawing.Point(132, 398);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(110, 40);
            this.AttachButton.TabIndex = 5;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = true;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(370, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 40);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(248, 398);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(116, 40);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Open File";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(551, 398);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 40);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.scriptsListBox);
            this.Controls.Add(this.tabSystem);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.TabControl tabSystem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox scriptsListBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button removeTab;
        private System.Windows.Forms.Button newTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

