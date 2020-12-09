using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Filters
{
    public class ReportGridFilter
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int? CargoId { get; set; }
        public int? TypeOfCargoId { get; set; }
        public int? CounterpartyId { get; set; }
        public int? CarrierId { get; set; }
        public int? TypeOfOperationId { get; set; }
        public int? DriverId { get; set; }
        public int? StorageId { get; set; }
        public int? PlacementId { get; set; }
        public string TransportNumber { get; set; }
    }
}
