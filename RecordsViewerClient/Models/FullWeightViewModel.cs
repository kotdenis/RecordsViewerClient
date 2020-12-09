using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class FullWeightViewModel : FirstWeightViewModel
    {
        public DateTime DateTimeSecondWeight { get; set; }
        public float SecondWeight { get; set; }
        public float? HandleSecondWeight { get; set; }
    }
}
