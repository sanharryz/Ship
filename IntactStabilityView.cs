using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesselLoader.Models;
using VesselLoader.Helper;
using System.DirectoryServices;

namespace VesselLoader
{
    public partial class IntactStabilityView : UserControl
    {

        private CrossCurve _crossCurve;
        private List<Section> _sectionList;
        private ShipGeom _shipGeom;
        private SolidFixedWeightModeList _solidFixedWeightModeList;
        private VesselInfo _vesselInfo;
        private double TrimAngle = 0;
        public IntactStabilityView()
        {
            InitializeComponent();
        }

        private void IntactStabilityView_Load(object sender, EventArgs e)
        {
            try
            {
                _crossCurve = new DataAdapter().getCrossCurveData();
                _sectionList = new DataAdapter().getSectionListData();
                _shipGeom = new DataAdapter().getShipGeometryData();
                _solidFixedWeightModeList = new DataAdapter().getFixedWeightData();
                _vesselInfo = new DataAdapter().getVesselInfo();


                List<Models.FixedWeightModel> FixedWeightModels = new List<FixedWeightModel>();
                if (_solidFixedWeightModeList != null && _solidFixedWeightModeList.FixedWeights != null &&
                    _solidFixedWeightModeList.FixedWeights.Count > 0)
                {
                    foreach (var solidWeight in _solidFixedWeightModeList.FixedWeights)
                    {
                        FixedWeightModel fixedWeightModel = new FixedWeightModel();
                        fixedWeightModel.ObjectName = solidWeight.Name;
                        fixedWeightModel.CG = new Models.Point(double.Parse(solidWeight.LCG), double.Parse(solidWeight.VCG), double.Parse(solidWeight.TCG));
                        fixedWeightModel.Weight = double.Parse(solidWeight.Weight);
                        FixedWeightModels.Add(fixedWeightModel);
                    }
                }

                List<LiquidWeightModel> liqModelList = new List<LiquidWeightModel>();

                foreach (var tempTank in SessionData.TankList)
                {
                    LiquidWeightModel tankmodel = new LiquidWeightModel();

                    tankmodel.Tankname = tempTank.TankName;
                    tankmodel.Weight = tempTank.MaxWeight / tempTank.LiquidRho;
                    Models.Point pt = new Models.Point(tempTank.TankLcg[tempTank.TankLcg.Count - 1].Y, tempTank.TankTcg[tempTank.TankTcg.Count - 1].Y, tempTank.TankVcg[tempTank.TankVcg.Count - 1].Y);
                    tankmodel.CG = pt;

                    liqModelList.Add(tankmodel);
                }




                var summaryInfoList = new Summary().GetEquilibriumConditionDetails(_shipGeom, _crossCurve, FixedWeightModels, 
                    liqModelList, _sectionList, SessionData.TankList, double.Parse(_vesselInfo.WaterDensity));

                if (summaryInfoList != null && summaryInfoList.Count > 0)
                {
                    //if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Trim")) > 0)
                    trim_lbl.Text = summaryInfoList[0].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Heel")) > 0)
                        heel_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("Heel"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Displacement")) > 0)
                        displacement_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("Displacement"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("LCG")) > 0)
                        lcg_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("LCG"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("TCG")) > 0)
                        tcg_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("TCG"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("VCG")) > 0)
                        vcg_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("VCG"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft AFT")) > 0)
                        draft_aft_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft AFT"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft MS")) > 0)
                        draft_ms_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft MS"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft FWD")) > 0)
                        draft_fwd_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("Draft FWD"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("GM(Fluid)")) > 0)
                        gm_fluid_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("GM(Fluid)"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("GM(Solid)")) > 0)
                        gm_solid_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("GM(Solid)"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("FS Correction")) > 0)
                        fs_correction_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("FS Correction"))].ObjectValue.ToString();

                    if (summaryInfoList.FindIndex(x => x.ObjectName.Equals("VCG Correction")) > 0)
                        vcg_correction_lbl.Text = summaryInfoList[summaryInfoList.FindIndex(x => x.ObjectName.Equals("VCG Correction"))].ObjectValue.ToString();
                }

                List<Models.Object> objlst = new List<Models.Object>();
                objlst.AddRange(FixedWeightModels);
                objlst.AddRange(liqModelList);
                Models.Object hulldetails = new PublicHelper().GetCentroid(objlst);
                //hardcoded
                Models.Point trimPoint = new OutputParamHelper().GetTrimValue(_shipGeom, _sectionList, hulldetails.Weight, hulldetails.CG.X, double.Parse(_vesselInfo.WaterDensity));
                TrimAngle = (180 / Math.PI) * Math.Atan((trimPoint.Y - trimPoint.X) / _shipGeom.LBP);

                var responseIntactCriteriaResponse = new Summary().GetIntactCriteriaValue(FixedWeightModels, liqModelList, _crossCurve, _shipGeom, double.Parse(_vesselInfo.WaterDensity));
                IntactCriteriaModelList intactCriteriaModelList = new IntactCriteriaModelList();
                if (responseIntactCriteriaResponse != null && responseIntactCriteriaResponse.Count > 0)
                {

                    foreach (var response in responseIntactCriteriaResponse)
                    {
                        IntactCriteriaModel intactCriteriaModel = new IntactCriteriaModel();
                        intactCriteriaModel.Limit = response.ObjectName;
                        intactCriteriaModel.MinMaxValue = "> 0.05550 m-R";
                        intactCriteriaModel.Actual = response.ObjectValue.ToString("0.00");
                        intactCriteriaModel.Margin = (response.ObjectValue - 0.05550).ToString("0.00");
                        intactCriteriaModel.Pass = (response.ObjectValue - 0.05550) > 0 ? "Yes" : "No";
                        if (intactCriteriaModelList.IntactCriteriaModels == null)
                            intactCriteriaModelList.IntactCriteriaModels = new List<IntactCriteriaModel> { intactCriteriaModel };
                        else
                            intactCriteriaModelList.IntactCriteriaModels.Add(intactCriteriaModel);
                    }
                }

                dataGridView1.AutoGenerateColumns = false;
                var source = new BindingSource(intactCriteriaModelList.IntactCriteriaModels, null);
                dataGridView1.DataSource = source;
                dataGridView1.Update();

                foreach (Control c in UserViewPanel.Controls)
                {
                    if (c is UserControl && c.Visible && !c.Name.Equals("intactTrimView"))
                    {
                        c.Visible = false;
                    }
                }
                IntactTrimView intactTrimView = new IntactTrimView((float)TrimAngle);
                intactTrimView.Name = "intactTrimView";
                intactTrimView.Dock = DockStyle.Fill;
                intactTrimView.Visible = true;
                this.UserViewPanel.Controls.Add(intactTrimView);

            }
            catch (Exception ex) { MessageBox.Show(this, "Error in initializing"); }
        }

        private void all_btn_Click(object sender, EventArgs e)
        {

        }

        private void trim_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in UserViewPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("intactTrimView"))
                {
                    c.Visible = false;
                }
            }
            IntactTrimView intactTrimView = new IntactTrimView((float)TrimAngle);
            intactTrimView.Name = "intactTrimView";
            intactTrimView.Dock = DockStyle.Fill;
            intactTrimView.Visible = true;
            this.UserViewPanel.Controls.Add(intactTrimView);
        }

        private void heel_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in UserViewPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("intactHeelView"))
                {
                    c.Dispose();
                }
            }
            IntactHeelView intactHeelView = new IntactHeelView((float)TrimAngle);
            intactHeelView.Name = "intactHeelView";
            intactHeelView.Dock = DockStyle.Fill;
            intactHeelView.Dock = DockStyle.Fill;
            intactHeelView.Visible = true;
            this.UserViewPanel.Controls.Add(intactHeelView);
        }
    }
}
