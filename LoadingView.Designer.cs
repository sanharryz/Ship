namespace VesselLoader
{
    partial class LoadingView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadingMainPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            liquid_master_list = new ComboBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label2 = new Label();
            lightship_lbl_txt = new Label();
            label3 = new Label();
            constant_total_lbl = new Label();
            label4 = new Label();
            bwt_total_lbl = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            fot_total_lbl = new Label();
            fwt_total_lbl = new Label();
            misc_total_lbl = new Label();
            liquid_cargo_total_lbl = new Label();
            label10 = new Label();
            dead_weight_lbl = new Label();
            label11 = new Label();
            dead_weight_lcg_lbl = new Label();
            label12 = new Label();
            dead_weight_vcg_lbl = new Label();
            label13 = new Label();
            dead_weight_tcg_lbl = new Label();
            label14 = new Label();
            displacement_lbl = new Label();
            label15 = new Label();
            displacement_lcg_lbl = new Label();
            label16 = new Label();
            label17 = new Label();
            displacement_tcg_lbl = new Label();
            displacement_vcg_lbl = new Label();
            dot_total_lbl = new Label();
            tank_list_view = new DataGridView();
            TankName = new DataGridViewTextBoxColumn();
            MaxWeight = new DataGridViewTextBoxColumn();
            SPG = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            VolumePercenetage = new DataGridViewTextBoxColumn();
            LCG = new DataGridViewTextBoxColumn();
            VCG = new DataGridViewTextBoxColumn();
            TCG = new DataGridViewTextBoxColumn();
            FSM = new DataGridViewTextBoxColumn();
            FSMActual = new DataGridViewTextBoxColumn();
            LoadingMainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tank_list_view).BeginInit();
            SuspendLayout();
            // 
            // LoadingMainPanel
            // 
            LoadingMainPanel.ColumnCount = 2;
            LoadingMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LoadingMainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LoadingMainPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            LoadingMainPanel.Dock = DockStyle.Fill;
            LoadingMainPanel.Location = new Point(0, 0);
            LoadingMainPanel.Margin = new Padding(4, 2, 4, 2);
            LoadingMainPanel.Name = "LoadingMainPanel";
            LoadingMainPanel.RowCount = 1;
            LoadingMainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LoadingMainPanel.Size = new Size(1469, 1018);
            LoadingMainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(tank_list_view, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(738, 2);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2582321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.8565369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.88523F));
            tableLayoutPanel1.Size = new Size(727, 1014);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.23529F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(liquid_master_list, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(715, 92);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 92);
            label1.TabIndex = 0;
            label1.Text = "Tank Name :";
            // 
            // liquid_master_list
            // 
            liquid_master_list.Anchor = AnchorStyles.Left;
            liquid_master_list.FormattingEnabled = true;
            liquid_master_list.Location = new Point(90, 26);
            liquid_master_list.Margin = new Padding(6);
            liquid_master_list.Name = "liquid_master_list";
            liquid_master_list.Size = new Size(221, 40);
            liquid_master_list.TabIndex = 1;
            liquid_master_list.SelectedIndexChanged += tank_name_list_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 612);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 399);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loading Summary";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(lightship_lbl_txt, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(constant_total_lbl, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(bwt_total_lbl, 1, 2);
            tableLayoutPanel3.Controls.Add(label6, 0, 4);
            tableLayoutPanel3.Controls.Add(label7, 0, 5);
            tableLayoutPanel3.Controls.Add(label8, 0, 6);
            tableLayoutPanel3.Controls.Add(label9, 0, 7);
            tableLayoutPanel3.Controls.Add(fot_total_lbl, 1, 4);
            tableLayoutPanel3.Controls.Add(fwt_total_lbl, 1, 5);
            tableLayoutPanel3.Controls.Add(misc_total_lbl, 1, 6);
            tableLayoutPanel3.Controls.Add(liquid_cargo_total_lbl, 1, 7);
            tableLayoutPanel3.Controls.Add(label10, 2, 0);
            tableLayoutPanel3.Controls.Add(dead_weight_lbl, 3, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 1);
            tableLayoutPanel3.Controls.Add(dead_weight_lcg_lbl, 3, 1);
            tableLayoutPanel3.Controls.Add(label12, 2, 2);
            tableLayoutPanel3.Controls.Add(dead_weight_vcg_lbl, 3, 2);
            tableLayoutPanel3.Controls.Add(label13, 2, 3);
            tableLayoutPanel3.Controls.Add(dead_weight_tcg_lbl, 3, 3);
            tableLayoutPanel3.Controls.Add(label14, 2, 4);
            tableLayoutPanel3.Controls.Add(displacement_lbl, 3, 4);
            tableLayoutPanel3.Controls.Add(label15, 2, 5);
            tableLayoutPanel3.Controls.Add(displacement_lcg_lbl, 3, 5);
            tableLayoutPanel3.Controls.Add(label16, 2, 6);
            tableLayoutPanel3.Controls.Add(label17, 2, 7);
            tableLayoutPanel3.Controls.Add(displacement_tcg_lbl, 3, 7);
            tableLayoutPanel3.Controls.Add(displacement_vcg_lbl, 3, 6);
            tableLayoutPanel3.Controls.Add(dot_total_lbl, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 35);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.Size = new Size(715, 361);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 135);
            label5.Name = "label5";
            label5.Size = new Size(77, 45);
            label5.TabIndex = 6;
            label5.Text = "DOT Total :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 45);
            label2.TabIndex = 0;
            label2.Text = "Lightship :";
            // 
            // lightship_lbl_txt
            // 
            lightship_lbl_txt.Anchor = AnchorStyles.Left;
            lightship_lbl_txt.AutoSize = true;
            lightship_lbl_txt.Location = new Point(110, 6);
            lightship_lbl_txt.Name = "lightship_lbl_txt";
            lightship_lbl_txt.Size = new Size(0, 32);
            lightship_lbl_txt.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(101, 45);
            label3.TabIndex = 2;
            label3.Text = "Constant Total :";
            // 
            // constant_total_lbl
            // 
            constant_total_lbl.Anchor = AnchorStyles.Left;
            constant_total_lbl.AutoSize = true;
            constant_total_lbl.Location = new Point(110, 51);
            constant_total_lbl.Name = "constant_total_lbl";
            constant_total_lbl.Size = new Size(0, 32);
            constant_total_lbl.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(77, 45);
            label4.TabIndex = 4;
            label4.Text = "BWT Total :";
            // 
            // bwt_total_lbl
            // 
            bwt_total_lbl.Anchor = AnchorStyles.Left;
            bwt_total_lbl.AutoSize = true;
            bwt_total_lbl.Location = new Point(110, 96);
            bwt_total_lbl.Name = "bwt_total_lbl";
            bwt_total_lbl.Size = new Size(0, 32);
            bwt_total_lbl.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 180);
            label6.Name = "label6";
            label6.Size = new Size(77, 45);
            label6.TabIndex = 7;
            label6.Text = "FOT Total :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 225);
            label7.Name = "label7";
            label7.Size = new Size(77, 45);
            label7.TabIndex = 8;
            label7.Text = "FWT Total :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 270);
            label8.Name = "label8";
            label8.Size = new Size(77, 45);
            label8.TabIndex = 9;
            label8.Text = "Misc Total :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 315);
            label9.Name = "label9";
            label9.Size = new Size(84, 46);
            label9.TabIndex = 10;
            label9.Text = "Lqd. Cargo Total :";
            // 
            // fot_total_lbl
            // 
            fot_total_lbl.Anchor = AnchorStyles.Left;
            fot_total_lbl.AutoSize = true;
            fot_total_lbl.Location = new Point(110, 186);
            fot_total_lbl.Name = "fot_total_lbl";
            fot_total_lbl.Size = new Size(0, 32);
            fot_total_lbl.TabIndex = 11;
            // 
            // fwt_total_lbl
            // 
            fwt_total_lbl.Anchor = AnchorStyles.Left;
            fwt_total_lbl.AutoSize = true;
            fwt_total_lbl.Location = new Point(110, 231);
            fwt_total_lbl.Name = "fwt_total_lbl";
            fwt_total_lbl.Size = new Size(0, 32);
            fwt_total_lbl.TabIndex = 12;
            // 
            // misc_total_lbl
            // 
            misc_total_lbl.Anchor = AnchorStyles.Left;
            misc_total_lbl.AutoSize = true;
            misc_total_lbl.Location = new Point(110, 276);
            misc_total_lbl.Name = "misc_total_lbl";
            misc_total_lbl.Size = new Size(0, 32);
            misc_total_lbl.TabIndex = 13;
            // 
            // liquid_cargo_total_lbl
            // 
            liquid_cargo_total_lbl.Anchor = AnchorStyles.Left;
            liquid_cargo_total_lbl.AutoSize = true;
            liquid_cargo_total_lbl.Location = new Point(110, 322);
            liquid_cargo_total_lbl.Name = "liquid_cargo_total_lbl";
            liquid_cargo_total_lbl.Size = new Size(0, 32);
            liquid_cargo_total_lbl.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(360, 0);
            label10.Name = "label10";
            label10.Size = new Size(97, 45);
            label10.TabIndex = 15;
            label10.Text = "Dead Weight :";
            // 
            // dead_weight_lbl
            // 
            dead_weight_lbl.Anchor = AnchorStyles.Left;
            dead_weight_lbl.AutoSize = true;
            dead_weight_lbl.Location = new Point(467, 6);
            dead_weight_lbl.Name = "dead_weight_lbl";
            dead_weight_lbl.Size = new Size(0, 32);
            dead_weight_lbl.TabIndex = 16;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(360, 45);
            label11.Name = "label11";
            label11.Size = new Size(97, 45);
            label11.TabIndex = 17;
            label11.Text = "Dead Weight LCG :";
            // 
            // dead_weight_lcg_lbl
            // 
            dead_weight_lcg_lbl.AutoSize = true;
            dead_weight_lcg_lbl.Location = new Point(467, 45);
            dead_weight_lcg_lbl.Name = "dead_weight_lcg_lbl";
            dead_weight_lcg_lbl.Size = new Size(0, 32);
            dead_weight_lcg_lbl.TabIndex = 18;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(360, 90);
            label12.Name = "label12";
            label12.Size = new Size(97, 45);
            label12.TabIndex = 19;
            label12.Text = "Dead Weight VCG :";
            // 
            // dead_weight_vcg_lbl
            // 
            dead_weight_vcg_lbl.Anchor = AnchorStyles.Left;
            dead_weight_vcg_lbl.AutoSize = true;
            dead_weight_vcg_lbl.Location = new Point(467, 96);
            dead_weight_vcg_lbl.Name = "dead_weight_vcg_lbl";
            dead_weight_vcg_lbl.Size = new Size(0, 32);
            dead_weight_vcg_lbl.TabIndex = 20;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(360, 135);
            label13.Name = "label13";
            label13.Size = new Size(97, 45);
            label13.TabIndex = 21;
            label13.Text = "Dead Weight TCG :";
            // 
            // dead_weight_tcg_lbl
            // 
            dead_weight_tcg_lbl.Anchor = AnchorStyles.Left;
            dead_weight_tcg_lbl.AutoSize = true;
            dead_weight_tcg_lbl.Location = new Point(467, 141);
            dead_weight_tcg_lbl.Name = "dead_weight_tcg_lbl";
            dead_weight_tcg_lbl.Size = new Size(0, 32);
            dead_weight_tcg_lbl.TabIndex = 22;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(360, 180);
            label14.Name = "label14";
            label14.Size = new Size(95, 45);
            label14.TabIndex = 23;
            label14.Text = "Displacement :";
            // 
            // displacement_lbl
            // 
            displacement_lbl.Anchor = AnchorStyles.Left;
            displacement_lbl.AutoSize = true;
            displacement_lbl.Location = new Point(467, 186);
            displacement_lbl.Name = "displacement_lbl";
            displacement_lbl.Size = new Size(0, 32);
            displacement_lbl.TabIndex = 24;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(360, 225);
            label15.Name = "label15";
            label15.Size = new Size(90, 45);
            label15.TabIndex = 25;
            label15.Text = "Displacement LCG :";
            // 
            // displacement_lcg_lbl
            // 
            displacement_lcg_lbl.Anchor = AnchorStyles.Left;
            displacement_lcg_lbl.AutoSize = true;
            displacement_lcg_lbl.Location = new Point(467, 231);
            displacement_lcg_lbl.Name = "displacement_lcg_lbl";
            displacement_lcg_lbl.Size = new Size(0, 32);
            displacement_lcg_lbl.TabIndex = 26;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(360, 270);
            label16.Name = "label16";
            label16.Size = new Size(90, 45);
            label16.TabIndex = 27;
            label16.Text = "Displacement LCG :";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(360, 315);
            label17.Name = "label17";
            label17.Size = new Size(90, 46);
            label17.TabIndex = 28;
            label17.Text = "Displacement TCG :";
            // 
            // displacement_tcg_lbl
            // 
            displacement_tcg_lbl.Anchor = AnchorStyles.Left;
            displacement_tcg_lbl.AutoSize = true;
            displacement_tcg_lbl.Location = new Point(467, 322);
            displacement_tcg_lbl.Name = "displacement_tcg_lbl";
            displacement_tcg_lbl.Size = new Size(0, 32);
            displacement_tcg_lbl.TabIndex = 29;
            // 
            // displacement_vcg_lbl
            // 
            displacement_vcg_lbl.Anchor = AnchorStyles.Left;
            displacement_vcg_lbl.AutoSize = true;
            displacement_vcg_lbl.Location = new Point(467, 276);
            displacement_vcg_lbl.Name = "displacement_vcg_lbl";
            displacement_vcg_lbl.Size = new Size(0, 32);
            displacement_vcg_lbl.TabIndex = 30;
            // 
            // dot_total_lbl
            // 
            dot_total_lbl.Anchor = AnchorStyles.Left;
            dot_total_lbl.AutoSize = true;
            dot_total_lbl.Location = new Point(110, 141);
            dot_total_lbl.Name = "dot_total_lbl";
            dot_total_lbl.Size = new Size(0, 32);
            dot_total_lbl.TabIndex = 31;
            // 
            // tank_list_view
            // 
            tank_list_view.AllowUserToAddRows = false;
            tank_list_view.AllowUserToDeleteRows = false;
            tank_list_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tank_list_view.BorderStyle = BorderStyle.Fixed3D;
            tank_list_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tank_list_view.Columns.AddRange(new DataGridViewColumn[] { TankName, MaxWeight, SPG, Weight, Volume, VolumePercenetage, LCG, VCG, TCG, FSM, FSMActual });
            tank_list_view.Dock = DockStyle.Fill;
            tank_list_view.Location = new Point(6, 110);
            tank_list_view.Margin = new Padding(6);
            tank_list_view.Name = "tank_list_view";
            tank_list_view.RowHeadersWidth = 82;
            tank_list_view.RowTemplate.Height = 25;
            tank_list_view.Size = new Size(715, 493);
            tank_list_view.TabIndex = 1;
            tank_list_view.CellValueChanged += tank_list_view_CellValueChanged;
            // 
            // TankName
            // 
            TankName.DataPropertyName = "TankName";
            TankName.Frozen = true;
            TankName.HeaderText = "Name";
            TankName.MinimumWidth = 10;
            TankName.Name = "TankName";
            TankName.ReadOnly = true;
            TankName.Width = 123;
            // 
            // MaxWeight
            // 
            MaxWeight.DataPropertyName = "MaxWeightForView";
            MaxWeight.HeaderText = "Max. Weight (T)";
            MaxWeight.MinimumWidth = 10;
            MaxWeight.Name = "MaxWeight";
            MaxWeight.ReadOnly = true;
            MaxWeight.Width = 226;
            // 
            // SPG
            // 
            SPG.DataPropertyName = "Permiability";
            SPG.HeaderText = "Spg.Gr.(T/m3)";
            SPG.MinimumWidth = 10;
            SPG.Name = "SPG";
            SPG.ReadOnly = true;
            SPG.Width = 204;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "WeightForView";
            Weight.HeaderText = "Wt.(T)";
            Weight.MinimumWidth = 10;
            Weight.Name = "Weight";
            Weight.Width = 121;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "VolumeForView";
            Volume.HeaderText = "Vol(m3)";
            Volume.MinimumWidth = 10;
            Volume.Name = "Volume";
            Volume.Width = 140;
            // 
            // VolumePercenetage
            // 
            VolumePercenetage.DataPropertyName = "VolumePercentageForView";
            VolumePercenetage.HeaderText = "Vol.(%)";
            VolumePercenetage.MinimumWidth = 10;
            VolumePercenetage.Name = "VolumePercenetage";
            VolumePercenetage.Width = 131;
            // 
            // LCG
            // 
            LCG.DataPropertyName = "LCGForView";
            LCG.HeaderText = "LCG(m)";
            LCG.MinimumWidth = 10;
            LCG.Name = "LCG";
            LCG.ReadOnly = true;
            LCG.Width = 134;
            // 
            // VCG
            // 
            VCG.DataPropertyName = "VCGForView";
            VCG.HeaderText = "VCG(m)";
            VCG.MinimumWidth = 10;
            VCG.Name = "VCG";
            VCG.ReadOnly = true;
            VCG.Width = 138;
            // 
            // TCG
            // 
            TCG.DataPropertyName = "TCGForView";
            TCG.HeaderText = "TCG(m)";
            TCG.MinimumWidth = 10;
            TCG.Name = "TCG";
            TCG.ReadOnly = true;
            TCG.Width = 136;
            // 
            // FSM
            // 
            FSM.DataPropertyName = "FSMForView";
            FSM.HeaderText = "FSM Val";
            FSM.MinimumWidth = 10;
            FSM.Name = "FSM";
            FSM.ReadOnly = true;
            FSM.Width = 144;
            // 
            // FSMActual
            // 
            FSMActual.HeaderText = "FSM";
            FSMActual.MinimumWidth = 10;
            FSMActual.Name = "FSMActual";
            FSMActual.ReadOnly = true;
            FSMActual.Width = 106;
            // 
            // LoadingView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoadingMainPanel);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoadingView";
            Size = new Size(1469, 1018);
            Load += LoadingView_Load;
            LoadingMainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tank_list_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LoadingMainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox liquid_master_list;
        private DataGridView tank_list_view;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label lightship_lbl_txt;
        private Label label3;
        private Label constant_total_lbl;
        private Label label5;
        private Label label4;
        private Label bwt_total_lbl;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label fot_total_lbl;
        private Label fwt_total_lbl;
        private Label misc_total_lbl;
        private Label liquid_cargo_total_lbl;
        private Label label10;
        private Label dead_weight_lbl;
        private Label label11;
        private Label dead_weight_lcg_lbl;
        private Label label12;
        private Label dead_weight_vcg_lbl;
        private Label label13;
        private Label dead_weight_tcg_lbl;
        private Label label14;
        private Label displacement_lbl;
        private Label label15;
        private Label displacement_lcg_lbl;
        private Label label16;
        private Label label17;
        private Label displacement_tcg_lbl;
        private Label displacement_vcg_lbl;
        private Label dot_total_lbl;
        private DataGridViewTextBoxColumn TankName;
        private DataGridViewTextBoxColumn MaxWeight;
        private DataGridViewTextBoxColumn SPG;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn VolumePercenetage;
        private DataGridViewTextBoxColumn LCG;
        private DataGridViewTextBoxColumn VCG;
        private DataGridViewTextBoxColumn TCG;
        private DataGridViewTextBoxColumn FSM;
        private DataGridViewTextBoxColumn FSMActual;
    }
}
