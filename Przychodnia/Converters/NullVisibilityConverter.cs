using PrzychodniaDLL;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Przychodnia
{
    public class NullVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null || (value is BaseDLL baseDLL && baseDLL.Id == 0) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
