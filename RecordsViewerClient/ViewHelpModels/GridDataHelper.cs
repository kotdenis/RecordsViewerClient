using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewHelpModels
{
    static class GridDataHelper
    {
        public static string ToGridString(this DateTime date)
        {
            return date.ToString("dd.MM.yy");
        }

        public static string ToGridString(this TimeSpan time)
        {
            return time.ToString("hh\\:mm");
        }

        public static string ToGridString(this bool value)
        {
            return value ? "+" : "-";
        }
    }
}
