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
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
        }
    }
}
