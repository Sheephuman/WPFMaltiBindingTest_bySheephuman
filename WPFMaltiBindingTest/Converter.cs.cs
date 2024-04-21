using System.Globalization;
using System.Windows.Data;

namespace WPFMaltiBindingTest
{
    public class MyMultiStringConverter
    {
        public object Convert(string[] values, Type targetType, object parameter, CultureInfo culture)
        {
            
            string val = values[0];           // ★xamlのMultiBindingで、1つ目に入れたもの
            string unit = values[1];    // ★xamlのMultiBindingで、2つ目に入れたもの
            
            string behind = values[2];  // ★xamlのMultiBindingで、3つ目に入れたもの

            return val.ToString() + unit + behind;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
