using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecordsViewerClient.Models
{
    public class AxleReportViewData
    {
        public int? Number { get; set; }

        public int id { get; set; }

        public DateTime? WeightDate { get; set; }

        public TimeSpan? WeightTime { get; set; }

        public string TotalWeifgt { get; set; }

        public int? WeightNumber { get; set; }

        public string TransportMark { get; set; }

        public string TransportType { get; set; }

        public string TransportModel { get; set; }

        public string TransportNumber { get; set; }

        public string TrailerType { get; set; }

        public string TrailerModel { get; set; }

        public string TrailerNumber { get; set; }

        public string DriverName { get; set; }

        public float? Width { get; set; }

        public float? Height { get; set; }

        public float? Length { get; set; }

        public int? AllAxles { get; set; }

        public float? WeightAllowed { get; set; }
    }
}
