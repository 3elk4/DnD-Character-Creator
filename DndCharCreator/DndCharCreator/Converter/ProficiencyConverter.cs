using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DndCharCreator.Converter
{
    class ProficiencyConverter : IValueConverter
    {
        private Dictionary<Func<int, bool>, int> proficiencies = new Dictionary<Func<int, bool>, int>()
        {
            { x => x > 0 && x <= 4, 2 },
            { x => x > 4 && x <= 8, 3 },
            { x => x > 8 && x <= 12, 4 },
            { x => x > 12 && x <= 16, 5 },
            { x => x > 16 && x <= 20, 6 }
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string input = (string)value;
            if (input.Length == 0) return "";

            int x = Int32.Parse(input);

            var key = proficiencies.Keys.Single(choose => choose(x));
            return proficiencies[key];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
