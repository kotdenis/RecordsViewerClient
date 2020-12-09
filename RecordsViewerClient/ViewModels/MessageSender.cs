using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewModels
{
    public class MessageSender : IMessageSender
    {
        public string Label { get; set; }
        public string Message { get; set; }
        public int EnumCount { get; set; }
        public Action  CloseWindow { get; set; }
    }
}
