using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    public class TankMappingModel
    {
        public List<TankMapping> TankMappings { get; set; }
    }

    public class TankMapping
    {
        public string TankName { get; set; }
        public string LiquidName { get; set; }
    }
}
