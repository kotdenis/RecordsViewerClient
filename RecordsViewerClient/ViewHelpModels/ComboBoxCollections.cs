using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using RecordsViewerClient.ViewModels;
using Unity;

namespace RecordsViewerClient.ViewHelpModels
{
    public class ComboBoxCollections : BindableBase
    {
        
        public ComboBoxCollections()
        {
            WJ_WeiRoomsList = new List<string>();
            OperationTypeList = new List<string>();
            CargoList = new List<string>();
            CargoTypeList = new List<string>();
            CounterpartyList = new List<string>();
            CarrierList = new List<string>();
            DriverList = new List<string>();
        }


        public List<string> WJ_WeiRoomsList { get; set; }

        List<string> _operationTypeList;
        public List<string> OperationTypeList
        {
            get => _operationTypeList;
            set { _operationTypeList = value; RaisePropertyChanged(nameof(OperationTypeList)); }
        }

        public List<string> CargoList { get; set; }

        public List<string> CargoTypeList { get; set; }

        public List<string> CounterpartyList { get; set; }

        public List<string> CarrierList { get; set; }

        public List<string> DriverList { get; set; }
    }
}
