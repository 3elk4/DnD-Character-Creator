using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharCreator.Model
{
    public class Proficiency
    {
        public IEnumerable<string> ProficiencyTypes { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Proficiency() {
            ProficiencyTypes = new List<string>() { "Armor", "Weapon", "Language", "Tool", "Other" };
        }
        public Proficiency(XmlModel.Proficiency proficiency)
        {
            ProficiencyTypes = new List<string>() { "Armor", "Weapon", "Language", "Tool", "Other" };
            this.Name = proficiency.Name;
            this.Type = proficiency.Type;
        }
    }
}
