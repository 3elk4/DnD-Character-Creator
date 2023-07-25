using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DndCharCreator.Converter
{
    class LvlConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int result = 0;
            if (((string)values[0]).Length != 0) result += Int32.Parse((string)values[0]);
            if (((string)values[1]).Length != 0) result += Int32.Parse((string)values[1]);
            if (((string)values[2]).Length != 0) result += Int32.Parse((string)values[2]);

            return result.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
