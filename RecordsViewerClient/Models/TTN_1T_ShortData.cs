using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class TTN_1T_ShortData
    {
        public int id { get; set; }
        public float FirstWeight { get; set; }
        public float SecondWeight { get; set; }
        public int? Price { get; set; }

        public float Netto
        {
            get { return Math.Abs(FirstWeight - SecondWeight); }
        }
    }
}
