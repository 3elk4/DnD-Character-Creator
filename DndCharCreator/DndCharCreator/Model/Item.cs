using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharCreator.Model
{
    public class Item
    {
        public string Name { get; set; }
        public bool Exists { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }

        public Item()
        {
            this.Exists = true;
        }

        public Item(XmlModel.Item item)
        {
            this.Exists = item.Exists;
            this.Name = item.Name;
            this.Quantity = item.Quantity;
            this.Weight = item.Weight;
        }
    }
}
