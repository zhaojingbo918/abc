using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace StudioX
{
    public class Boolean2VisibilityConverter : IValueConverter
    {
        private static Boolean2VisibilityConverter _instance = new Boolean2VisibilityConverter();
        public static Boolean2VisibilityConverter Instance
        {
            get
            {
                return _instance;
            }
        }
        private Boolean2VisibilityConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value != null && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
