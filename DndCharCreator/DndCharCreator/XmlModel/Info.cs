using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DndCharCreator.XmlModel
{
    public class Info
    {
        public string Race { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }

        [XmlIgnore]
        public bool Inspiration { get; set; }
        [XmlElement("Inspiration")]
        public string InspirationSerializer
        {
            get { return this.Inspiration ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Inspiration = true;
                else if (value.Equals("False"))
                    this.Inspiration = false;
                else
                    this.Inspiration = XmlConvert.ToBoolean(value);
            }
        }


        public string AC { get; set; }
        public string Speed { get; set; }
        public string HP { get; set; }
        public string CurrentHP { get; set; }
        public string TempHP { get; set; }
        public string HitDice { get; set; }

        public DndClass[] DndClasses { get; set; }

        public Abilities Abilities { get; set; }
        public SavingThrows SavingThrows { get; set; }
        public Skills Skills { get; set; }

    }
}
