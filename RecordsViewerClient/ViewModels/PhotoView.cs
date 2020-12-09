using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RecordsViewerClient.ViewModels
{
    public class PhotoView : BindableBase
    {
        public PhotoView(IPhotoes photoes)
        {
            Photoes = photoes.Photos;
            RaisePropertyChanged(nameof(Photoes));
            Label = photoes.Label;
            RaisePropertyChanged(nameof(Label));
        }

        public byte[] Photoes { get; set; }
        public string Label { get; set; }
    }
}
