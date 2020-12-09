using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Filters
{
    public class SimpleRegWeightFilter
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int? WeightRoomId { get; set; }
        public int? PlatformNummer { get; set; }
    }
}
