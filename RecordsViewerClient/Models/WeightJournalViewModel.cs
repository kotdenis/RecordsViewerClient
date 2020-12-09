using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class WeightJournalViewModel
    {
        public int? Number { get; set; }

        public int id { get; set; }

        public DateTime DateTimeFirstWeight { get; set; }
        public float FirstWeight { get; set; }

        public DateTime DateTimeSecondWeight { get; set; }
        public float SecondWeight { get; set; }

        //public ICollection<weighting_photo> PhotosWeight { get; set; }

        public string NumberInvoice { get; set; }
        public DateTime? DateInvoice { get; set; }

        public string TransportNumber { get; set; }
        public string TypeTransport { get; set; }
        public string TrailerNumber { get; set; }
        public string TypeTrailer { get; set; }
        public string Driver { get; set; }
        public string ModelTransport { get; set; }
        public string ModelTrailer { get; set; }

        public string Cargo { get; set; }
        public string Counterparty { get; set; }
        public string Carrier { get; set; }
        public string TypeOperation { get; set; }
        public string Storage { get; set; }
        public string StorageRec { get; set; }
        public string Placement { get; set; }
        public string Fund { get; set; }


        public string WeightRoomFirstWeight { get; set; }
        public string WeightRoomSecondWeight { get; set; }
        public bool HandleFirstWeight { get; set; }
        public bool HandleSecondWeight { get; set; }

        public double Netto
        {
            get { return Math.Round(Math.Abs(FirstWeight - SecondWeight), 2); }
        }
    }
}
