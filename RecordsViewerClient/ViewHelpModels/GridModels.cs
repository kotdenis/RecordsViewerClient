using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.ViewHelpModels
{
    public class GridModels
    {
        public object[] ArrayOne { get; set; }

        public object[] ArrayTwo { get; set; }

        public object[] ArrayThree { get; set; }

        public List<Tuple<int, string>> GridIdFirstComboNames { get; set; }

        public List<Tuple<int, string>> GridIdSecondComboNames { get; set; } 

        public List<Tuple<int, string>> GridIdThirdComboNames { get; set; }
    }
}
