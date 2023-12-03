using FontAwesome6;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UIBase.Converters
{
    public class WindowStateIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WindowState? state = value as WindowState?;
            if (state is WindowState.Normal)
            {
                return EFontAwesomeIcon.Regular_Square;
            }
            else
            {
                return EFontAwesomeIcon.Regular_WindowRestore;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
