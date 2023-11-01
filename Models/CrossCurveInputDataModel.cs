using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    internal class CrossCurveInputDataModel
    {
        public string MinHealingAngle { get; set; }
        public string MaxHealingAngle { get; set; }
        public string IncrementAngle { get; set; }
        public string MaxDraftMark { get; set;}
    }
}
