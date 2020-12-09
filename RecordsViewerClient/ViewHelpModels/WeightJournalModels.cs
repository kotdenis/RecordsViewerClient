using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewHelpModels
{
    public class WeightJournalModels
    {
        public object[] WeightRoomArray { get; set; }

        public object[] OperationTypeArray { get; set; }

        public Dictionary<int, string> WeiRoomIdDictionary { get; set; }

        public Dictionary<int, string> TypeOfOperation { get; set; }

        public string ExtendedStore { get; set; }

        public List<Tuple<string, int, bool, string>> ExtentsdFilterStoreList { get; set; }
    }
}


   