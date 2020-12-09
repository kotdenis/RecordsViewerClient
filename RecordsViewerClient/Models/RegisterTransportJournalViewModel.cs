using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class RegisterTransportJournalViewModel
    {
        public int? WeightingId { get; set; }
        public int RegWeightId { get; set; }
        public bool IsFirstWeight { get; set; }
        public string RecordKey { get; set; }
        public DateTime DateRegWeight { get; set; }
        public string PositionTS { get; set; }
        public string TypeOfRegweight { get; set; }
        public string TransportNumber { get; set; }
        public string TypeOfTransport { get; set; }
        public string TransportModel { get; set; }
        public string TrailerNumber { get; set; }
        public string TypeOfTrailer { get; set; }
        public string TrailerModel { get; set; }
        public string NumberInvoice { get; set; }
        public DateTime? DateInvoice { get; set; }
        public string User { get; set; }
        public string WeightRoom { get; set; }
        public string Storage { get; set; }
        public string Placement { get; set; }
        public string StorageRec { get; set; }
        public string PlacementRec { get; set; }
        public string TypeOperation { get; set; }
        public string Fund { get; set; }
        public string Plantation { get; set; }
        public bool Deleted { get; set; }
        public bool PassEnabled { get; set; }
        public bool AutoSaveTara { get; set; }
        public float? Tara { get; set; }
        public string Driver { get; set; }
        public string Counterparty { get; set; }
        public string Carrier { get; set; }
        public string Cargo { get; set; }
        public string TypeCargo { get; set; }
        public string LoadPoint { get; set; }
        public string UploadPoint { get; set; }
        public DateTime? DateFirstWeight { get; set; }
        public DateTime? DateSecondWeight { get; set; }
        public float? WeightFirstWeight { get; set; }
        public float? WeightSecondWeight { get; set; }
        public string WeightingTransportNumber { get; set; }
        public string IdentifierStatus { get; set; }
        public string PassType { get; set; }

        public float? Netto
        {
            get
            {
                return WeightFirstWeight.HasValue && WeightSecondWeight.HasValue ? (float?)Math.Abs(WeightFirstWeight.Value - WeightSecondWeight.Value) : null;
            }
        }


        public float? DOC_Tara { get; set; }
        public float? DOC_Netto { get; set; }
        public float? DOC_Brutto { get; set; }
    }
}
