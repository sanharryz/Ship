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

namespace VesselLoader
{
    public partial class LoadingView : UserControl
    {
        private List<Tank> _tankList;
        private LiquidMasterData _liquidMasterData;
        private TankMappingModel _tankMappingModel;
        private SolidFixedWeightModeList _solidFixedWeightModeList;
        private VesselInfo _vesselInfo;

        public LoadingView()
        {
            InitializeComponent();

            try

            {
                _tankList = new DataAdapter().getTankData();
                _liquidMasterData = new DataAdapter().getMasterLiquidData();
                _tankMappingModel = new DataAdapter().getTankMappingData();
                _solidFixedWeightModeList = new DataAdapter().getFixedWeightData();
                _vesselInfo = new DataAdapter().getVesselInfo();
                if (_liquidMasterData != null)
                {
                    _liquidMasterData.Liquids.Insert(0, new Liquid()
                    {
                        Code = "All",
                        Name = "All"
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show(this, "Error in initializing"); }
        }

        private void LoadingView_Load(object sender, EventArgs e)
        {
            try
            {
                tank_list_view.AutoGenerateColumns = false;
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = _liquidMasterData.Liquids;

                liquid_master_list.DataSource = bindingSource1;
                liquid_master_list.DisplayMember = "Name";
                liquid_master_list.ValueMember = "Name";

                var source = new BindingSource(_tankList, null);
                tank_list_view.DataSource = source;


                tank_list_view.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error in initializing");
            }
        }

        private void tank_list_view_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = tank_list_view.Rows[e.RowIndex];
                var changedValue = row.Cells[e.ColumnIndex].Value.ToString();
                List<Mapping> loadmap = new List<Mapping>();
                Mapping map = new Mapping();
                map.TankName = (string)row.Cells["TankName"].Value != null ? (string)row.Cells["TankName"].Value.ToString() : "";
                map.IndexValue = e.ColumnIndex - 1;
                map.Xvalues = double.Parse(changedValue);
                loadmap.Add(map);
                var tank = _tankList.Where(x => x.TankName == map.TankName).FirstOrDefault();
                List<Mapping> result = new Summary().GetGridvalue(tank, double.Parse(_vesselInfo.WaterDensity), map);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.Weight = result.Where(x => x.IndexValue == 2).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.Volume = result.Where(x => x.IndexValue == 3).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.VolumePercentage = result.Where(x => x.IndexValue == 4).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.LCG = result.Where(x => x.IndexValue == 5).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.VCG = result.Where(x => x.IndexValue == 6).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.TCG = result.Where(x => x.IndexValue == 7).FirstOrDefault().Xvalues);
                _tankList.Where(w => w.TankName == (string)row.Cells["TankName"].Value.ToString()).ToList().ForEach(
                    s => s.FSM = result.Where(x => x.IndexValue == 8).FirstOrDefault().Xvalues);
                tank = _tankList.Where(x => x.TankName == map.TankName).FirstOrDefault();

                var _tankMappingList = _tankMappingModel.TankMappings.Where(x => x.LiquidName.Equals(liquid_master_list.SelectedValue.ToString())).ToList();
                var _searchResult = _tankList.Where(p => _tankMappingList.Any(p2 => p2.TankName == p.TankName)).ToList();
                if (_searchResult != null && _searchResult.Count > 0)
                {
                    tank_list_view.AutoGenerateColumns = false;
                    var source = new BindingSource(_searchResult, null);
                    tank_list_view.DataSource = source;
                    tank_list_view.Update();
                }
                else
                {
                    tank_list_view.AutoGenerateColumns = false;
                    var source = new BindingSource(_tankList, null);
                    tank_list_view.DataSource = source;
                    tank_list_view.Update();
                }

                List<LiquidWeightModel> liqModelList = new List<LiquidWeightModel>();

                foreach (var tempTank in _tankList)
                {
                    LiquidWeightModel tankmodel = new LiquidWeightModel();

                    tankmodel.Tankname = tempTank.TankName;
                    tankmodel.Weight = tempTank.MaxWeight / tempTank.LiquidRho;
                    Models.Point pt = new Models.Point(tempTank.TankLcg[tempTank.TankLcg.Count - 1].Y, tempTank.TankTcg[tempTank.TankTcg.Count - 1].Y, tempTank.TankVcg[tempTank.TankVcg.Count - 1].Y);
                    tankmodel.CG = pt;

                    liqModelList.Add(tankmodel);
                }

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

                Dictionary<string, List<LiquidWeightModel>> keyValues = new Dictionary<string, List<LiquidWeightModel>>();
                var liquidType = _tankMappingModel.TankMappings.Where(y => y.TankName.Equals(tank.TankName)).FirstOrDefault();
                keyValues.Add(liquidType.LiquidName, liqModelList);

                var summaryList = new Summary().GetLoadingSummary(keyValues, FixedWeightModels);


                if (summaryList != null && summaryList.Count > 0)
                {
                    //if (summaryList.FindIndex(x => x.ObjectName.Contains("lightship")) > 0)
                    lightship_lbl_txt.Text = summaryList[0].ObjectValue.ToString("0.00");

                    //if (summaryList.FindIndex(x => x.ObjectName.Equals("solidwt")) > 0)
                    //    s.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("solidwt"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName)) > 0)
                    {
                        switch (liquidType.LiquidName)
                        {
                            case "Water Ballast":
                                bwt_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;

                            case "Fresh Water":
                                fwt_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;

                            case "Disel Oil":
                                dot_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;

                            case "Miscelennious":
                                misc_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;

                            case "Liquid Cargo":
                                liquid_cargo_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;

                            case "Fuel Oil":
                                fot_total_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals(liquidType.LiquidName))].ObjectValue.ToString("0.00");
                                break;
                        }
                    }

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight")) > 0)
                        dead_weight_lbl.Text = (summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight"))].ObjectValue / 1000).ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight LCG")) > 0)
                        dead_weight_lcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight LCG"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight VCG")) > 0)
                        dead_weight_vcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight VCG"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight TCG")) > 0)
                        dead_weight_tcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Deadweight TCG"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement")) > 0)
                        displacement_lbl.Text = (summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement"))].ObjectValue/1000).ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement LCG")) > 0)
                        displacement_lcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement LCG"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement VCG")) > 0)
                        displacement_vcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement VCG"))].ObjectValue.ToString("0.00");

                    if (summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement TCG")) > 0)
                        displacement_tcg_lbl.Text = summaryList[summaryList.FindIndex(x => x.ObjectName.Equals("Diplacement TCG"))].ObjectValue.ToString("0.00");


                }

                SessionData.TankList = _tankList;

                //result.
            }
        }

        private void tank_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tankMappingList = _tankMappingModel.TankMappings.Where(x => x.LiquidName.Equals(liquid_master_list.SelectedValue.ToString())).ToList();
            var result = _tankList.Where(p => _tankMappingList.Any(p2 => p2.TankName == p.TankName)).ToList();
            if (result != null && result.Count > 0)
            {
                tank_list_view.AutoGenerateColumns = false;
                var source = new BindingSource(result, null);
                tank_list_view.DataSource = source;
                tank_list_view.Update();
            }
            else
            {
                tank_list_view.AutoGenerateColumns = false;
                var source = new BindingSource(_tankList, null);
                tank_list_view.DataSource = source;
                tank_list_view.Update();
            }
        }
    }
}
