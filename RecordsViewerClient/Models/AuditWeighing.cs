using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class AuditWeighing
    {
        public int id { get; set; }

        public float AuditWeight { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? PlatformNumber { get; set; }

        public int? id_dir_WeightRoom { get; set; }

        public string Name { get; set; }
    }
}
