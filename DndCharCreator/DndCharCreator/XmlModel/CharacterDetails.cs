using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharCreator.XmlModel
{
    public class CharacterDetails
    {
        public string Name { get; set; }
        public Info Info { get; set; }
        public Bio Bio { get; set; }
    }
}
