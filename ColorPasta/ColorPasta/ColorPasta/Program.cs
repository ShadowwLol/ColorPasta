using System;
using Gtk;

namespace Safenotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int width = 500;
            int height = 300;
            Application.Init();
            MainWindow win = new MainWindow();
            win.Title = "ColorPasta";
            win.SetSizeRequest(width, height);
            win.SetDefaultSize(width, height);
            win.Show();
            Application.Run();
        }
    }
}
