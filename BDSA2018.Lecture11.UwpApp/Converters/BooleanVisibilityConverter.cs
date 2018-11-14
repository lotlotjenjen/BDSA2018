using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace BDSA2018.Lecture11.UwpApp.Converters
{
    public sealed class BooleanVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool v && v)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is Visibility v)
            {
                return v == Visibility.Visible;
            }

            return false;
        }
    }
}
