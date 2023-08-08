using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace DndCharCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewCharacter(object sender, RoutedEventArgs e)
        {
            NewCharacterDialog modalWindow = new NewCharacterDialog();
            Visibility = Visibility = Visibility.Hidden;
            modalWindow.ShowDialog();
            Visibility = Visibility = Visibility.Visible;

            XmlDataProvider xmlDataProvider = (XmlDataProvider)this.FindResource("Characters");
            xmlDataProvider.Refresh();

        }
    }
}
