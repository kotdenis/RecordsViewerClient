using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewModels
{
    public class Photoes : IPhotoes
    {
        public byte[] Photos { get; set; }
        public string Label { get; set; }
    }
}
