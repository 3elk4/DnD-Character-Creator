using DndCharCreator.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DndCharCreator.Command
{
    class ShowMainWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private bool mainWindowsClosed = false;

        public bool CanExecute(object parameter)
        {
            return !mainWindowsClosed;
        }
        public void Execute(object parameter)
        {
            MainWindow mainWindow = new MainWindow();
          
            if (!mainWindowsClosed)
            {
                WindowHelper.SwapWindows(mainWindow);
                mainWindow.Show();
                mainWindowsClosed = true;
            }
        }
    }
}
