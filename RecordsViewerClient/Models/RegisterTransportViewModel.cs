using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class RegisterTransportViewModel
    {
        public int RegWeightId { get; set; }
        public string Name { get; set; }
        public bool PassEnabled { get; set; }
        public bool AutoSaveTara { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateRegWeight { get; set; }
        public int? PackCount { get; set; }
        public float? PackPrice { get; set; }
        public float? Tara { get; set; }
        public float? DOC_Tara { get; set; }
        public float? DOC_Netto { get; set; }
        public float? DOC_Brutto { get; set; }
        public string TransportNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string TypeOfTransport { get; set; }
        public string TypeOfTrailer { get; set; }
        public string Driver { get; set; }
        public byte TypeOfRegweightId { get; set; }
        public string IdentifierStatus { get; set; }
        public string PassType { get; set; }
        public DateTime? DatePassExpiry { get; set; }
        public TimeSpan? TimePassExpiry { get; set; }
        public string NumberInvoice { get; set; }
        public string Plantation { get; set; }
        public string TypeOperation { get; set; }
        public string Counterparty { get; set; }
        public string Carrier { get; set; }
        public string Cargo { get; set; }
        public string TypeCargo { get; set; }
        public string Storage { get; set; }
        public string Placement { get; set; }
        public string StorageRec { get; set; }
        public string PlacementRec { get; set; }
        public string Fund { get; set; }
        public int CreatedByUserId { get; set; }
        public string TypeOfTransModels { get; set; }
        public string TypeOfTrailModels { get; set; }
    }
}
