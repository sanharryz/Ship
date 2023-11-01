namespace VesselLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("generalSettingsView"))
                {
                    c.Dispose();
                }
            }

            GeneralSettingsView generalSettingsView = new GeneralSettingsView();
            generalSettingsView.Name = "generalSettingsView";
            generalSettingsView.Dock = DockStyle.Fill;
            generalSettingsView.Visible = true;
            this.MainPanel.Controls.Add(generalSettingsView);

        }

        private void vessel_info_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("vesselInfoView"))
                {
                    c.Dispose();
                }
            }
            VesselInfoView vesselInfoView = new VesselInfoView();
            vesselInfoView.Name = "vesselInfoView";
            vesselInfoView.Dock = DockStyle.Fill;
            vesselInfoView.Visible = true;
            this.MainPanel.Controls.Add(vesselInfoView);
        }

        private void loading_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("loadingView"))
                {
                    c.Dispose();
                }
            }
            LoadingView loadingView = new LoadingView();
            loadingView.Name = "loadingView";
            loadingView.Dock = DockStyle.Fill;
            loadingView.Visible = true;
            this.MainPanel.Controls.Add(loadingView);
        }

        private void fixed_weight_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("fixedWeightView"))
                {
                    c.Dispose();
                }
            }
            FixedWeightView fixedWeightView = new FixedWeightView();
            fixedWeightView.Name = "fixedWeightView";
            fixedWeightView.Dock = DockStyle.Fill;
            fixedWeightView.Visible = true;
            this.MainPanel.Controls.Add(fixedWeightView);
        }

        private void intact_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("intactStabilityView"))
                {
                    c.Dispose();
                }
            }
            IntactStabilityView intactStabilityView = new IntactStabilityView();
            intactStabilityView.Name = "intactStabilityView";
            intactStabilityView.Dock = DockStyle.Fill;
            intactStabilityView.Visible = true;
            this.MainPanel.Controls.Add(intactStabilityView);
        }

        private void loadingView_Load(object sender, EventArgs e)
        {

        }

        private void logitudnal_strength_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("longitudnaStrengthView"))
                {
                    c.Dispose();
                }
            }
            LongitudnaStrengthView longitudnaStrengthView = new LongitudnaStrengthView();
            longitudnaStrengthView.Name = "longitudnaStrengthView";
            longitudnaStrengthView.Dock = DockStyle.Fill;
            longitudnaStrengthView.Visible = true;
            this.MainPanel.Controls.Add(longitudnaStrengthView);
        }

        private void damage_stability_btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("damageStabilityView"))
                {
                    c.Dispose();
                }
            }
            DamageStabilityView damageStabilityView = new DamageStabilityView();
            damageStabilityView.Name = "damageStabilityView";
            damageStabilityView.Dock = DockStyle.Fill;
            damageStabilityView.Visible = true;
            this.MainPanel.Controls.Add(damageStabilityView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in MainPanel.Controls)
            {
                if (c is UserControl && c.Visible && !c.Name.Equals("loadingView"))
                {
                    c.Dispose();
                }
            }
            LoadingView loadingView = new LoadingView();
            loadingView.Name = "loadingView";
            loadingView.Dock = DockStyle.Fill;
            loadingView.Visible = true;
            this.MainPanel.Controls.Add(loadingView);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}