using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;

namespace DndCharCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class CharacterInfo : Window
    {
        private string filepath = null;
        public CharacterInfo(string path)
        {
            InitializeComponent();
            UploadDetails(path);
            this.filepath = path;

            IEnumerable<int> range = Enumerable.Range(0, 20);
            lvl1.ItemsSource = range;
            lvl2.ItemsSource = range;
            lvl3.ItemsSource = range;
            lvl4.ItemsSource = range;

            range = Enumerable.Range(1, 20);
            strength.ItemsSource = range;
            dexterity.ItemsSource = range;
            constitution.ItemsSource = range;
            intelligence.ItemsSource = range;
            wisdom.ItemsSource = range;
            charisma.ItemsSource = range;
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
    }
}
