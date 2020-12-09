using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class SettingApp
    {
        public int id { get; set; }

        public int? id_company { get; set; }

        public string CompanyName { get; set; }

        public bool TSNumberMaskUse { get; set; }

        public string TSNumberMask { get; set; }

        public bool NeedOperationType { get; set; }

        public bool NeedFund { get; set; }

        public bool NeedCargoType { get; set; }

        public bool NeedPlacement { get; set; }

        public string PhotoDirectory { get; set; }

        public float ConditionalZero { get; set; }

        public int? ModifiedByUserId { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
