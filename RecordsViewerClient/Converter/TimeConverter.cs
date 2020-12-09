using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Converter
{
    public class TimeConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
                      System.Globalization.CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime test = (DateTime)value;
                string date = test.ToShortTimeString();
                return (date);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value is DateTime)
                    return DateTime.Parse(value.ToString());
                else
                    return TimeSpan.Parse(value.ToString());
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); return null; }
        }
    }
}
