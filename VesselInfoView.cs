using Microsoft.VisualBasic.Logging;
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

namespace VesselLoader
{
    public partial class VesselInfoView : UserControl
    {
        public VesselInfoView()
        {
            InitializeComponent();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            alert_lbl.Visible = false;
            bool isValid = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is System.Windows.Forms.TextBox && c.Enabled)
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
                    if (c is System.Windows.Forms.TextBox && c.Enabled)
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
                        new Helper.DataAdapter().saveVesselInfo(JsonConvert.SerializeObject(new Models.VesselInfo()
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

        private void VesselInfoView_VisibleChanged(object sender, EventArgs e)
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

        private void VesselInfoView_Load(object sender, EventArgs e)
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
}
