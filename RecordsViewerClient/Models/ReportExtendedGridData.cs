using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class ReportExtendedGridData
    {
        public int? Number { get; set; }

        public int idWeighting { get; set; }

        public DateTime DateTimeSecondWeight { get; set; }
        public float FirstWeight { get; set; }
        public float SecondWeight { get; set; }

        public string TransportNumber { get; set; }
        public string Driver { get; set; }

        public string Cargo { get; set; }
        public string TypeOfCargo { get; set; }
        public string Counterparty { get; set; }
        public string Carrier { get; set; }
        public string TypeOperation { get; set; }

        public string Storage { get; set; }
        public string Placement { get; set; }

        public float Netto
        {
            get { return Math.Abs(FirstWeight - SecondWeight); }
        }
    }
}
