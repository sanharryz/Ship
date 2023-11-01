using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesselLoader.Models;

namespace VesselLoader.Helper
{
    class Vector2D
    {
        #region member variable
        Point2D _stPt;
        Point2D _endPt;
        #endregion member variable

        #region constructor
        public Vector2D()
        {
            this._stPt = new Point2D();
            this._endPt = new Point2D();
        }

        public Vector2D(Point2D stPt, Point2D endPt)
        {
            this._stPt = stPt;
            this._endPt = endPt;
        }
        #endregion constructor

        #region Properties

        public Point2D StPt
        {
            get
            {
                return this._stPt;
            }

            set
            {
                this._stPt = value;
            }
        }

        public Point2D EndPt
        {
            get
            {
                return this._endPt;
            }

            set
            {
                this._endPt = value;
            }
        }


        #endregion Properties

        #region Public Methods

        public double GetTankAreaforFixZ(SectionCurve secCurve, double z)
        {
            PublicHelper helper = new PublicHelper();

            double xloc = secCurve.Xloc;
            List<Point2D> ptList = secCurve.SectionPts;
            List<Vector2D> vList = this.GetVectorfromPointList(ptList);
            Point2D trimmingPt = new Point2D(ptList[0].X, z);
            List<Point2D> trimPtList = this.getPolygon(vList, trimmingPt);
            double area = helper.GetAreaofPolygon(trimPtList);


            return area;
        }




        public List<Vector2D> GetVectorfromPointList(List<Point2D> ptList)
        {
            List<Vector2D> vectorList = new List<Vector2D>();

            for (int i = 0; i < ptList.Count - 1; i++)
            {
                Vector2D vector = new Vector2D(ptList[i], ptList[i + 1]);
                vectorList.Add(vector);
            }

            return vectorList;
        }

        public Point2D GetPoint(Vector2D v, double param)
        {

            double x = param * v.EndPt.X + (1 - param) * v.StPt.X;
            double y = param * v.EndPt.X + (1 - param) * v.StPt.X;
            Point2D pt = new Point2D(x, y);

            return pt;
        }

        public double GetMaxTankVolume(List<SectionCurve> curveList, out Models.Point cGLoc)
        {
            cGLoc = new Models.Point();
            PublicHelper helper = new PublicHelper();

            List<Point2D> areaList = new List<Point2D>();
            List<Point2D> ymomentList = new List<Point2D>();
            List<Point2D> zmomentList = new List<Point2D>();
            List<Point2D> xmomentList = new List<Point2D>();
            foreach (SectionCurve curve in curveList)
            {

                double xloc = curve.Xloc;
                double area = helper.GetAreaofPolygon(curve.SectionPts);
                Point2D cgPt = helper.GetCentriodofPolygon(area, curve.SectionPts);
                areaList.Add(new Point2D(xloc, area));
                //xmomentList.Add(new Point2D(xloc, area));
                //ymomentList.Add(new Point2D(cgPt.X, area ));
                //zmomentList.Add(new Point2D(cgPt.Y, area ));

                xmomentList.Add(new Point2D(xloc, area * xloc));
                ymomentList.Add(new Point2D(xloc, area * cgPt.X));
                zmomentList.Add(new Point2D(xloc, area * cgPt.Y));

            }

            double vol = helper.GetSecAreaTrapz(areaList);
            double tmom = helper.GetSecAreaTrapz(ymomentList);
            double zmom = helper.GetSecAreaTrapz(zmomentList);
            double xmom = helper.GetSecAreaTrapz(xmomentList);


            double xcg = xmom / vol;
            double ycg = tmom / vol;
            double zcg = zmom / vol;


            //double xcg = this.getCentroid(xmomentList);
            //double ycg = this.getCentroid(ymomentList);
            //double zcg = this.getCentroid(zmomentList);


            cGLoc.X = xcg;
            cGLoc.Y = ycg;
            cGLoc.Z = zcg;

            return vol;
        }



        public Point2D GetTankSecPropertyforFixZ(List<SectionCurve> curveList, double z, ref List<Point2D> cg)
        {
            PublicHelper helper = new PublicHelper();
            cg = new List<Point2D>();
            Point2D pt = new Point2D();

            List<Point2D> areaList = new List<Point2D>();
            List<Point2D> ymomentList = new List<Point2D>();
            List<Point2D> zmomentList = new List<Point2D>();
            List<Point2D> xmomentList = new List<Point2D>();
            int k = 0;
            foreach (SectionCurve curve in curveList)
            {

                Models.Point cgPt = new Models.Point();
                double xloc = curve.Xloc;
                double area = this.getsecAreaFixZ(curve, z, out cgPt);
                areaList.Add(new Point2D(xloc, area));
                xmomentList.Add(new Point2D(xloc, area));
                ymomentList.Add(new Point2D(cgPt.Y, area));
                zmomentList.Add(new Point2D(cgPt.Z, area));
                k++;
            }

            double vol = helper.GetSecAreaTrapz(areaList);
            //double vol = helper.GetSecArea(areaList);

            //double tmom = helper.GetSecAreaTrapz(ymomentList);
            //double zmom = helper.GetSecAreaTrapz(zmomentList);
            //double xmom = helper.GetSecAreaTrapz(xmomentList);


            //double xcg = xmom / vol
            //double ycg = tmom / vol;
            //double zcg = zmom / vol;


            double xcg = this.getCentroid(xmomentList);
            double ycg = this.getCentroid(ymomentList);
            double zcg = this.getCentroid(zmomentList);


            pt.X = z;
            pt.Y = vol;

            cg.Add(new Point2D(z, xcg));
            cg.Add(new Point2D(z, ycg));
            cg.Add(new Point2D(z, zcg));


            return pt;

        }



        #endregion Public Method

        #region private method


        private double getCentroid(List<Point2D> ptList)
        {
            double sum = 0;
            double sum1 = 0;
            for (int i = 0; i < ptList.Count; i++)
            {
                sum = sum + ptList[i].X * ptList[i].Y;
                sum1 = sum1 + ptList[i].Y;
            }



            return sum / sum1;
        }


        private double getsecAreaFixZ(SectionCurve secCurve, double z, out Models.Point cg)
        {
            PublicHelper helper = new PublicHelper();
            cg = new Models.Point();
            double xloc = secCurve.Xloc;
            List<Point2D> ptList = secCurve.SectionPts;
            List<Vector2D> vList = this.GetVectorfromPointList(ptList);
            Point2D trimmingPt = new Point2D(ptList[0].X, z);
            List<Point2D> trimPtList = this.getPolygon(vList, trimmingPt);
            double area = helper.GetAreaofPolygon(trimPtList);
            if (Math.Abs(area) < 0.0001)
            {
                cg.X = xloc;
                cg.Y = 0;
                cg.Z = 0;

                return 0;
            }

            Point2D pt = helper.GetCentriodofPolygon(area, trimPtList);
            cg.X = xloc;
            cg.Y = Math.Abs(pt.X);
            cg.Z = Math.Abs(pt.Y);

            // write part of the code for fsmt
            //-----------------------------------



            return area;
        }

        private double getTankYvalueforIxx(List<Point2D> pointList)
        {
            return 0;
        }

        private List<Point2D> getPolygon(List<Vector2D> vList, Point2D trimingPt)
        {
            List<Point2D> ptList = new List<Point2D>();
            PublicHelper helper = new PublicHelper();


            for (int i = 0; i < vList.Count; i++)
            {
                if (this.checkvalue(vList[i], trimingPt) == 0)
                {
                    ptList.Add(vList[i].StPt);
                    ptList.Add(vList[i].EndPt);
                }
                else if (this.checkvalue(vList[i], trimingPt) == 2)
                {
                    double d = helper.InverseSolveLinearEquation(vList[i].StPt, vList[i]._endPt, trimingPt.Y);
                    Point2D pt = new Point2D(d, trimingPt.Y);
                    if (this.checkOrientation(vList[i], trimingPt.Y))
                    {
                        ptList.Add(vList[i].StPt);
                        ptList.Add(pt);

                    }
                    else
                    {
                        ptList.Add(pt);
                        ptList.Add(vList[i].EndPt);
                    }



                }

            }







            return ptList;

        }

        private int checkvalue(Vector2D v, Point2D pt)
        {

            double d1 = pt.Y - v.StPt.Y;
            double d2 = pt.Y - v.EndPt.Y;

            if ((d1 > 0) && (d2 > 0))
            {
                return 0;
            }
            else if ((d1 < 0) && (d2 < 0))
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        private bool checkOrientation(Vector2D v, double z)
        {

            double d1 = z - v.StPt.Y;
            double d2 = z - v.EndPt.Y;

            if (d1 > 0)
            { return true; }
            else
            { return false; }

        }



        #endregion private method






    }
}
