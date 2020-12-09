using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class FirstWeightViewModel
    {
        public int id { get; set; }
        public DateTime DateTimeFirstWeight { get; set; }
        public float FirstWeight { get; set; }
        public float? HandleFirstWeight { get; set; }
        public bool FlagWeight { get; set; }
        public bool Deleted { get; set; }
        public string TransportNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string TypeTransport { get; set; }
        public string TypeTrailer { get; set; }
        public string Driver { get; set; }
        public string NumberInvoice { get; set; }
        public DateTime? DateInvoice { get; set; }
        public TimeSpan? TimeInvoice { get; set; }
        public string Fund { get; set; }
        public float? DOC_Tara { get; set; }
        public float? DOC_Netto { get; set; }
        public float? DOC_Brutto { get; set; }
        public string TypeOperation { get; set; }
        public string Counterparty { get; set; }
        public string Carrier { get; set; }
        public string Cargo { get; set; }
        public string TypeCargo { get; set; }
        public string Storage { get; set; }
        public string Placement { get; set; }
        public string StorageRec { get; set; }
        public string PlacementRec { get; set; }
        public string LoadPoint { get; set; }
        public string UpLoadPoint { get; set; }
        public string TypeOfPack { get; set; }

        public string TransportModel { get; set; }
        public string TrailerModel { get; set; }
    }
}
