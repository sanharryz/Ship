using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    internal class IntactCriteriaModelList
    {
        public List<IntactCriteriaModel> IntactCriteriaModels { get; set; }
    }

    public class IntactCriteriaModel
    {
        public string Limit { get; set; }
        public string MinMaxValue { get; set; }
        public string Actual { get; set; }
        public string Margin { get; set; }
        public string Pass { get; set; }
    }
}
