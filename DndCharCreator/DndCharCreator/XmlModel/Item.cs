using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DndCharCreator.XmlModel
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }

        [XmlIgnore]
        public bool Exists { get; set; }
        [XmlElement("Exists")]
        public string InspirationSerializer
        {
            get { return this.Exists ? "True" : "False"; }
            set
            {
                if (value.Equals("True"))
                    this.Exists = true;
                else if (value.Equals("False"))
                    this.Exists = false;
                else
                    this.Exists = XmlConvert.ToBoolean(value);
            }
        }
        public Item() { }
        public Item(Model.Item item)
        {
            this.Name = item.Name;
            this.Weight = item.Weight;
            this.Quantity = item.Quantity;
            this.Exists = item.Exists;
        }
    }
}
