using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Filters
{
    public class RegWeightExtendedFilter
    {
        public int[] TypeOfOperation { get; set; }
        public int[] Cargo { get; set; }
        public int[] TypeOfCargo { get; set; }
        public int[] Counterparty { get; set; }
        public int[] Carrier { get; set; }
        public int[] Storage { get; set; }
        public int[] Placement { get; set; }
        public int[] StorageRec { get; set; }
        public int[] Fund { get; set; }
        public int[] Consignee { get; set; } // грузополучатель
        public int[] Shipper { get; set; } // грузоотправитель
        public int[] LoadPoint { get; set; }
        public int[] UploadPoint { get; set; }

        //public bool IsNotEmpty
        //{
        //    get
        //    {
        //        foreach (PropertyInfo pi in (typeof(RegWeightExtendedFilter)).GetProperties())
        //        {
        //            if (pi.PropertyType == typeof(int[]))
        //            {
        //                var value = (int[])pi.GetValue(this, null);
        //                if (value.Length > 0)
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //        return false;
        //    }
        //}
    }
}
