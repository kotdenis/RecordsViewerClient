using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class TransportTrailerModelsView
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string VehicleType { get; set; }

        public string SuspensionType { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Length { get; set; }

        public bool Deleted { get; set; }
    }
}
