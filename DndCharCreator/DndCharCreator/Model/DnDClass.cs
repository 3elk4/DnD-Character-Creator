using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharCreator.Model
{
    class DnDClass
    {
        public string Name { get; set; }
        public string SubclassName { get; set; }
        public int Lvl { get; set; }

        public DnDClass()
        {
            Name = "Class";
            SubclassName = "Subclass";
            Lvl = 1;
        }
    }
}
