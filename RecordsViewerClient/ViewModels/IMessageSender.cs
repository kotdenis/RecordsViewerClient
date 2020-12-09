using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewModels
{
    public interface IMessageSender
    {
        string Label { get; set; }

        string Message { get; set; }

        int EnumCount { get; set; }

        Action CloseWindow { get; set; }
    }
}
