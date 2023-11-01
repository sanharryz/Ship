using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    public class SolidFixedWeightModel
    {
        public string FSM { get; set; }
        public string LCG { get; set; }
        public string Name { get; set; }
        public string TCG { get; set; }
        public string VCG {get;set; }
        public string Weight { get; set; }
    }

    public class SolidFixedWeightModeList
    {
        public List<SolidFixedWeightModel> FixedWeights { get; set; }
    }
}
