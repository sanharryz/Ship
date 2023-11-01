using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselLoader.Models
{
    class Object
    {
        #region member
        private double _wt;
        private Point _cg;

        #endregion


        #region Properties

        public double Weight
        {
            get
            {
                return this._wt;
            }

            set { this._wt = value; }

        }

        public Point CG
        {
            get
            {
                return this._cg;
            }

            set { this._cg = value; }
        }

        #endregion
    }
}
