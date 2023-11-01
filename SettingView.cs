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
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VesselLoader
{
    public partial class GeneralSettingsView : UserControl
    {

        private TankMappingModel _tankMappingmodel;
        private List<Tank> _tankList;
        private List<Tank> _tanks;
        private SolidFixedWeightModeList _fixedWeightModel;
        private List<BendingShearValueModel> _bendingModels;
        private List<BendingShearValueModel> _shearModels;
        private List<DamageCaseMasterModel> _damageCaseMasterModels;

        public GeneralSettingsView()
        {
            InitializeComponent();

            try
            {
                _tankMappingmodel = new DataAdapter().getTankMappingData();
                _fixedWeightModel = new DataAdapter().getFixedWeightData();
                _bendingModels = new DataAdapter().getBendingData();
                _shearModels = new DataAdapter().getShearData();
                _tankList = new DataAdapter().getTankData();
                _tanks = new DataAdapter().getTankData();
                _damageCaseMasterModels = new DataAdapter().getDamageCaseData();

                if (_tankMappingmodel != null && _tankList != null && _tankMappingmodel.TankMappings != null)
                {
                    foreach (var tank in _tankMappingmodel.TankMappings)
                    {
                        var itemToRemove = _tankList.SingleOrDefault(x => x.TankName.Equals(tank.TankName));
                        if (itemToRemove != null)
                            _tankList.Remove(itemToRemove);
                    }

                }
                else
                {
                    _tankMappingmodel = new TankMappingModel();
                    _tankList = new DataAdapter().getTankData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hydrostat_file_brws_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Hull Hydrostat Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "dat",
                    Filter = "dat files (*.dat)|*.dat",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hydrostat_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }


        }

        private void hull_hydrostat_data_prcs_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hydrostat_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(hydrostat_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid file", "Error while file processing", MessageBoxButtons.OK);
            }
            else
            {
                //shgeom = new DataFileProcessor().ReaddShipgeomdata(hydrostat_file_name_txt.Text);
                //shgeom.LBP = shpLbp;
                //List<Section> sectionList = iohelper.ReadSectionData();
            }
        }

        private void section_data_file_brws_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Section Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "dat",
                    Filter = "dat files (*.dat)|*.dat",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    section_data_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }
        }

        private void xcodinates_file_brws_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Section Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "dat",
                    Filter = "dat files (*.dat)|*.dat",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    xcordinates_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }
        }

        private void tank_file_brws_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Tank Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tank_data_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }
        }

        private void hull_dist_file_brws_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Hull Distribution Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "dat",
                    Filter = "dat files (*.dat)|*.dat",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hull_dist_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hydrostat_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file for Hrdrostatic distribution,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(hydrostat_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid file Hrdrostatic distribution file", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(section_data_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file for section data file,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(section_data_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid section data file", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(xcordinates_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file for X-Codinates data file,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(xcordinates_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid X-Codinates data file", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(tank_data_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file for tank data file,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(tank_data_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid tank data file", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(hull_dist_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse the file for hull distribution file,first", "Error while file processing", MessageBoxButtons.OK);
            }
            else if (!File.Exists(hull_dist_file_name_txt.Text))
            {
                MessageBox.Show(this, "Please browse a valid hull distribution file", "Error while file processing", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    ShipGeom shgeom = new DataFileProcessor().ReaddShipgeomdata(hydrostat_file_name_txt.Text);
                    shgeom.LBP = double.Parse(new DataAdapter().getVesselInfo().LBP);

                    List<Section> sectionList = new DataFileProcessor().ReadSectionData(section_data_file_name_txt.Text, xcordinates_file_name_txt.Text);

                    List<Tank> tankGeoInfoList = new DataFileProcessor().ReadShipTankData(tank_data_file_name_txt.Text);
                    tankGeoInfoList.RemoveAt(0);

                    List<Tank> tankbasicInfoList = new DataFileProcessor().GetPermiability(permiability_file_name_txt.Text);


                    List<Vector2D> hulldist = new DataFileProcessor().ReadHullDistData(hull_dist_file_name_txt.Text);


                    shgeom.GetHullWtDistribution(sectionList, hulldist, 1000);
                    //HardCoded

                    //HardCoded
                    //shgeom.GetHullWtDistribution(sectionList, hulldist, 1000);
                    List<LiquidWeightModel> liqModelList = new List<LiquidWeightModel>();
                    foreach (Tank tank in tankGeoInfoList)
                    {
                        LiquidWeightModel tankmodel = new LiquidWeightModel();
                        foreach (Tank dummytank in tankbasicInfoList)
                        {
                            if (dummytank.TankName == tank.TankName)
                            {
                                tank.Permiability = dummytank.Permiability;
                                tank.LiquidRho = dummytank.LiquidRho;
                                tank.GetTankSoundings(tank);
                                tank.GetSecTankAreaSounding(tank);
                                break;
                            }
                        }

                        tankmodel.Tankname = tank.TankName;
                        tankmodel.Weight = tank.MaxWeight / tank.LiquidRho;
                        Models.Point pt = new Models.Point(tank.TankLcg[tank.TankLcg.Count - 1].Y, tank.TankTcg[tank.TankTcg.Count - 1].Y, tank.TankVcg[tank.TankVcg.Count - 1].Y);
                        tankmodel.CG = pt;

                        liqModelList.Add(tankmodel);
                    }

                    CrossCurveInputDataModel _crossCurveParameterData = new DataAdapter().getCrossCurveInputData();

                    //hardcoded
                    CrossCurve _crossCurve = new OutputParamHelper().GetCrossCurveData(sectionList, double.Parse(_crossCurveParameterData.MinHealingAngle),
                                double.Parse(_crossCurveParameterData.MaxHealingAngle), double.Parse(_crossCurveParameterData.IncrementAngle),
                                double.Parse(_crossCurveParameterData.MaxDraftMark), 1025);

                    new DataAdapter().saveCrossCurveData(JsonConvert.SerializeObject(_crossCurve));
                    new DataAdapter().saveTankData(JsonConvert.SerializeObject(tankGeoInfoList));
                    new DataAdapter().saveSectionListData(JsonConvert.SerializeObject(sectionList));
                    new DataAdapter().saveShipGeometryData(JsonConvert.SerializeObject(shgeom));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error while file processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            alert_lbl.Visible = false;
            bool isValid = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = c as System.Windows.Forms.TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        textBox.BackColor = Color.LightCyan;
                        alert_lbl.Visible = true;
                        isValid = false;
                        textBox.Focus();
                        break;
                    }
                    else
                    {
                        textBox.BackColor = SystemColors.Window;
                    }

                }
            }
            if (isValid)
            {

                foreach (Control c in groupBox2.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        System.Windows.Forms.TextBox textBox = c as System.Windows.Forms.TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            textBox.BackColor = Color.LightCyan;
                            alert_lbl.Visible = true;
                            isValid = false;
                            textBox.Focus();
                            break;
                        }
                        else
                        {
                            textBox.BackColor = SystemColors.Window;
                        }

                    }
                }

                if (isValid)
                {
                    try
                    {
                        new DataAdapter().saveVesselInfo(JsonConvert.SerializeObject(new Models.VesselInfo()
                        {
                            Breadth = breadth_txt.Text,
                            Deadweight = deadweight_txt.Text,
                            Depth = depth_txt.Text,
                            Displacement = displacement_txt.Text,
                            Draft = draft_txt.Text,
                            Grosstonnage = grosstonnage_txt.Text,
                            IMONo = imo_no_txt.Text,
                            LBP = lbp_txt.Text,
                            Lightship = lightship_txt.Text,
                            LOA = loa_txt.Text,
                            NetTonnage = nettonnage_txt.Text,
                            VesselName = vessel_name_txt.Text,
                            VesselType = vessel_type_txt.Text,
                            WaterDensity = water_density_txt.Text
                        }));

                        MessageBox.Show(this, "Data saved successully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show(this, ex.Message, "Error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void vessel_name_txt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void water_density_txt_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            try
            {
                var vesselInfo = new Helper.DataAdapter().getVesselInfo();
                if (vesselInfo != null)
                {
                    breadth_txt.Text = vesselInfo.Breadth;
                    deadweight_txt.Text = vesselInfo.Deadweight;
                    depth_txt.Text = vesselInfo.Depth;
                    displacement_txt.Text = vesselInfo.Displacement;
                    draft_txt.Text = vesselInfo.Draft;
                    grosstonnage_txt.Text = vesselInfo.Grosstonnage;
                    imo_no_txt.Text = vesselInfo.IMONo;
                    lbp_txt.Text = vesselInfo.LBP;
                    lightship_txt.Text = vesselInfo.Lightship;
                    loa_txt.Text = vesselInfo.LOA;
                    nettonnage_txt.Text = vesselInfo.NetTonnage;
                    vessel_name_txt.Text = vesselInfo.VesselName;
                    vessel_type_txt.Text = vesselInfo.VesselType;
                    water_density_txt.Text = vesselInfo.WaterDensity;
                }


                var liquidMasterData = new DataAdapter().getMasterLiquidData();

                var bindingSource = new BindingSource();
                bindingSource.DataSource = liquidMasterData.Liquids;

                liquid_master_list.DataSource = bindingSource;
                liquid_master_list.DisplayMember = "Name";
                liquid_master_list.ValueMember = "Name";

                if (_tanks != null)
                {
                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = _tanks;

                    tank_master_list.DataSource = bindingSource1;
                    tank_master_list.DisplayMember = "TankName";
                    tank_master_list.ValueMember = "TankName";

                    foreach (var tank in _tanks)
                    {
                        tank_list_box.Items.Add(tank.TankName);
                    }
                }



                if (_tankMappingmodel != null && _tankMappingmodel.TankMappings != null)
                {
                    var source = new BindingSource(_tankMappingmodel.TankMappings, null);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = source;
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Update();
                }

                if (_fixedWeightModel != null && _fixedWeightModel.FixedWeights != null)
                {
                    var source = new BindingSource(_fixedWeightModel.FixedWeights, null);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = source;
                    dataGridView2.AutoGenerateColumns = false;

                    dataGridView2.Update();
                }

                if (_bendingModels != null && _bendingModels.Count > 0)
                {
                    var source = new BindingSource(_bendingModels, null);
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = source;
                    dataGridView3.AutoGenerateColumns = false;

                    dataGridView3.Update();
                }

                if (_shearModels != null && _shearModels.Count > 0)
                {
                    var source = new BindingSource(_shearModels, null);
                    dataGridView4.DataSource = null;
                    dataGridView4.DataSource = source;
                    dataGridView4.AutoGenerateColumns = false;

                    dataGridView4.Update();
                }

                if (_damageCaseMasterModels != null && _damageCaseMasterModels.Count > 0)
                {
                    var source = new BindingSource(_damageCaseMasterModels, null);
                    dataGridView5.DataSource = null;
                    dataGridView5.DataSource = source;
                    dataGridView5.AutoGenerateColumns = false;

                    dataGridView5.Update();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //if (tabControl1.SelectedIndex == 1)
            {
                var vesselInfo = new Helper.DataAdapter().getVesselInfo();
                if (vesselInfo != null)
                {
                    breadth_txt.Text = vesselInfo.Breadth;
                    deadweight_txt.Text = vesselInfo.Deadweight;
                    depth_txt.Text = vesselInfo.Depth;
                    displacement_txt.Text = vesselInfo.Displacement;
                    draft_txt.Text = vesselInfo.Draft;
                    grosstonnage_txt.Text = vesselInfo.Grosstonnage;
                    imo_no_txt.Text = vesselInfo.IMONo;
                    lbp_txt.Text = vesselInfo.LBP;
                    lightship_txt.Text = vesselInfo.Lightship;
                    loa_txt.Text = vesselInfo.LOA;
                    nettonnage_txt.Text = vesselInfo.NetTonnage;
                    vessel_name_txt.Text = vesselInfo.VesselName;
                    vessel_type_txt.Text = vesselInfo.VesselType;
                    water_density_txt.Text = vesselInfo.WaterDensity;
                }
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var liquidMasterData = new DataAdapter().getMasterLiquidData();

                var bindingSource = new BindingSource();
                bindingSource.DataSource = liquidMasterData.Liquids;

                liquid_master_list.DataSource = bindingSource;
                liquid_master_list.DisplayMember = "Name";
                liquid_master_list.ValueMember = "Name";

                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = _tankList;

                tank_master_list.DataSource = bindingSource1;
                tank_master_list.DisplayMember = "TankName";
                tank_master_list.ValueMember = "TankName";


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (tank_master_list.SelectedValue != null && liquid_master_list.SelectedValue != null)
            {
                if (_tankMappingmodel.TankMappings != null)
                {
                    _tankMappingmodel.TankMappings.Add(new TankMapping()
                    {
                        LiquidName = liquid_master_list.SelectedValue.ToString(),
                        TankName = tank_master_list.SelectedValue.ToString()
                    });
                    var source = new BindingSource(_tankMappingmodel.TankMappings, null);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = source;
                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Update();

                    new DataAdapter().getTankData();

                    var itemToRemove = _tankList.SingleOrDefault(x => x.TankName.Equals(tank_master_list.SelectedValue.ToString()));
                    if (itemToRemove != null)
                        _tankList.Remove(itemToRemove);


                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = _tankList;

                    tank_master_list.DataSource = bindingSource1;
                    tank_master_list.DisplayMember = "TankName";
                    tank_master_list.ValueMember = "TankName";

                }
                else
                {
                    _tankMappingmodel.TankMappings = new List<TankMapping>()
                    {
                        new TankMapping()
                        {
                            LiquidName = liquid_master_list.SelectedValue.ToString(),
                            TankName = tank_master_list.SelectedValue.ToString()
                        }
                    };

                    dataGridView1.AutoGenerateColumns = false;
                    var source = new BindingSource(_tankMappingmodel.TankMappings, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Update();
                    var itemToRemove = _tankList.SingleOrDefault(x => x.TankName.Equals(tank_master_list.SelectedValue.ToString()));
                    if (itemToRemove != null)
                        _tankList.Remove(itemToRemove);
                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = _tankList;

                    tank_master_list.DataSource = bindingSource1;
                    tank_master_list.DisplayMember = "TankName";
                    tank_master_list.ValueMember = "TankName";

                }
            }
            else
            {
                MessageBox.Show(this, "Please load the master data, first", "Error while loading data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Action")
                && dataGridView1["TankName", e.RowIndex].Value != null)
            {
                _tankList.Add(new Tank()
                {
                    TankName = dataGridView1["TankName", e.RowIndex].Value.ToString()
                });

                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = _tankList;

                tank_master_list.DataSource = bindingSource1;
                tank_master_list.DisplayMember = "TankName";
                tank_master_list.ValueMember = "TankName";

                dataGridView1.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void tank_map_save_btn_Click(object sender, EventArgs e)
        {
            TankMappingModel tankMapping = new TankMappingModel();
            int _tankNameIndex = dataGridView1.Columns["TankName"].Index;
            int _liquidNameIndex = dataGridView1.Columns["LiquidName"].Index;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TankMapping mapping = new TankMapping();

                if (row != null && row.Cells[_tankNameIndex].Value != null)
                {

                    mapping.TankName = row.Cells[_tankNameIndex].Value.ToString();
                    mapping.LiquidName = row.Cells[_liquidNameIndex].Value.ToString();
                    if (tankMapping.TankMappings == null)
                    {
                        tankMapping.TankMappings = new List<TankMapping>()
                        {
                            mapping
                        };
                    }
                    else
                    {
                        tankMapping.TankMappings.Add(mapping);
                    }
                }
            }

            try
            {
                new DataAdapter().saveTankMappingData(Newtonsoft.Json.JsonConvert.SerializeObject(tankMapping));
                MessageBox.Show(this, "Data saved successfully", "Saving data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while saving data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fixed_weight_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SolidFixedWeightModel fixedWeight = new SolidFixedWeightModel()
                {
                    FSM = string.IsNullOrEmpty(fixed_weight_fsm.Text) ? "0.00" : fixed_weight_fsm.Text,
                    LCG = string.IsNullOrEmpty(fixed_weight_lcg.Text) ? "0.00" : fixed_weight_lcg.Text,
                    Name = fixed_weight_name_txt.Text,
                    TCG =  string.IsNullOrEmpty(fixed_weight_tcg.Text) ? "0.00" : fixed_weight_tcg.Text,
                    VCG = string.IsNullOrEmpty(fixed_weight_vcg.Text) ? "0.00" : fixed_weight_vcg.Text,
                    Weight = fixed_weight_txt.Text
                };

                if (_fixedWeightModel == null || _fixedWeightModel.FixedWeights.Count == 0)
                {
                    _fixedWeightModel = new SolidFixedWeightModeList();
                    _fixedWeightModel.FixedWeights = new List<SolidFixedWeightModel> { fixedWeight };
                    var jsonTemp = JsonConvert.SerializeObject(_fixedWeightModel);
                    new DataAdapter().saveFixedWeightData(jsonTemp);
                    dataGridView2.AutoGenerateColumns = false;
                    var source = new BindingSource(_fixedWeightModel.FixedWeights, null);
                    dataGridView2.DataSource = source;
                    dataGridView2.Update();
                }
                else
                {
                    _fixedWeightModel.FixedWeights.Add(fixedWeight);
                    var jsonTemp = JsonConvert.SerializeObject(_fixedWeightModel);
                    new DataAdapter().saveFixedWeightData(jsonTemp);
                    dataGridView2.AutoGenerateColumns = false;
                    var source = new BindingSource(_fixedWeightModel.FixedWeights, null);
                    dataGridView2.DataSource = source;
                    dataGridView2.Update();
                }
                fixed_weight_fsm.Clear();
                fixed_weight_lcg.Clear();
                fixed_weight_name_txt.Clear();
                fixed_weight_tcg.Clear();
                fixed_weight_vcg.Clear();
                fixed_weight_txt.Clear();

                //tank_master_list.DisplayMember = "Fixed Weight";
                //tank_master_list.ValueMember = "FixedWeight";

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while saving data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2["FixedWeightName", e.RowIndex].Value != null)
            {
                if (dataGridView2.Columns[e.ColumnIndex].HeaderText.Equals("Action"))
                {
                    _fixedWeightModel.FixedWeights.Remove(_fixedWeightModel.FixedWeights.Where(x => x.Name.Equals(dataGridView2["FixedWeightName", e.RowIndex].Value)).FirstOrDefault());



                    var source = new BindingSource(_fixedWeightModel.FixedWeights, null);
                    dataGridView2.DataSource = source;
                    dataGridView2.Update();

                }
                else
                {
                    fixed_weight_fsm.Text = dataGridView2["FSM", e.RowIndex].Value != null ?
                        dataGridView2["FSM", e.RowIndex].Value.ToString() : "";
                    fixed_weight_lcg.Text = dataGridView2["LCG", e.RowIndex].Value != null ?
                        dataGridView2["LCG", e.RowIndex].Value.ToString() : "";
                    fixed_weight_name_txt.Text = dataGridView2["FixedWeightName", e.RowIndex].Value != null ?
                        dataGridView2["FixedWeightName", e.RowIndex].Value.ToString() : "";
                    fixed_weight_tcg.Text = dataGridView2["TCG", e.RowIndex].Value != null ?
                        dataGridView2["TCG", e.RowIndex].Value.ToString() : "";
                    fixed_weight_vcg.Text = dataGridView2["VCG", e.RowIndex].Value != null ?
                        dataGridView2["VCG", e.RowIndex].Value.ToString() : "";
                    fixed_weight_txt.Text = dataGridView2["Weight", e.RowIndex].Value != null ?
                        dataGridView2["Weight", e.RowIndex].Value.ToString() : "";
                }
            }
        }

        private void permiability_browse_btn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    //InitialDirectory = @"D:\",
                    Title = "Browse Permiability Data File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "dat",
                    Filter = "dat files (*.dat)|*.dat",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    permiability_file_name_txt.Text = openFileDialog.FileName;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, ex.Message, "Error while file browsing", MessageBoxButtons.OK);
            }
        }

        private void cross_curve_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Models.CrossCurveInputDataModel crossCurveInputDataModel = new Models.CrossCurveInputDataModel();
                crossCurveInputDataModel.IncrementAngle = increment_angle_txt.Text;
                crossCurveInputDataModel.MaxDraftMark = max_draft_mark_txt.Text;
                crossCurveInputDataModel.MaxHealingAngle = max_healing_angle_txt.Text;
                crossCurveInputDataModel.MinHealingAngle = min_healing_angle_txt.Text;

                new DataAdapter().saveCrossCurveInputData(JsonConvert.SerializeObject(crossCurveInputDataModel));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error while saving data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shear_bending_save_btn_Click(object sender, EventArgs e)
        {
            //List<BendingShearValueModel> bendingShearValueModels = new List<BendingShearValueModel>();
            if (_bendingModels != null && _bendingModels.Count > 0)
            {
                BendingShearValueModel bendingShearValueModel = new BendingShearValueModel()
                {
                    FrameNumber = frame_no_txt.Text,
                    XPositiveValue = double.Parse(x_value_txt.Text),
                    YPositiveValue = double.Parse(y_positive_value_txt.Text),
                    XNegativeValue = double.Parse(x_value_txt.Text),
                    YNegativeValue = double.Parse(y_negative_value_txt.Text)
                };
                _bendingModels.Add(bendingShearValueModel);
            }
            else
            {
                BendingShearValueModel bendingShearValueModel = new BendingShearValueModel()
                {
                    FrameNumber = frame_no_txt.Text,
                    XPositiveValue = double.Parse(x_value_txt.Text),
                    YPositiveValue = double.Parse(y_positive_value_txt.Text),
                    XNegativeValue = double.Parse(x_value_txt.Text),
                    YNegativeValue = double.Parse(y_negative_value_txt.Text)
                };
                _bendingModels = new List<BendingShearValueModel> { bendingShearValueModel };
            }
            var source = new BindingSource(_bendingModels, null);
            dataGridView3.DataSource = source;
            dataGridView3.Update();

            new DataAdapter().saveBendingData(JsonConvert.SerializeObject(_bendingModels));

            if (_shearModels != null && _shearModels.Count > 0)
            {
                BendingShearValueModel bendingShearValueModel = new BendingShearValueModel()
                {
                    FrameNumber = frame_no_txt.Text,
                    XPositiveValue = double.Parse(shear_force_x_val_txt.Text),
                    YPositiveValue = double.Parse(shear_force_y_pos_val_txt.Text),
                    XNegativeValue = double.Parse(shear_force_x_val_txt.Text),
                    YNegativeValue = double.Parse(shear_frc_y_negtv_val_txt.Text)
                };
                _shearModels.Add(bendingShearValueModel);
            }
            else
            {
                BendingShearValueModel bendingShearValueModel = new BendingShearValueModel()
                {
                    FrameNumber = frame_no_txt.Text,
                    XPositiveValue = double.Parse(shear_force_x_val_txt.Text),
                    YPositiveValue = double.Parse(shear_force_y_pos_val_txt.Text),
                    XNegativeValue = double.Parse(shear_force_x_val_txt.Text),
                    YNegativeValue = double.Parse(shear_frc_y_negtv_val_txt.Text)
                };
                _shearModels = new List<BendingShearValueModel> { bendingShearValueModel };
            }
            var source1 = new BindingSource(_shearModels, null);
            dataGridView4.DataSource = source1;
            dataGridView4.Update();

            new DataAdapter().saveShearData(JsonConvert.SerializeObject(_shearModels));
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3["FrameNumber", e.RowIndex].Value != null)
            {
                if (dataGridView3.Columns[e.ColumnIndex].HeaderText.Equals("Action"))
                {
                    _bendingModels.Remove(_bendingModels.Where(x => x.FrameNumber.Equals(dataGridView3["FrameNumber", e.RowIndex].Value)).FirstOrDefault());
                    var source = new BindingSource(_bendingModels, null);
                    dataGridView3.DataSource = source;
                    dataGridView3.Update();
                }
                else
                {
                    frame_no_txt.Text = dataGridView3["FrameNumber", e.RowIndex].Value != null ?
                        dataGridView3["FrameNumber", e.RowIndex].Value.ToString() : "";
                    x_value_txt.Text = dataGridView3["XPositiveValue", e.RowIndex].Value != null ?
                        dataGridView3["XPositiveValue", e.RowIndex].Value.ToString() : "";
                    y_positive_value_txt.Text = dataGridView3["YPositiveValue", e.RowIndex].Value != null ?
                        dataGridView3["YPositiveValue", e.RowIndex].Value.ToString() : "";
                    y_negative_value_txt.Text = dataGridView3["YNegativeValue", e.RowIndex].Value != null ?
                        dataGridView3["YNegativeValue", e.RowIndex].Value.ToString() : "";



                }
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4["ShearFrameNumber", e.RowIndex].Value != null)
            {
                if (dataGridView4.Columns[e.ColumnIndex].HeaderText.Equals("Action"))
                {
                    _shearModels.Remove(_shearModels.Where(x => x.FrameNumber.Equals(dataGridView4["ShearFrameNumber", e.RowIndex].Value)).FirstOrDefault());
                    var source = new BindingSource(_shearModels, null);
                    dataGridView4.DataSource = source;
                    dataGridView4.Update();
                }
                else
                {
                    frame_no_txt.Text = dataGridView4["ShearFrameNumber", e.RowIndex].Value != null ?
                        dataGridView4["ShearFrameNumber", e.RowIndex].Value.ToString() : "";
                    shear_force_x_val_txt.Text = dataGridView4["ShearXPositiveValue", e.RowIndex].Value != null ?
                        dataGridView4["ShearXPositiveValue", e.RowIndex].Value.ToString() : "";
                    shear_force_y_pos_val_txt.Text = dataGridView4["ShearYPositiveValue", e.RowIndex].Value != null ?
                        dataGridView4["ShearYPositiveValue", e.RowIndex].Value.ToString() : "";
                    shear_frc_y_negtv_val_txt.Text = dataGridView4["ShearYNegativeValue", e.RowIndex].Value != null ?
                        dataGridView4["ShearYNegativeValue", e.RowIndex].Value.ToString() : "";

                }
            }
        }

        private void damage_case_save_btn_Click_1(object sender, EventArgs e)
        {
            tank_list_box.Visible = false;
            if (!string.IsNullOrEmpty(damage_case_name_txt.Text)
                && !string.IsNullOrEmpty(tank_list_txt.Text))
            {
                if (_damageCaseMasterModels != null && _damageCaseMasterModels.Count > 0)
                {
                    Models.DamageCaseMasterModel damageCaseMasterModel = new Models.DamageCaseMasterModel()
                    {
                        DamageCaseName = damage_case_name_txt.Text,
                        TankNames = tank_list_txt.Text.Split(",").ToList<string>(),
                        TankNamesForDisplay = tank_list_txt.Text
                    };
                    _damageCaseMasterModels.Add(damageCaseMasterModel);
                }
                else
                {
                    Models.DamageCaseMasterModel damageCaseMasterModel = new Models.DamageCaseMasterModel()
                    {
                        DamageCaseName = damage_case_name_txt.Text,
                        TankNames = tank_list_txt.Text.Split(",").ToList<string>(),
                        TankNamesForDisplay = tank_list_txt.Text
                    };
                    _damageCaseMasterModels = new List<DamageCaseMasterModel> { damageCaseMasterModel };
                }
                var source = new BindingSource(_damageCaseMasterModels, null);
                dataGridView5.DataSource = source;
                dataGridView5.Update();

                new DataAdapter().saveDamageCaseData(JsonConvert.SerializeObject(_damageCaseMasterModels));

                damage_case_name_txt.Clear();
                tank_list_box.Items.Clear();
                foreach (var tank in _tankList)
                {
                    tank_list_box.Items.Add(tank.TankName);
                }
                tank_list_txt.Clear();
            }
            else
            {
                MessageBox.Show(this, "please enter the details");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tank_list_box.Visible = true;
        }

        private void tank_list_box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (sender != null && e != null)
            {
                // Get the checkListBox selected time and it's CheckState
                CheckedListBox checkListBox = (CheckedListBox)sender;

                string selectedItem = checkListBox.SelectedItem.ToString();
                if (string.IsNullOrEmpty(tank_list_txt.Text))
                {
                    //if (e.CurrentValue == CheckState.Unchecked)
                    {

                        tank_list_txt.Text = selectedItem;
                    }
                }
                else
                {
                    if (
                        !tank_list_txt.Text.Split(",").Contains(selectedItem))
                    {
                        tank_list_txt.Text += "," + selectedItem;
                    }
                }

            }
        }

        private void tank_list_txt_Click(object sender, EventArgs e)
        {
            tank_list_box.Visible = true;
        }

        private void tank_list_box_Leave(object sender, EventArgs e)
        {
            tank_list_box.Visible = false;
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5["DamageCaseName", e.RowIndex].Value != null)
            {
                if (dataGridView5.Columns[e.ColumnIndex].HeaderText.Equals("Action"))
                {
                    _damageCaseMasterModels.Remove(_damageCaseMasterModels.Where(x => x.DamageCaseName.Equals(dataGridView5["DamageCaseName", e.RowIndex].Value)).FirstOrDefault());
                    var source = new BindingSource(_damageCaseMasterModels, null);
                    dataGridView5.DataSource = source;
                    dataGridView5.Update();
                }
            }
        }
    }
}
