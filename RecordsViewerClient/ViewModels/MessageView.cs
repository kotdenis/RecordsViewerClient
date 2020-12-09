using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;

namespace RecordsViewerClient.ViewModels
{
    public class MessageView : BindableBase
    {
        
        IMessageSender _sender;
        public MessageView(IMessageSender sender)
        {
            _sender = sender;
            Label = sender.Label;
            RaisePropertyChanged(nameof(Label));
            Message = sender.Message;
            RaisePropertyChanged(nameof(Message));
            EnumCount = sender.EnumCount;
            RaisePropertyChanged(nameof(EnumCount));
            CloseCommand = new DelegateCommand(() => CloseMessageWindow());
        }

        public string Label { get; set; }
        public string Message { get; set; }
        public int EnumCount { get; set; }

        public DelegateCommand CloseCommand { get; }

        private void CloseMessageWindow()
        {
            _sender.CloseWindow.Invoke();
        }
    }
}
