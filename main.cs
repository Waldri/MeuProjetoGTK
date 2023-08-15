using Gtk;
using System;

class Program
{
    static void Main(string[] args)
    {
        Application.Init();

        Window window = new Window("GTK# Hello World");
        window.DeleteEvent += delegate { Application.Quit(); };
        
        Gtk.Builder builder = new Gtk.Builder();
        builder.AddFromFile("glade.glade");
        
        // Get a reference to a widget from the Glade file
        Button button = (Button)builder.GetObject("button1");
        button.Clicked += OnButtonClicked;
        window.Add(button);

        // Create a new window
        Gtk.Window newWindow = (Gtk.Window)builder.GetObject("GtkWindows");
        newWindow.Title = "New Window";
        Button button2 = (Button)builder.GetObject("button2");
        button2.Clicked += OnButtonClicked;
        newWindow.ShowAll();
        window.ShowAll();

        Application.Run();
    }
    
    static void OnButtonClicked(object sender, EventArgs args)
    {
        Button button = (Button)sender;
        button.Label = "Clicado!";
    }

}