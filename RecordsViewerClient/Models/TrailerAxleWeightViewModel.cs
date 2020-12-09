using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class TrailerAxleWeightViewModel
    {
        public int? Number { get; set; }

        public List<string> WeightOnAxle { get; set; }

        public int? WheelPitch { get; set; }

        public float? InterAxleDistance { get; set; }

        public int? AxleGroup { get; set; }

        public float? GroupInTones { get; set; }

        public float? LimitInTones { get; set; }

        public string CarSuspension { get; set; }

        public string Weight { get; set; }
    }
}
