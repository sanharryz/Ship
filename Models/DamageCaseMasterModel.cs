using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    public class DamageCaseMasterModel
    {
        public string DamageCaseName { get; set; }
        public List<string> TankNames { get; set; }
        public string TankNamesForDisplay { get; set; }
    }
}
