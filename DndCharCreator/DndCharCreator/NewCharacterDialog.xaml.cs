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
    /// Interaction logic for NewCharacterDialog.xaml
    /// </summary>
    public partial class NewCharacterDialog : Window
    {
        private string MainFilename = @"\Data\Characters.xml";
        private string TemplateFilename = @"\Data\TemplateCharacter.xml";


        public NewCharacterDialog()
        {
            InitializeComponent();
        }

        private void SaveCharacter(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0) return;

            // character file
            string filename = CreateCharacterSheet();

            XmlDocument doc = new XmlDocument();
            doc.Load(Environment.CurrentDirectory + MainFilename);
            
            XmlElement node = doc.CreateElement("Character");
            node.SetAttribute("Name", name.Text);
            node.SetAttribute("Level", "1");
            node.SetAttribute("Path", filename);

            doc.SelectSingleNode("Characters").AppendChild(node);
            doc.Save(Environment.CurrentDirectory + MainFilename);
            doc = null;
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string CreateCharacterSheet()
        {
            XmlDocument temp = new XmlDocument();
            temp.Load(Environment.CurrentDirectory + TemplateFilename);
            string filename = $@"\Data\{name.Text.Replace(" ", "_")}_character.xml";

            var character = temp.SelectSingleNode("Character");
            character.SelectSingleNode("Name").InnerText = name.Text;
            character.SelectSingleNode("Level").InnerText = "1";

            temp.Save(Environment.CurrentDirectory + filename);
            temp = null;

            return filename; 
        }

    }
}
