using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    
    public class Liquid
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class LiquidMasterData
    {
        public List<Liquid> Liquids { get; set; }
    }
}
