using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace StudioX
{
    public class Equal2BooleanConverter : IValueConverter
    {
        private static Equal2BooleanConverter _instance = new Equal2BooleanConverter();
        public static Equal2BooleanConverter Instance
        {
            get
            {
                return _instance;
            }
        }
        private Equal2BooleanConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && parameter != null && value.ToString() == parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
