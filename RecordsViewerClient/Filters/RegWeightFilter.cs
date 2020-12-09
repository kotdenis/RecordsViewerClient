using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Filters
{
    public class RegWeightFilter
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int? WeightRoomId { get; set; }
        public int? TypeOfOperationId { get; set; }
        public string TransportNumber { get; set; }
        public int? PlatformNumber { get; set; }
        public bool HandleWeightOnly { get; set; }
        public bool CancelledWeightOnly { get; set; }
    }
}
