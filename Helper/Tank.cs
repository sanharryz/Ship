using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesselLoader.Models;
using Point = VesselLoader.Models.Point;

namespace VesselLoader.Helper
{
    class Tank
    {
        #region member variable
        List<SectionCurve> _tankCurvedata;
        double _liquidrho;
        List<Point2D> _voldata;
        List<Point2D> _massdata;
        List<Point2D> _percentageOffilling;
        List<Point2D> _tankLcg;
        List<Point2D> _tankTcg;
        List<Point2D> _tankVcg;
        List<Point2D> _fsmt;
        List<Point2D> _fsml;
        List<SectionCurve> _sectankDraftVarea;
        double _maxWeight;
        double _permiability;
        string _tankName;
        string _tankCode;
        double _weight;
        double _volume;
        double _volumePercentage;
        double _vcg;
        double _lcg;
        double _tcg;
        double _fsm;


        #endregion member variable

        #region Consturctor
        public Tank()
        {
            this._tankCurvedata = new List<SectionCurve>();
            this._liquidrho = new double();
            this._voldata = new List<Point2D>();
            this._massdata = new List<Point2D>();
            this._percentageOffilling = new List<Point2D>();
            this._tankLcg = new List<Point2D>();
            this._tankTcg = new List<Point2D>();
            this._tankVcg = new List<Point2D>();
            this._fsmt = new List<Point2D>();
            this._fsml = new List<Point2D>();
            this._maxWeight = new double();
            this._permiability = new double();
            this._weight = new double();
            this._volume = new double();
            this._volumePercentage = new double();
            this._vcg = new double();
            this._lcg = new double();
            this._tcg = new double();
            this._fsm = new double();
            this._sectankDraftVarea = new List<SectionCurve>();



        }
        #endregion Constructor

        #region properties
        public double LiquidRho
        {
            get { return this._liquidrho; }
            set { this._liquidrho = value; }
        }

        public List<SectionCurve> TankCurvedata

        {
            get
            {
                return this._tankCurvedata;
            }
            //set
            //{
            //    this._tankCurvedata = value;
            //}
        }
        public List<Point2D> VolumeData
        {
            get
            {
                return this._voldata;
            }
        }
        public List<Point2D> MassData
        {
            get
            {
                return this._massdata;
            }
        }
        public List<Point2D> PerOfFilling
        {
            get
            {
                return this._percentageOffilling;
            }
        }
        public List<Point2D> TankLcg
        {
            get
            {
                return this._tankLcg;
            }
        }
        public List<Point2D> TankTcg
        {
            get
            {
                return this._tankTcg;
            }
        }
        public List<Point2D> TankVcg
        {
            get
            {
                return this._tankVcg;
            }
        }
        public List<Point2D> Fsmt
        {
            get
            {
                return this._fsmt;
            }
        }
        public List<Point2D> Fsml
        {
            get
            {
                return this._fsml;
            }
        }

        public double MaxWeight
        {
            get
            {
                return this._maxWeight;
            }
            set
            {
                this._maxWeight = value;
            }
        }

        public List<SectionCurve> SecTankDraftVArea
        {
            get
            {
                return this._sectankDraftVarea;
            }
        }

        public string TankName { get; set; }

        public string TankCode { get; set; }

        public double Permiability
        {
            get { return this._permiability; }
            set { this._permiability = value; }
        }

        public double Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        public string WeightForView
        {
            get { return (this._weight / 1000).ToString("0.00"); }
            set { this._weight = double.Parse(value); }
        }

        public string VolumeForView
        {
            get { return this._volume.ToString("0.00"); }
            set { this._volume = double.Parse(value); }
        }

        public double Volume
        {
            get { return this._volume; }
            set { this._volume = value; }
        }

        public double VolumePercentage
        {
            get { return this._volumePercentage; }
            set { this._volumePercentage = value; }
        }

        public string VolumePercentageForView
        {
            get { return this._volumePercentage.ToString("0.00"); }
            set { this._volumePercentage = double.Parse(value); }
        }

        public double LCG
        {
            get { return this._lcg; }
            set { this._lcg = value; }
        }

        public string LCGForView
        {
            get { return this._lcg.ToString("0.000"); }
            set { this._lcg = double.Parse(value); }
        }

        public double VCG
        {
            get { return this._vcg; }
            set { this._vcg = value; }
        }

        public string VCGForView
        {
            get { return this._vcg.ToString("0.000"); }
            set { this._vcg = double.Parse(value); }
        }

        public double TCG
        {
            get { return this._tcg; }
            set { this._tcg = value; }
        }

        public string TCGForView
        {
            get { return this._tcg.ToString("0.000"); }
            set { this._tcg = double.Parse(value); }
        }

        public double FSM
        {
            get { return this._fsm; }
            set { this._fsm = value; }
        }

        public string FSMForView
        {
            get { return this._fsm.ToString("0.000"); }
            set { this._fsm = double.Parse(value); }
        }
        #endregion properties


        #region public method
        public void AddCurvedata(SectionCurve curve)
        {

            this._tankCurvedata.Add(curve);
        }


        public void AddVolData(Point2D pt)
        {

            this._voldata.Add(pt);
        }
        public void AddMassData(Point2D pt)
        {

            this._massdata.Add(pt);
        }
        public void AddPerOfFillData(Point2D pt)
        {

            this._percentageOffilling.Add(pt);
        }

        public void AddTankLcg(Point2D pt)
        {

            this._tankLcg.Add(pt);
        }
        public void AddTankVcg(Point2D pt)
        {

            this._tankVcg.Add(pt);
        }
        public void AddTankTcg(Point2D pt)
        {

            this._tankTcg.Add(pt);
        }
        public void AddFsmt(Point2D pt)
        {

            this._fsmt.Add(pt);
        }
        public void AddFsml(Point2D pt)
        {

            this._fsml.Add(pt);
        }

        #region Tank Related

        #endregion Tank Related

        public void GetSecTankAreaSounding(Tank tank)
        {
            List<SectionCurve> curveList = tank._tankCurvedata;
            Vector2D vHelper = new Vector2D();
            Point2D maxmin = this.getMaxmin(tank);

            List<SectionCurve> modifiedCurve = new List<SectionCurve>();

            foreach (SectionCurve curve in curveList)
            {
                double z0 = maxmin.X;
                double zm = maxmin.Y;
                double dz = 0.1;
                double z = z0 + dz;
                SectionCurve modCurve = new SectionCurve();
                modCurve.Xloc = curve.Xloc;
                while (z < zm + dz)
                {
                    double area = vHelper.GetTankAreaforFixZ(curve, z);
                    modCurve.Addpoints(new Point2D(z, area));
                    z = z + dz;
                }

                modifiedCurve.Add(modCurve);
            }


            this._sectankDraftVarea.RemoveRange(0, _sectankDraftVarea.Count);
            this._sectankDraftVarea.AddRange(modifiedCurve);

        }

        public void GetTankSoundings(Tank tank)
        {
            //this._liquidrho = rho;
            if (this.getstring(tank.TankName) == "S")
            {
                this._tankCurvedata.Reverse();
                List<SectionCurve> curveList = tank.TankCurvedata;

                //curveList.Reverse();
                this.fillsoundingForStank(curveList, tank);

                //Point2D pt2D = vHelper.GetTankSecPropertyforFixZ(curveList, 8, ref ptList);
                //double vol = vHelper.GetMaxTankVolume(curveList, out cgPt);

            }
            else if (this.getstring(tank.TankName) == "P")
            {
                this.modifyTankdataForPtank(tank);
                List<SectionCurve> curveList = tank.TankCurvedata;

                // curveList.Reverse();
                this.fillsoundingForPtank(curveList, tank);

            }
            else
            {
                this.modifyTankDataforCtank(tank);
                List<SectionCurve> curveList = tank.TankCurvedata;

                // curveList.Reverse();
                this.fillsoundingForCtank(curveList, tank);

            }

        }

        public void GetTankFsm(Tank tank, ShipGeom ship)
        {
            PublicHelper pHelper = new PublicHelper();
            List<Point2D> ptList = tank.VolumeData;
            this._fsml.RemoveRange(0, Fsml.Count);
            this._fsmt.RemoveRange(0, Fsmt.Count);

            for (int i = 0; i < ptList.Count; i++)
            {
                double z = ptList[i].X;
                double bmt = pHelper.InterpolateData(z, ship.DraftBmt, 2);
                double bml = pHelper.InterpolateData(z, ship.DraftBml, 2);
                double disp = pHelper.InterpolateData(z, ship.DraftMass, 2);
                double fsmt = (bmt * ptList[i].Y * this._liquidrho) / disp;
                double fsml = (bml * ptList[i].Y * this._liquidrho) / disp;
                this.AddFsml(new Point2D(z, fsml));
                this.AddFsmt(new Point2D(z, fsmt));

            }
        }

        public void UpdateDensity(double rho)
        {
            this._liquidrho = rho;
        }

        public void UpdateMaxWt(double maxWt)
        {
            this._maxWeight = maxWt;
        }

        public List<Tank> GetDamageTankDetails(List<string> tankNameList, List<Tank> tankList)
        {
            List<Tank> dtankList = new List<Tank>();

            foreach (string str in tankNameList)
            {
                foreach (Tank tank in tankList)
                {
                    if (str == tank.TankName)
                    {
                        dtankList.Add(tank);
                        break;
                    }
                }

            }


            return dtankList;
        }



        #endregion public method

        #region private method

        private void fillsoundingForStank(List<SectionCurve> curveList, Tank tank)
        {
            Vector2D vHelper = new Vector2D();
            Point2D maxmin = this.getMaxmin(tank);
            double z0 = maxmin.X;
            double zm = maxmin.Y;
            double dz = 0.1;
            double z = z0 + dz;
            Point pmaxCg = new Point();
            double vol = this._permiability * vHelper.GetMaxTankVolume(curveList, out pmaxCg);


            while (z < zm)
            {
                List<Point2D> cgList = new List<Point2D>();

                Point2D pt2D = vHelper.GetTankSecPropertyforFixZ(curveList, z, ref cgList);
                pt2D.Y = pt2D.Y * this._permiability;
                double mass = pt2D.Y * this._liquidrho;
                double perfil = ((pt2D.Y) / vol) * 100;
                this._voldata.Add(pt2D);
                this._massdata.Add(new Point2D(pt2D.X, mass));
                this._percentageOffilling.Add(new Point2D(pt2D.X, perfil));
                this._tankLcg.Add(cgList[0]);
                this._tankTcg.Add(cgList[1]);
                this._tankVcg.Add(cgList[2]);
                this._fsml.Add(new Point2D(cgList[0].X, 0));
                this._fsmt.Add(new Point2D(cgList[0].X, 0));
                z = z + dz;
            }

            this._voldata.Add(new Point2D(zm, vol));
            this._massdata.Add(new Point2D(zm, vol * this._liquidrho));
            this._tankLcg.Add(new Point2D(zm, pmaxCg.X));
            this._tankTcg.Add(new Point2D(zm, pmaxCg.Y));
            this._tankVcg.Add(new Point2D(zm, pmaxCg.Z));
            this._fsml.Add(new Point2D(zm, 0));
            this._fsmt.Add(new Point2D(zm, 0));
            this._maxWeight = vol * this._liquidrho;
            this._fsml.Add(new Point2D(zm, 0));
            this._fsmt.Add(new Point2D(zm, 0));



        }

        private void fillsoundingForPtank(List<SectionCurve> curveList, Tank tank)
        {
            Vector2D vHelper = new Vector2D();
            Point2D maxmin = this.getMaxmin(tank);
            double z0 = maxmin.X;
            double zm = maxmin.Y;
            double dz = 0.1;
            double z = z0 + dz;
            Point pmaxCg = new Point();
            double vol = this._permiability * vHelper.GetMaxTankVolume(curveList, out pmaxCg);
            pmaxCg.Y = -pmaxCg.Y;

            while (z < zm)
            {
                List<Point2D> cgList = new List<Point2D>();

                Point2D pt2D = vHelper.GetTankSecPropertyforFixZ(curveList, z, ref cgList);
                pt2D.Y = pt2D.Y * this._permiability;
                double mass = pt2D.Y * this._liquidrho;
                double perfil = ((pt2D.Y) / vol) * 100;
                this._voldata.Add(pt2D);
                this._massdata.Add(new Point2D(pt2D.X, mass));
                this._percentageOffilling.Add(new Point2D(pt2D.X, perfil));
                this._tankLcg.Add(cgList[0]);
                this._tankTcg.Add(new Point2D(cgList[1].X, -cgList[1].Y));
                this._tankVcg.Add(cgList[2]);
                this._fsml.Add(new Point2D(cgList[0].X, 0));
                this._fsmt.Add(new Point2D(cgList[0].X, 0));
                z = z + dz;
            }

            this._voldata.Add(new Point2D(zm, vol));
            this._massdata.Add(new Point2D(zm, vol * this._liquidrho));
            this._tankLcg.Add(new Point2D(zm, pmaxCg.X));
            this._tankTcg.Add(new Point2D(zm, pmaxCg.Y));
            this._tankVcg.Add(new Point2D(zm, pmaxCg.Z));
            this._maxWeight = vol * this._liquidrho;
            this._fsml.Add(new Point2D(zm, 0));
            this._fsmt.Add(new Point2D(zm, 0));



        }

        private void fillsoundingForCtank(List<SectionCurve> curveList, Tank tank)
        {

            Vector2D vHelper = new Vector2D();
            Point2D maxmin = this.getMaxmin(tank);
            List<LiquidWeightModel> liqModel = new List<LiquidWeightModel>();
            double z0 = maxmin.X;
            double zm = maxmin.Y;
            double dz = 0.1;
            double z = z0 + dz;
            Point pmaxCg = new Point();
            double vol = this._permiability * vHelper.GetMaxTankVolume(curveList, out pmaxCg);
            while (z < zm)
            {
                List<Point2D> cgList = new List<Point2D>();

                Point2D pt2D = vHelper.GetTankSecPropertyforFixZ(curveList, z, ref cgList);
                pt2D.Y = pt2D.Y * this._permiability;
                double mass = pt2D.Y * this._liquidrho;
                double perfil = ((pt2D.Y) / vol) * 100;
                this._voldata.Add(pt2D);
                this._massdata.Add(new Point2D(pt2D.X, mass));
                this._percentageOffilling.Add(new Point2D(pt2D.X, perfil));
                this._tankLcg.Add(cgList[0]);
                this._tankTcg.Add(new Point2D(cgList[1].X, 0));
                this._tankVcg.Add(cgList[2]);
                this._fsml.Add(new Point2D(cgList[0].X, 0));
                this._fsmt.Add(new Point2D(cgList[0].X, 0));
                z = z + dz;
            }

            this._voldata.Add(new Point2D(zm, vol));
            this._massdata.Add(new Point2D(zm, vol * this._liquidrho));
            this._tankLcg.Add(new Point2D(zm, pmaxCg.X));
            this._tankTcg.Add(new Point2D(zm, 0));
            this._tankVcg.Add(new Point2D(zm, pmaxCg.Z));
            this._maxWeight = vol * this._liquidrho;
            this._fsml.Add(new Point2D(zm, 0));
            this._fsmt.Add(new Point2D(zm, 0));




        }

        private void modifyTankDataforCtank(Tank tank)
        {
            List<SectionCurve> curveList = new List<SectionCurve>();
            foreach (SectionCurve curve in tank.TankCurvedata)
            {
                SectionCurve secCurve = new SectionCurve();
                secCurve.Xloc = curve.Xloc;
                foreach (Point2D pt2D in curve.SectionPts)
                {
                    secCurve.Addpoints(new Point2D(pt2D.X, pt2D.Y));
                }

                int m = curve.SectionPts.Count - 1;

                while (m > 1)
                {
                    Point2D pt = new Point2D();
                    pt.X = -curve.SectionPts[m - 1].X;
                    pt.Y = curve.SectionPts[m - 1].Y;
                    secCurve.Addpoints(pt);
                    m = m - 1;
                }

                curveList.Add(secCurve);
            }
            this._tankCurvedata.RemoveRange(0, TankCurvedata.Count);
            this._tankCurvedata.AddRange(curveList);
            this._tankCurvedata.Reverse();


        }

        private void modifyTankdataForPtank(Tank tank)
        {
            List<SectionCurve> curveList = new List<SectionCurve>();
            foreach (SectionCurve curve in TankCurvedata)
            {
                SectionCurve modyfycurve = new SectionCurve();
                modyfycurve.Xloc = curve.Xloc;
                foreach (Point2D pt2D in curve.SectionPts)
                {
                    modyfycurve.Addpoints(new Point2D(-pt2D.X, pt2D.Y));
                }
                //this._tankCurvedata.Remove(curve);
                curveList.Add(modyfycurve);
            }

            this._tankCurvedata.RemoveRange(0, TankCurvedata.Count);
            this._tankCurvedata.AddRange(curveList);
            this._tankCurvedata.Reverse();

        }

        private string getstring(string s)
        {
            string[] st = s.Split('.');

            string str = st[st.Length - 1];

            return str;
        }

        private Point2D getMaxmin(Tank tank)
        {
            Point2D pt = new Point2D();
            List<double> zList = new List<double>();
            foreach (SectionCurve curve in tank.TankCurvedata)
            {
                foreach (Point2D pt2D in curve.SectionPts)
                {
                    zList.Add(pt2D.Y);
                }
            }

            pt = this.maximumMinimumElementArray(zList);
            return pt;
        }

        private Point2D maximumMinimumElementArray(List<double> ptList)
        {

            double[] array = ptList.ToArray();
            //int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
            double max = array[0];
            double min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Point2D pt = new Point2D(min, max);

            return pt;

        }


        #endregion private method


    }
}
