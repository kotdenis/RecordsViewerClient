using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class WeighingRoomSettingsModel
    {
        public int id { get; set; }

        public bool Enable { get; set; }

        public string PhotoDirectory { get; set; }

        public string IPAddress { get; set; }

        public int? Port { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedByUserId { get; set; }

        public string WeighingName { get; set; }

        public string ConnectionString { get; set; }
    }
}
