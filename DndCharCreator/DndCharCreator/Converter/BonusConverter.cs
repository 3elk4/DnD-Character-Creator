using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DndCharCreator.Converter
{
    class BonusConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int mod = 0;
            if(((string)values[0]).Length != 0) mod = Int32.Parse((string)values[0]);
            int prof = 0;
            if (((string)values[2]).Length != 0 && ((bool)values[1]) == true) prof = Int32.Parse((string)values[2]);

            return (mod + prof).ToString(); //todo: to consider `plus another values`
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
