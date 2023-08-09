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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using DndCharCreator.Model;

namespace DndCharCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class CharacterInfo : Window
    {
        ObservableCollection<DnDClass> DndClasses { get; set; }

        private string filepath = null;
        public CharacterInfo(string path)
        {   
            InitializeComponent();
            //this.DataContext = this;
            UploadDetails(path);
            this.filepath = path;

            DndClasses = new ObservableCollection<DnDClass>();
            DndClasses.Add(new DnDClass());
            dndClasses.ItemsSource = DndClasses;
        }

        public string Filepath()
        {
            return filepath;
        }

        private void UploadDetails(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Environment.CurrentDirectory + path);

            var character = doc.SelectSingleNode("Character");
            charName.Text = character.SelectSingleNode("Name").InnerText;

            doc = null;
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length == 0) return;

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BrowseCharacterImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(dlg.FileName);
                bitmap.EndInit();
                character_image.Source = bitmap;
            }
        }

        private void OnAddNewDndClass(object sender, RoutedEventArgs e)
        {
            if (DndClasses.Count == 4) return;
            DndClasses.Add(new DnDClass());
        }

        private void OnDeleteDndClass(object sender, RoutedEventArgs e)
        {
            if (DndClasses.Count == 1) return;
            DndClasses.Remove((sender as FrameworkElement).DataContext as DnDClass);
        }
    }
    
}
