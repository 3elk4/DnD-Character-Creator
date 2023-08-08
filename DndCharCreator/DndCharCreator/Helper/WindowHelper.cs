using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DndCharCreator.Helper
{
    static class WindowHelper
    {
        public static void SwapWindows(Window window)
        {
            var mainWindow = App.Current.MainWindow;
            window.Top = mainWindow.Top;
            window.Left = mainWindow.Left; 
            mainWindow.Close();
            App.Current.MainWindow = window;
        }
    }
}
