using System;
using System.Globalization;

namespace SplitBillApp.Converters
{
    internal class FriendIdToMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(parameter is null)
                throw new ArgumentNullException(nameof(parameter));

            int id = System.Convert.ToInt32(value);
            int margin = System.Convert.ToInt32(parameter);

            if (id == 1)
                return Thickness.Zero;

            return new Thickness(-margin, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
