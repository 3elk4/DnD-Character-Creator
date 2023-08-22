using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DndCharCreator.XmlModel
{
    public class SavingThrows
    {
        [XmlIgnore]
        public bool Strength { get; set; }
        [XmlElement("Strength")]
        public string StrengthSerializer
        {
            get { return this.Strength ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Strength = true;
                else if (value.Equals("False"))
                    this.Strength = false;
                else
                    this.Strength = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Dexterity { get; set; }
        [XmlElement("Dexterity")]
        public string DexteritySerializer
        {
            get { return this.Dexterity ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Dexterity = true;
                else if (value.Equals("False"))
                    this.Dexterity = false;
                else
                    this.Dexterity = XmlConvert.ToBoolean(value);
            }
        }


        [XmlIgnore]
        public bool Constitution { get; set; }
        [XmlElement("Constitution")]
        public string ConstitutionSerializer
        {
            get { return this.Constitution ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Constitution = true;
                else if (value.Equals("False"))
                    this.Constitution = false;
                else
                    this.Constitution = XmlConvert.ToBoolean(value);
            }
        }


        [XmlIgnore]
        public bool Intelligence { get; set; }
        [XmlElement("Intelligence")]
        public string IntelligenceSerializer
        {
            get { return this.Intelligence ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Intelligence = true;
                else if (value.Equals("False"))
                    this.Intelligence = false;
                else
                    this.Intelligence = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Wisdom { get; set; }
        [XmlElement("Wisdom")]
        public string WisdomSerializer
        {
            get { return this.Wisdom ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Wisdom = true;
                else if (value.Equals("False"))
                    this.Wisdom = false;
                else
                    this.Wisdom = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Charisma { get; set; }
        [XmlElement("Charisma")]
        public string CharismaSerializer
        {
            get { return this.Charisma ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Charisma = true;
                else if (value.Equals("False"))
                    this.Charisma = false;
                else
                    this.Charisma = XmlConvert.ToBoolean(value);
            }
        }
    }
}
