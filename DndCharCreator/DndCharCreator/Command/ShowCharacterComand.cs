using DndCharCreator.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml;

namespace DndCharCreator.Command
{
    class ShowCharacterComand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private bool mainWindowsClosed = false;

        public bool CanExecute(object parameter)
        {
            return !mainWindowsClosed;
        }

        public void Execute(object parameter)
        {
            var path = parameter as XmlAttribute;
            
            CharacterInfo window = new CharacterInfo(path.Value);
            window.Show();

            if (!mainWindowsClosed)
            {
                WindowHelper.SwapWindows(window);
                mainWindowsClosed = true;
            }
        }
    }
}
