using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VesselLoader.Helper;
using VesselLoader.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VesselLoader
{
    public partial class DamageStabilityView : UserControl
    {
        private ShipGeom _shipGeom;
        private SolidFixedWeightModeList _solidFixedWeightModeList;
        private List<Section> _sectionList;
        private CrossCurve _crossCurve;
        private VesselInfo _info;
        private List<DamageCaseMasterModel> _damageCaseMasterModels;

        public DamageStabilityView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DamageStabilityView_Load(object sender, EventArgs e)
        {
            try

            {
                _shipGeom = new Helper.DataAdapter().getShipGeometryData();
                _solidFixedWeightModeList = new Helper.DataAdapter().getFixedWeightData();
                _sectionList = new DataAdapter().getSectionListData();
                _crossCurve = new DataAdapter().getCrossCurveData();
                _info = new DataAdapter().getVesselInfo();
                _damageCaseMasterModels = new DataAdapter().getDamageCaseData();

                damage_case_list_view.View = View.Details;
                damage_case_list_view.FullRowSelect = true;
                damage_case_list_view.Columns.Add("Damage Cases", 650, HorizontalAlignment.Center);

                if (_damageCaseMasterModels != null && _damageCaseMasterModels.Count > 0)
                {
                    foreach (var damageCase in _damageCaseMasterModels)
                    {
                        ListViewItem listViewItem = new ListViewItem(damageCase.DamageCaseName);
                        damage_case_list_view.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(this, "error in initializing"); }




        }

        private void damage_case_list_view_Click(object sender, EventArgs e)
        {

        }

        private void damage_case_list_view_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item != null)
            {
                var selectedItem = e.Item;
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

                Dictionary<string, List<string>> damageTankName = new Dictionary<string, List<string>>();
                damageTankName.Add(selectedItem.Text, _damageCaseMasterModels.Where(x => x.DamageCaseName.Equals(selectedItem.Text)).FirstOrDefault()
                    .TankNames);

                Dictionary<string, List<Summary>> damageCriteria = new Dictionary<string, List<Summary>>();

                var result = new Helper.Summary().GetDamagedHydrostaticFull(_shipGeom, FixedWeightModels, liqModelList, _sectionList, damageTankName,
                    _crossCurve, double.Parse(_info.WaterDensity), ref damageCriteria, SessionData.TankList);


                detailed_report_list_view.FullRowSelect = true;
                detailed_report_list_view.Items.Clear();

                if (result != null && result.Count > 0)
                {
                    foreach (var report in result[selectedItem.Text])
                    {
                        if (report != null)
                        {
                            string[] row = { report.ObjectName, report.ObjectValue.ToString("0.00") };
                            ListViewItem listViewItem = new ListViewItem(row);
                            detailed_report_list_view.Items.Add(listViewItem);
                        }
                    }
                }

                damage_criteria_list_view.FullRowSelect = true;
                damage_criteria_list_view.Items.Clear ();
                if (damageCriteria != null && damageCriteria.Count > 0)
                {
                    foreach (var report in damageCriteria[selectedItem.Text])
                    {
                        if (report != null)
                        {
                            switch (report.ObjectName)
                            {
                                case "Freeboard Height at EQU":
                                    string[] row = { report.ObjectName,
                                                    "> 0.000 m",
                                                    report.ObjectValue.ToString("0.000"),
                                                    (report.ObjectValue - 0.0175).ToString("0.000"),
                                                    (report.ObjectValue - 0.0175) >= 0 ? "Pass" : "Faill"};
                                    ListViewItem listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;

                                case "Angle at EQU":

                                    row = new string[] { report.ObjectName,
                                                    "< 30.000 deg",
                                                    report.ObjectValue.ToString("0.000"),
                                                    (30.000 - report.ObjectValue).ToString("0.000"),
                                                    (30.000 - report.ObjectValue) >= 0 ? "Pass" : "Faill"};
                                    listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;

                                case "Angle from EQU to RA0 or FLD":

                                    row = new string[] { report.ObjectName,
                                                    "> 20.000 deg",
                                                    report.ObjectValue.ToString("0.000"),
                                                    ( report.ObjectValue - 20.000).ToString("0.000"),
                                                    (report.ObjectValue - 20.000) >= 0 ? "Pass" : "Faill"};
                                    listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;

                                case "Area from EQU to 20 deg":

                                    row = new string[] { report.ObjectName,
                                                    "> 0.0175 m-R",
                                                    report.ObjectValue.ToString("0.000"),
                                                    ( report.ObjectValue - 0.0175).ToString("0.000"),
                                                    (report.ObjectValue - 0.0175) >= 0 ? "Pass" : "Faill"};
                                    listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;

                                case "Flood Point Height at EQU":

                                    row = new string[] { report.ObjectName,
                                                    "> 0.000 m",
                                                    report.ObjectValue.ToString("0.000"),
                                                    ( report.ObjectValue - 0.000).ToString("0.000"),
                                                    (report.ObjectValue - 0.000) >= 0 ? "Pass" : "Faill"};
                                    listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;

                                case "Maximum GZ from EQU to 20 deg":

                                    row = new string[] { report.ObjectName,
                                                    "> 0.100 m",
                                                    report.ObjectValue.ToString("0.000"),
                                                    ( report.ObjectValue - 0.100).ToString("0.000"),
                                                    (report.ObjectValue - 0.100) >= 0 ? "Pass" : "Faill"};
                                    listViewItem = new ListViewItem(row);
                                    damage_criteria_list_view.Items.Add(listViewItem);
                                    break;
                            }
                        }
                    }
                }

            }
        }

        private void detailed_report_list_view_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
            e.DrawText();
        }

        private void detailed_report_list_view_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void damage_criteria_list_view_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
            e.DrawText();
        }

        private void damage_criteria_list_view_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
