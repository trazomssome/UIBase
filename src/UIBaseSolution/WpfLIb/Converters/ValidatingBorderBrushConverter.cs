using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Provider;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfLIb.Converters
{
    public class ValidatingBorderBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool? isValidation = values[0] as bool?;
            if (isValidation.HasValue && isValidation == true)
            {
                return Brushes.Red;
            }
            else
            {
                return (Brush)values[1];
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
