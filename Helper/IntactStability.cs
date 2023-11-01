using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesselLoader.Models;

namespace VesselLoader.Helper
{
    class IntactStability
    {
        #region public
        public List<Summary> GetIntactSummaryInfo(ShipGeom ship, CrossCurve curveData, List<FixedWeightModel> fixedWt, List<LiquidWeightModel> liquidWt, List<Section> secList, List<Tank> tankList, double rho)
        {
            List<Summary> IntactSummary = new List<Summary>();
            OutputParamHelper outputhelper = new OutputParamHelper();

            Models.Object shpObj = outputhelper.IntactWtDetails(fixedWt, liquidWt);
            Models.Point trimDraft = outputhelper.GetTrimValue(ship, secList, shpObj.Weight, shpObj.CG.X, rho);
            double trim = trimDraft.Y - trimDraft.X;
            double draftMid = (trimDraft.X + trimDraft.Y) / 2;


            //heel
            double heel = outputhelper.GetHeelangle(shpObj.Weight, shpObj.CG, curveData);

            //GM
            double gm = outputhelper.GetGmfromSmalAngle(shpObj.CG, shpObj.Weight, ship, rho);
            double fsCorrection = this.getfsmcorrection(liquidWt, draftMid, tankList);

            IntactSummary.Add(new Summary("Trim", trim));
            IntactSummary.Add(new Summary("Heel", heel));
            IntactSummary.Add(new Summary("Displacement", shpObj.Weight));
            IntactSummary.Add(new Summary("LCG", shpObj.CG.X));
            IntactSummary.Add(new Summary("TCG", shpObj.CG.Y));
            IntactSummary.Add(new Summary("VCG", shpObj.CG.Z));
            IntactSummary.Add(new Summary("Draft AFT", trimDraft.X));
            IntactSummary.Add(new Summary("Draft MS", draftMid));
            IntactSummary.Add(new Summary("Draft FWD", trimDraft.Y));
            IntactSummary.Add(new Summary("GM(Fluid)", gm - fsCorrection));
            IntactSummary.Add(new Summary("GM(Solid)", gm));
            IntactSummary.Add(new Summary("FS Correction", fsCorrection));
            IntactSummary.Add(new Summary("VCG Correction", shpObj.CG.Z - fsCorrection));

            return IntactSummary;
        }
        #endregion public

        #region private

        private double getfsmcorrection(List<LiquidWeightModel> liqWtList, double meandraft, List<Tank> tankList)
        {
            PublicHelper pHelper = new PublicHelper();
            double fsc = 0;

            foreach (LiquidWeightModel liqWt in liqWtList)
            {
                foreach (Tank tank in tankList)
                {
                    if (liqWt.Tankname == tank.TankName)
                    {
                        double fscor = pHelper.InterpolateData(meandraft, tank.Fsmt, 2);
                        fsc = fsc + fscor;
                    }
                }
            }


            return fsc;

        }


        #endregion private
    }
}
