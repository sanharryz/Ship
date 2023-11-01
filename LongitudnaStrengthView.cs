using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VesselLoader.Helper;
using VesselLoader.Models;

namespace VesselLoader
{
    public partial class LongitudnaStrengthView : UserControl
    {
        private ShipGeom _shipGeom;
        private SolidFixedWeightModeList _solidFixedWeightModeList;
        private List<Tank> _tankList;
        private List<Section> _sections;
        private VesselInfo _info;
        List<BendingShearValueModel> _allowedBendingList;
        List<BendingShearValueModel> _allowedShearList;


        public LongitudnaStrengthView()
        {
            InitializeComponent();
            _shipGeom = new Helper.DataAdapter().getShipGeometryData();
            _solidFixedWeightModeList = new Helper.DataAdapter().getFixedWeightData();
            _tankList = new DataAdapter().getTankData();
            _sections = new DataAdapter().getSectionListData();
            _info = new DataAdapter().getVesselInfo();
            _allowedShearList = new DataAdapter().getShearData();
            _allowedBendingList = new DataAdapter().getBendingData();
        }

        private void LongitudnaStrengthView_Load(object sender, EventArgs e)
        {
            List<Mapping> mappings = new List<Mapping>();
            foreach (var tank in SessionData.TankList)
            {
                if (tank.VolumePercentage > 0)
                {
                    Mapping mapping = new Mapping();
                    mapping.IndexValue = 4;
                    mapping.TankName = tank.TankName;
                    mapping.Xvalues = tank.VolumePercentage;
                    mappings.Add(mapping);
                }
            }

            List<Models.FixedWeightModel> FixedWeightModels = new List<FixedWeightModel>();
            foreach (var solidWeight in _solidFixedWeightModeList.FixedWeights)
            {
                FixedWeightModel fixedWeightModel = new FixedWeightModel();
                fixedWeightModel.ObjectName = solidWeight.Name;
                fixedWeightModel.CG = new Models.Point(double.Parse(solidWeight.LCG), double.Parse(solidWeight.VCG), double.Parse(solidWeight.TCG));
                fixedWeightModel.Weight = double.Parse(solidWeight.Weight);
                FixedWeightModels.Add(fixedWeightModel);
            }

            List<Point2D> shearforce = new List<Point2D>();
            List<Point2D> bendingMoment = new List<Point2D>();

            var summaryList = new Helper.Summary().GetLongitudinalStrengthSummaryInfo(_shipGeom, FixedWeightModels, _tankList, mappings, _sections, double.Parse(_info.WaterDensity), ref shearforce, ref bendingMoment);


            min_shear_val_lbl.Text = summaryList[0].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Min shear Loacation")) > 0)
                min_shear_location_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Min shear Loacation"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Max shear")) > 0)
                max_shear_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Max shear"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Max shear Location")) > 0)
                max_shear_location_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Max shear Location"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Min Bending Moment")) > 0)
                min_bending_moment_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Min Bending Moment"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Min Bending Moment Location")) > 0)
                min_bending_moment_location_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Min Bending Moment Location"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Max Bending Moment")) > 0)
                max_bending_moment_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Max Bending Moment"))].ObjectValue.ToString("0.00");

            if (summaryList.FindIndex(x => x.ObjectName.Equals("Max Bending Moment Location")) > 0)
                max_bending_moment_location_val_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Max Bending Moment Location"))].ObjectValue.ToString("0.00");


            #region Graph

            var objChart = chart1.ChartAreas[0];

            objChart.AxisX.Title = "Distance from Aft Perpendicular (m)";
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = -20;
            objChart.AxisX.IntervalOffset = 20;
            objChart.AxisX.IsStartedFromZero = false;
            

            objChart.AxisY.Title = "Shear Force (T)";
            objChart.AxisY.IsStartedFromZero = false;

            objChart.AxisY2.Title = "Bending moment (T-m)";
            objChart.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            objChart.AxisY2.MajorGrid.Enabled = false;
            objChart.AxisY2.IsStartedFromZero = false;


            #region Shear Force
            chart1.ChartAreas[0] = objChart;
            chart1.Series.Add("Shear Data");
            chart1.Series["Shear Data"].LegendText = "Shear Force";
            chart1.Series["Shear Data"].ChartArea = "ChartArea1";
            chart1.Series["Shear Data"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Shear Data"].YAxisType = AxisType.Primary;
            chart1.Series["Shear Data"].MarkerSize = 10;
            chart1.Series["Shear Data"].BorderWidth = 2;
            foreach (var points in shearforce)
            {
                chart1.Series["Shear Data"].Points.AddXY(points.X, points.Y);
            }
            #endregion

            #region Allowed Shear Force Positive
            chart1.ChartAreas[0] = objChart;
            chart1.Series.Add("Allowable Shear Force Positive");
            chart1.Series["Allowable Shear Force Positive"].LegendText = "Allowable Shear Force Positive";
            chart1.Series["Allowable Shear Force Positive"].ChartArea = "ChartArea1";
            chart1.Series["Allowable Shear Force Positive"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Allowable Shear Force Positive"].YAxisType = AxisType.Primary;
            chart1.Series["Allowable Shear Force Positive"].BorderWidth = 2;

            foreach (var points in _allowedShearList)
            {
                chart1.Series["Allowable Shear Force Positive"].Points.AddXY(points.XPositiveValue, points.YPositiveValue);
            }
            #endregion

            #region Allowed Shear Force Negative
            chart1.ChartAreas[0] = objChart;
            chart1.Series.Add("Allowable Shear Force Negative");
            chart1.Series["Allowable Shear Force Negative"].LegendText = "Allowable Shear Force Negative";
            chart1.Series["Allowable Shear Force Negative"].ChartArea = "ChartArea1";
            chart1.Series["Allowable Shear Force Negative"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Allowable Shear Force Negative"].YAxisType = AxisType.Primary;
            chart1.Series["Allowable Shear Force Negative"].BorderWidth = 2;
            foreach (var points in _allowedShearList)
            {
                chart1.Series["Allowable Shear Force Negative"].Points.AddXY(points.XPositiveValue, points.YNegativeValue);
            }
            #endregion

            #region Bending moment
            chart1.Series.Add("Bending Moment");
            chart1.Series["Bending Moment"].LegendText = "Bending Moment";
            chart1.Series["Bending Moment"].ChartArea = "ChartArea1";
            chart1.Series["Bending Moment"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Bending Moment"].YAxisType = AxisType.Secondary;
            chart1.Series["Bending Moment"].BorderWidth = 2;
            foreach (var points in bendingMoment)
            {
                chart1.Series["Bending Moment"].Points.AddXY(points.X, points.Y);
            }
            #endregion

            #region Allowed Bending Moment Hog
            chart1.Series.Add("Allowed Bending Moment Hog");
            chart1.Series["Allowed Bending Moment Hog"].LegendText = "Allowed Bending Moment Hog";
            chart1.Series["Allowed Bending Moment Hog"].ChartArea = "ChartArea1";
            chart1.Series["Allowed Bending Moment Hog"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Allowed Bending Moment Hog"].YAxisType = AxisType.Secondary;
            chart1.Series["Allowed Bending Moment Hog"].BorderWidth = 2;
            foreach (var points in _allowedBendingList)
            {
                chart1.Series["Allowed Bending Moment Hog"].Points.AddXY(points.XPositiveValue, points.YPositiveValue);
            }
            #endregion

            #region Allowed Bending Moment Sag
            chart1.Series.Add("Allowed Bending Moment Sag");
            chart1.Series["Allowed Bending Moment Sag"].LegendText = "Allowed Bending Moment Sag";
            chart1.Series["Allowed Bending Moment Sag"].ChartArea = "ChartArea1";
            chart1.Series["Allowed Bending Moment Sag"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Allowed Bending Moment Sag"].YAxisType = AxisType.Secondary;
            chart1.Series["Allowed Bending Moment Sag"].BorderWidth = 2;
            foreach (var points in _allowedBendingList)
            {
                chart1.Series["Allowed Bending Moment Sag"].Points.AddXY(points.XPositiveValue, points.YNegativeValue);
            }
            #endregion

            chart1.Visible = true;
            #endregion
        }
    }
}
