﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using DndCharCreator.XmlModel;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using DndCharCreator.Model;
using System.Windows.Controls;

namespace DndCharCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class CharacterInfo : Window
    {
        private string filepath = null;
        public CharacterDetails details { get; set; }

        public ObservableCollection<DndCharCreator.Model.Item> Items { get; set; }
        public ObservableCollection<DndCharCreator.Model.Feat> Feats { get; set; }
        public ObservableCollection<DndCharCreator.Model.Proficiency> Proficiencies { get; set; }

        string OldWeight = string.Empty;

        public CharacterInfo(string path)
        {
            InitializeComponent();
            UploadDetails(path);
            this.filepath = path;
            this.DataContext = details;

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

            Items = new ObservableCollection<DndCharCreator.Model.Item>();
            if (details.Items != null)
            {
                foreach (var item in details.Items) Items.Add(new Model.Item(item));
            }
            characterItems.ItemsSource = Items;

            Feats = new ObservableCollection<DndCharCreator.Model.Feat>();
            if (details.Feats != null)
            {
                foreach (var feat in details.Feats) Feats.Add(new Model.Feat(feat));
            }
            feats.ItemsSource = Feats;

            Proficiencies = new ObservableCollection<DndCharCreator.Model.Proficiency>();
            if (details.Proficiencies != null)
            {
                foreach (var proficiency in details.Proficiencies) Proficiencies.Add(new Model.Proficiency(proficiency));
            }
            proficiencies.ItemsSource = Proficiencies;
        }

        public string Filepath()
        {
            return filepath;
        }

        private void UploadDetails(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CharacterDetails));
            using (Stream reader = new FileStream(Environment.CurrentDirectory + path, FileMode.Open))
            {
                details = (CharacterDetails)serializer.Deserialize(reader);
            }
        }

        private void SaveDetails(object sender, RoutedEventArgs e)
        {
            try
            {
                details.Items = Items.Select(item => new XmlModel.Item(item)).ToArray();
                details.Feats = Feats.Select(feat => new XmlModel.Feat(feat)).ToArray();
                details.Proficiencies = Proficiencies.Select(proficiency => new XmlModel.Proficiency(proficiency)).ToArray();

                XmlSerializer serializer = new XmlSerializer(typeof(CharacterDetails));
                TextWriter writer = new StreamWriter(Environment.CurrentDirectory + filepath);
                serializer.Serialize(writer, details);
                writer.Close();
                saveErrorTextBlock.Text = "Data saved successfully!";
            }
            catch(Exception)
            {
                saveErrorTextBlock.Text = "Error occured while saving file!";
            }
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

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext as Model.Item;
            totalWeight.Text = (Int32.Parse(totalWeight.Text) - item.Weight).ToString();
            Items.Remove(item);
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            Items.Add(new Model.Item());
        }

        private void DeleteFeat(object sender, RoutedEventArgs e)
        {
            var feat = (sender as FrameworkElement).DataContext as Model.Feat;
            Feats.Remove(feat);
        }

        private void AddFeat(object sender, RoutedEventArgs e)
        {
            Feats.Add(new Model.Feat());
        }

        private void DeleteProficiency(object sender, RoutedEventArgs e)
        {
            var proficiency = (sender as FrameworkElement).DataContext as Model.Proficiency;
            Proficiencies.Remove(proficiency);
        }

        private void AddProficiency(object sender, RoutedEventArgs e)
        {
            Proficiencies.Add(new Model.Proficiency());
        }
        private void WeightGotFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0) return;
            OldWeight = ((TextBox)sender).Text;
        }

        private void WeightTextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0) return;

            double newValue = double.Parse(((TextBox)sender).Text);
            double oldValue = double.Parse(OldWeight);
            var act = double.Parse(totalWeight.Text);

            totalWeight.Text = (act - oldValue + newValue).ToString();
            OldWeight = ((TextBox)sender).Text;
        }
    }
}
