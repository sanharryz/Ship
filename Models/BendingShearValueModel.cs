using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    internal class BendingShearValueModel
    {
        public string FrameNumber { get; set; }
        public double XPositiveValue { get; set; }
        public double YPositiveValue { get; set;}
        public double XNegativeValue { get; set; }
        public double YNegativeValue { get; set;}
    }
}
