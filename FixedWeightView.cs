using Newtonsoft.Json;
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
    public partial class FixedWeightView : UserControl
    {
        private SolidFixedWeightModeList _fixedWeightModel;
        public FixedWeightView()
        {
            InitializeComponent();
            _fixedWeightModel = new DataAdapter().getFixedWeightData();
        }

        private void fixed_weight_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SolidFixedWeightModel fixedWeight = new SolidFixedWeightModel()
                {
                    FSM = fixed_weight_fsm.Text,
                    LCG = fixed_weight_lcg.Text,
                    Name = fixed_weight_name_txt.Text,
                    TCG = fixed_weight_tcg.Text,
                    VCG = fixed_weight_vcg.Text,
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

        private void FixedWeightView_Load(object sender, EventArgs e)
        {
            if (_fixedWeightModel != null && _fixedWeightModel.FixedWeights != null)
            {
                var source = new BindingSource(_fixedWeightModel.FixedWeights, null);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = source;
                dataGridView2.AutoGenerateColumns = false;

                dataGridView2.Update();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2["Name", e.RowIndex].Value != null)
            {
                if (dataGridView2.Columns[e.ColumnIndex].HeaderText.Equals("Action"))
                {
                    _fixedWeightModel.FixedWeights.Remove(_fixedWeightModel.FixedWeights.Where(x => x.Name.Equals(dataGridView2["Name", e.RowIndex].Value)).FirstOrDefault());



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
                    fixed_weight_name_txt.Text = dataGridView2["Name", e.RowIndex].Value != null ?
                        dataGridView2["Name", e.RowIndex].Value.ToString() : "";
                    fixed_weight_tcg.Text = dataGridView2["TCG", e.RowIndex].Value != null ?
                        dataGridView2["TCG", e.RowIndex].Value.ToString() : "";
                    fixed_weight_vcg.Text = dataGridView2["VCG", e.RowIndex].Value != null ?
                        dataGridView2["VCG", e.RowIndex].Value.ToString() : "";
                    fixed_weight_txt.Text = dataGridView2["Weight", e.RowIndex].Value != null ?
                        dataGridView2["Weight", e.RowIndex].Value.ToString() : "";
                }
            }
        }
    }
}
