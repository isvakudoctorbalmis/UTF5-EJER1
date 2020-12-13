

using System;
using System.Globalization;
using System.Windows.Data;

namespace UTF5_EJER1
{
    public class Conversorvisibilida : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                 
                return "Visible";
            }
            else
                return "collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
