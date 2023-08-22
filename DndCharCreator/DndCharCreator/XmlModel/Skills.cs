using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DndCharCreator.XmlModel
{
    public class Skills
    {
        [XmlIgnore]
        public bool Perception { get; set; }
        [XmlElement("Perception")]
        public string PerceptionSerializer
        {
            get { return this.Perception ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Perception = true;
                else if (value.Equals("False"))
                    this.Perception = false;
                else
                    this.Perception = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Survival { get; set; }
        [XmlElement("Survival")]
        public string SurvivalSerializer
        {
            get { return this.Survival ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Survival = true;
                else if (value.Equals("False"))
                    this.Survival = false;
                else
                    this.Survival = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool AnimalHandling { get; set; }
        [XmlElement("AnimalHandling")]
        public string AnimalHandlingSerializer
        {
            get { return this.AnimalHandling ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.AnimalHandling = true;
                else if (value.Equals("False"))
                    this.AnimalHandling = false;
                else
                    this.AnimalHandling = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Medicine { get; set; }
        [XmlElement("Medicine")]
        public string MedicineSerializer
        {
            get { return this.Medicine ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Medicine = true;
                else if (value.Equals("False"))
                    this.Medicine = false;
                else
                    this.Medicine = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Insight { get; set; }
        [XmlElement("Insight")]
        public string InsightSerializer
        {
            get { return this.Insight ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Insight = true;
                else if (value.Equals("False"))
                    this.Insight = false;
                else
                    this.Insight = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Arcana { get; set; }
        [XmlElement("Arcana")]
        public string ArcanaSerializer
        {
            get { return this.Arcana ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Arcana = true;
                else if (value.Equals("False"))
                    this.Arcana = false;
                else
                    this.Arcana = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Religion{ get; set; }
        [XmlElement("Religion")]
        public string ReligionSerializer
        {
            get { return this.Religion? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Religion= true;
                else if (value.Equals("False"))
                    this.Religion= false;
                else
                    this.Religion = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool History { get; set; }
        [XmlElement("History")]
        public string HistorySerializer
        {
            get { return this.History ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.History = true;
                else if (value.Equals("False"))
                    this.History = false;
                else
                    this.History = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Investigation { get; set; }
        [XmlElement("Investigation")]
        public string InvestigationSerializer
        {
            get { return this.Investigation ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Investigation = true;
                else if (value.Equals("False"))
                    this.Investigation = false;
                else
                    this.Investigation = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Nature { get; set; }
        [XmlElement("Nature")]
        public string NatureSerializer
        {
            get { return this.Nature ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Nature = true;
                else if (value.Equals("False"))
                    this.Nature = false;
                else
                    this.Nature = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Athletics { get; set; }
        [XmlElement("Athletics")]
        public string AthleticsSerializer
        {
            get { return this.Athletics ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Athletics = true;
                else if (value.Equals("False"))
                    this.Athletics = false;
                else
                    this.Athletics = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Acrobatics { get; set; }
        [XmlElement("Acrobatics")]
        public string AcrobaticsSerializer
        {
            get { return this.Acrobatics ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Acrobatics = true;
                else if (value.Equals("False"))
                    this.Acrobatics = false;
                else
                    this.Acrobatics = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Stealth { get; set; }
        [XmlElement("Stealth")]
        public string StealthSerializer
        {
            get { return this.Stealth ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Stealth = true;
                else if (value.Equals("False"))
                    this.Stealth = false;
                else
                    this.Stealth = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool SleightOfHand { get; set; }
        [XmlElement("SleightOfHand")]
        public string SleightOfHandSerializer
        {
            get { return this.SleightOfHand ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.SleightOfHand = true;
                else if (value.Equals("False"))
                    this.SleightOfHand = false;
                else
                    this.SleightOfHand = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Deception { get; set; }
        [XmlElement("Deception")]
        public string DeceptionSerializer
        {
            get { return this.Deception ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Deception = true;
                else if (value.Equals("False"))
                    this.Deception = false;
                else
                    this.Deception = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Intimidation { get; set; }
        [XmlElement("Intimidation")]
        public string IntimidationSerializer
        {
            get { return this.Intimidation ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Intimidation = true;
                else if (value.Equals("False"))
                    this.Intimidation = false;
                else
                    this.Intimidation = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Performance { get; set; }
        [XmlElement("Performance")]
        public string PerformanceSerializer
        {
            get { return this.Performance ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Performance = true;
                else if (value.Equals("False"))
                    this.Performance = false;
                else
                    this.Performance = XmlConvert.ToBoolean(value);
            }
        }

        [XmlIgnore]
        public bool Persuasion { get; set; }
        [XmlElement("Persuasion")]
        public string PersuasionSerializer
        {
            get { return this.Persuasion ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Persuasion = true;
                else if (value.Equals("False"))
                    this.Persuasion = false;
                else
                    this.Persuasion = XmlConvert.ToBoolean(value);
            }
        }
    }
}
