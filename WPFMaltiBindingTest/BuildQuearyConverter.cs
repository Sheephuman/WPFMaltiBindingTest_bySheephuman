using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFMaltiBindingTest
{
  
        public class BuildQueryConverter : IMultiValueConverter
        {
            public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
            {

                if (values[0] is string buildQuery && !string.IsNullOrEmpty(buildQuery))
                {
                values[0] = $"-b:v{buildQuery}k";
                    return values[0];
                }
                return values[0];
        }

            public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
