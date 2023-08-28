using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharCreator.Model
{
    public class Feat
    {
        public string Title { get; set; }
        public string Source { get; set; }
        public string SourceType { get; set; }
        public string Definition { get; set; }

        public Feat() { }
        public Feat(XmlModel.Feat feat)
        {
            this.Title = feat.Title;
            this.Source = feat.Source;
            this.SourceType = feat.SourceType;
            this.Definition = feat.Definition;
        }
    }
}
