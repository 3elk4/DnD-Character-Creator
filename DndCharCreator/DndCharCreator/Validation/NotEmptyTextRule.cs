using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DndCharCreator.Validation
{
    class NotEmptyTextRule : ValidationRule

    {
        public NotEmptyTextRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (((string)value).Length > 0) return ValidationResult.ValidResult;
            
            return new ValidationResult(false,  $"Please enter some text!");
        }
    }
}
