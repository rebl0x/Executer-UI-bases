import tkinter as tk
import tkinter.ttk as ttk
from tkinter.constants import *

bgcolor = '#d9d9d9'
fgcolor = '#000000'
tabfg1 = 'black' 
tabfg2 = 'white' 
bgmode = 'light' 
tabbg1 = '#d9d9d9' 
tabbg2 = 'gray40' 

class DraggableWindow(tk.Tk):
    def __init__(self):
        super().__init__()

        self.geometry("600x429+660+231")
        self.minsize(120, 1)
        self.maxsize(3844, 1061)
        self.title("Toplevel 0")
        self.configure(background="#d9d9d9")
        self.configure(highlightbackground="#d9d9d9")
        self.configure(highlightcolor="#000000")

        self.top = self

        self.Execute = tk.Button(self.top)
        self.Execute.place(relx=0.017, rely=0.886, height=36, width=77)
        self.Execute.configure(activebackground="#f40000")
        self.Execute.configure(activeforeground="black")
        self.Execute.configure(background="#d9d9d9")
        self.Execute.configure(disabledforeground="#a3a3a3")
        self.Execute.configure(foreground="#000000")
        self.Execute.configure(highlightbackground="#d9d9d9")
        self.Execute.configure(highlightcolor="#000000")
        self.Execute.configure(text='''Execute''')

        self.SF = tk.Button(self.top)
        self.SF.place(relx=0.467, rely=0.886, height=36, width=77)
        self.SF.configure(activebackground="#f40000")
        self.SF.configure(activeforeground="black")
        self.SF.configure(background="#d9d9d9")
        self.SF.configure(disabledforeground="#a3a3a3")
        self.SF.configure(font="-family {Segoe UI} -size 9")
        self.SF.configure(foreground="#000000")
        self.SF.configure(highlightbackground="#d9d9d9")
        self.SF.configure(highlightcolor="#000000")
        self.SF.configure(text='''Save file''')

        self.OF = tk.Button(self.top)
        self.OF.place(relx=0.317, rely=0.886, height=36, width=77)
        self.OF.configure(activebackground="#f40000")
        self.OF.configure(activeforeground="black")
        self.OF.configure(background="#d9d9d9")
        self.OF.configure(disabledforeground="#a3a3a3")
        self.OF.configure(font="-family {Segoe UI} -size 9")
        self.OF.configure(foreground="#000000")
        self.OF.configure(highlightbackground="#d9d9d9")
        self.OF.configure(highlightcolor="#000000")
        self.OF.configure(text='''Open file''')

        self.TopBar = tk.Frame(self.top)
        self.TopBar.place(relx=0.0, rely=0.0, relheight=0.105, relwidth=1.008)
        self.TopBar.configure(relief="groove")
        self.TopBar.configure(background="#c0c0c0")
        self.TopBar.configure(highlightbackground="#d9d9d9")
        self.TopBar.configure(highlightcolor="#000000")

        self.Close = tk.Button(self.TopBar)
        self.Close.place(relx=0.926, rely=0.222, height=30, width=30)
        self.Close.configure(activebackground="#d9d9d9")
        self.Close.configure(activeforeground="black")
        self.Close.configure(background="#d9d9d9")
        self.Close.configure(disabledforeground="#a3a3a3")
        self.Close.configure(foreground="#000000")
        self.Close.configure(highlightbackground="#d9d9d9")
        self.Close.configure(highlightcolor="#000000")
        self.Close.configure(text='''X''')

        self.Pyexecuter = tk.Label(self.TopBar)
        self.Pyexecuter.place(relx=0.0, rely=0.0, height=41, width=105)
        self.Pyexecuter.configure(activebackground="#d9d9d9")
        self.Pyexecuter.configure(activeforeground="black")
        self.Pyexecuter.configure(anchor='w')
        self.Pyexecuter.configure(background="#c0c0c0")
        self.Pyexecuter.configure(compound='left')
        self.Pyexecuter.configure(disabledforeground="#a3a3a3")
        self.Pyexecuter.configure(font="-family {Segoe UI} -size 14")
        self.Pyexecuter.configure(foreground="#000000")
        self.Pyexecuter.configure(highlightbackground="#d9d9d9")
        self.Pyexecuter.configure(highlightcolor="#000000")
        self.Pyexecuter.configure(justify='left')
        self.Pyexecuter.configure(padx="5")
        self.Pyexecuter.configure(text='''Pyexecuter''')

        self.Inject = tk.Button(self.top)
        self.Inject.place(relx=0.167, rely=0.886, height=36, width=77)
        self.Inject.configure(activebackground="#f40000")
        self.Inject.configure(activeforeground="black")
        self.Inject.configure(background="#d9d9d9")
        self.Inject.configure(disabledforeground="#a3a3a3")
        self.Inject.configure(font="-family {Segoe UI} -size 9")
        self.Inject.configure(foreground="#000000")
        self.Inject.configure(highlightbackground="#d9d9d9")
        self.Inject.configure(highlightcolor="#000000")
        self.Inject.configure(text='''Inject''')

        self.Minimise = tk.Button(self.top)
        self.Minimise.place(relx=0.867, rely=0.023, height=30, width=30)
        self.Minimise.configure(activebackground="#d9d9d9")
        self.Minimise.configure(activeforeground="black")
        self.Minimise.configure(background="#d9d9d9")
        self.Minimise.configure(disabledforeground="#a3a3a3")
        self.Minimise.configure(font="-family {Segoe UI} -size 9")
        self.Minimise.configure(foreground="#000000")
        self.Minimise.configure(highlightbackground="#d9d9d9")
        self.Minimise.configure(highlightcolor="#000000")
        self.Minimise.configure(text='''-''')

        self.Text1 = tk.Text(self.top)
        self.Text1.place(relx=0.017, rely=0.14, relheight=0.732, relwidth=0.79)
        self.Text1.configure(background="white")
        self.Text1.configure(font="TkTextFont")
        self.Text1.configure(foreground="black")
        self.Text1.configure(highlightbackground="#d9d9d9")
        self.Text1.configure(highlightcolor="#000000")
        self.Text1.configure(insertbackground="#000000")
        self.Text1.configure(selectbackground="#d9d9d9")
        self.Text1.configure(selectforeground="black")
        self.Text1.configure(wrap="word")

        self.Clear = tk.Button(self.top)
        self.Clear.place(relx=0.678, rely=0.886, height=36, width=77)
        self.Clear.configure(activebackground="#f40000")
        self.Clear.configure(activeforeground="black")
        self.Clear.configure(background="#d9d9d9")
        self.Clear.configure(disabledforeground="#a3a3a3")
        self.Clear.configure(font="-family {Segoe UI} -size 9")
        self.Clear.configure(foreground="#000000")
        self.Clear.configure(highlightbackground="#d9d9d9")
        self.Clear.configure(highlightcolor="#000000")
        self.Clear.configure(text='''Clear''')
        self.overrideredirect(True)

        # Bind mouse events to handle window dragging
        self.bind("<ButtonPress-1>", self.start_drag)
        self.bind("<B1-Motion>", self.drag)

        # Variables to store mouse position
        self.x = 0
        self.y = 0

    def start_drag(self, event):
        self.x = event.x
        self.y = event.y

    def drag(self, event):
        deltax = event.x - self.x
        deltay = event.y - self.y
        x = self.winfo_x() + deltax
        y = self.winfo_y() + deltay
        self.geometry(f"+{x}+{y}")

if __name__ == "__main__":
    app = DraggableWindow()
    app.mainloop()
