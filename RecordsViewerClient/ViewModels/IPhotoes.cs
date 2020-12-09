using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewModels
{
    public interface IPhotoes
    {
        byte[] Photos { get; set; }

        string Label { get; set; }
    }
}
