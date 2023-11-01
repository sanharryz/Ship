namespace VesselLoader
{
    partial class IntactStabilityView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            graph_btn = new Button();
            heel_btn = new Button();
            trim_btn = new Button();
            all_btn = new Button();
            UserViewPanel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            trim_lbl = new Label();
            label2 = new Label();
            heel_lbl = new Label();
            label3 = new Label();
            displacement_lbl = new Label();
            label4 = new Label();
            lcg_lbl = new Label();
            label5 = new Label();
            tcg_lbl = new Label();
            label6 = new Label();
            vcg_lbl = new Label();
            label7 = new Label();
            draft_aft_lbl = new Label();
            label8 = new Label();
            draft_ms_lbl = new Label();
            label9 = new Label();
            draft_fwd_lbl = new Label();
            label10 = new Label();
            gm_fluid_lbl = new Label();
            label11 = new Label();
            gm_solid_lbl = new Label();
            label12 = new Label();
            fs_correction_lbl = new Label();
            label13 = new Label();
            vcg_correction_lbl = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Limit = new DataGridViewTextBoxColumn();
            MinMaxValue = new DataGridViewTextBoxColumn();
            Actual = new DataGridViewTextBoxColumn();
            Margin = new DataGridViewTextBoxColumn();
            Pass = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1464, 805);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(UserViewPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(872, 799);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(graph_btn);
            flowLayoutPanel1.Controls.Add(heel_btn);
            flowLayoutPanel1.Controls.Add(trim_btn);
            flowLayoutPanel1.Controls.Add(all_btn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(866, 73);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // graph_btn
            // 
            graph_btn.Dock = DockStyle.Fill;
            graph_btn.Location = new Point(3, 3);
            graph_btn.Name = "graph_btn";
            graph_btn.Size = new Size(150, 0);
            graph_btn.TabIndex = 0;
            graph_btn.Text = "GRAPH";
            graph_btn.UseVisualStyleBackColor = true;
            // 
            // heel_btn
            // 
            heel_btn.Dock = DockStyle.Fill;
            heel_btn.Location = new Point(159, 3);
            heel_btn.Name = "heel_btn";
            heel_btn.Size = new Size(150, 0);
            heel_btn.TabIndex = 1;
            heel_btn.Text = "HEEL";
            heel_btn.UseVisualStyleBackColor = true;
            heel_btn.Click += heel_btn_Click;
            // 
            // trim_btn
            // 
            trim_btn.Dock = DockStyle.Fill;
            trim_btn.Location = new Point(315, 3);
            trim_btn.Name = "trim_btn";
            trim_btn.Size = new Size(150, 0);
            trim_btn.TabIndex = 2;
            trim_btn.Text = "TRIM";
            trim_btn.UseVisualStyleBackColor = true;
            trim_btn.Click += trim_btn_Click;
            // 
            // all_btn
            // 
            all_btn.Dock = DockStyle.Fill;
            all_btn.Location = new Point(471, 3);
            all_btn.Name = "all_btn";
            all_btn.Size = new Size(150, 0);
            all_btn.TabIndex = 3;
            all_btn.Text = "ALL";
            all_btn.UseVisualStyleBackColor = true;
            all_btn.Click += all_btn_Click;
            // 
            // UserViewPanel
            // 
            UserViewPanel.Dock = DockStyle.Fill;
            UserViewPanel.Location = new Point(3, 82);
            UserViewPanel.Name = "UserViewPanel";
            UserViewPanel.Size = new Size(866, 714);
            UserViewPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(881, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(580, 799);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Equilibrium Condition Details";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(trim_lbl, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(heel_lbl, 1, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(displacement_lbl, 1, 2);
            tableLayoutPanel4.Controls.Add(label4, 0, 3);
            tableLayoutPanel4.Controls.Add(lcg_lbl, 1, 3);
            tableLayoutPanel4.Controls.Add(label5, 0, 4);
            tableLayoutPanel4.Controls.Add(tcg_lbl, 1, 4);
            tableLayoutPanel4.Controls.Add(label6, 0, 5);
            tableLayoutPanel4.Controls.Add(vcg_lbl, 1, 5);
            tableLayoutPanel4.Controls.Add(label7, 0, 6);
            tableLayoutPanel4.Controls.Add(draft_aft_lbl, 1, 6);
            tableLayoutPanel4.Controls.Add(label8, 2, 0);
            tableLayoutPanel4.Controls.Add(draft_ms_lbl, 3, 0);
            tableLayoutPanel4.Controls.Add(label9, 2, 1);
            tableLayoutPanel4.Controls.Add(draft_fwd_lbl, 3, 1);
            tableLayoutPanel4.Controls.Add(label10, 2, 2);
            tableLayoutPanel4.Controls.Add(gm_fluid_lbl, 3, 2);
            tableLayoutPanel4.Controls.Add(label11, 2, 3);
            tableLayoutPanel4.Controls.Add(gm_solid_lbl, 3, 3);
            tableLayoutPanel4.Controls.Add(label12, 2, 4);
            tableLayoutPanel4.Controls.Add(fs_correction_lbl, 3, 4);
            tableLayoutPanel4.Controls.Add(label13, 2, 5);
            tableLayoutPanel4.Controls.Add(vcg_correction_lbl, 3, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 35);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel4.Size = new Size(568, 155);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "Trim :";
            // 
            // trim_lbl
            // 
            trim_lbl.Anchor = AnchorStyles.Left;
            trim_lbl.AutoSize = true;
            trim_lbl.Location = new Point(116, 0);
            trim_lbl.Name = "trim_lbl";
            trim_lbl.Size = new Size(0, 22);
            trim_lbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 2;
            label2.Text = "Heel :";
            // 
            // heel_lbl
            // 
            heel_lbl.Anchor = AnchorStyles.Left;
            heel_lbl.AutoSize = true;
            heel_lbl.Location = new Point(116, 22);
            heel_lbl.Name = "heel_lbl";
            heel_lbl.Size = new Size(0, 22);
            heel_lbl.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 4;
            label3.Text = "Displacement :";
            // 
            // displacement_lbl
            // 
            displacement_lbl.Anchor = AnchorStyles.Left;
            displacement_lbl.AutoSize = true;
            displacement_lbl.Location = new Point(116, 44);
            displacement_lbl.Name = "displacement_lbl";
            displacement_lbl.Size = new Size(0, 22);
            displacement_lbl.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 6;
            label4.Text = "LCG :";
            // 
            // lcg_lbl
            // 
            lcg_lbl.Anchor = AnchorStyles.Left;
            lcg_lbl.AutoSize = true;
            lcg_lbl.Location = new Point(116, 66);
            lcg_lbl.Name = "lcg_lbl";
            lcg_lbl.Size = new Size(0, 22);
            lcg_lbl.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 88);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 8;
            label5.Text = "TCG :";
            // 
            // tcg_lbl
            // 
            tcg_lbl.Anchor = AnchorStyles.Left;
            tcg_lbl.AutoSize = true;
            tcg_lbl.Location = new Point(116, 88);
            tcg_lbl.Name = "tcg_lbl";
            tcg_lbl.Size = new Size(0, 22);
            tcg_lbl.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 110);
            label6.Name = "label6";
            label6.Size = new Size(70, 22);
            label6.TabIndex = 10;
            label6.Text = "VCG :";
            // 
            // vcg_lbl
            // 
            vcg_lbl.Anchor = AnchorStyles.Left;
            vcg_lbl.AutoSize = true;
            vcg_lbl.Location = new Point(116, 110);
            vcg_lbl.Name = "vcg_lbl";
            vcg_lbl.Size = new Size(0, 22);
            vcg_lbl.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 132);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 12;
            label7.Text = "Draft AFT :";
            // 
            // draft_aft_lbl
            // 
            draft_aft_lbl.Anchor = AnchorStyles.Left;
            draft_aft_lbl.AutoSize = true;
            draft_aft_lbl.Location = new Point(116, 132);
            draft_aft_lbl.Name = "draft_aft_lbl";
            draft_aft_lbl.Size = new Size(0, 23);
            draft_aft_lbl.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(286, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 14;
            label8.Text = "Draft MS :";
            // 
            // draft_ms_lbl
            // 
            draft_ms_lbl.Anchor = AnchorStyles.Left;
            draft_ms_lbl.AutoSize = true;
            draft_ms_lbl.Location = new Point(399, 0);
            draft_ms_lbl.Name = "draft_ms_lbl";
            draft_ms_lbl.Size = new Size(0, 22);
            draft_ms_lbl.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(286, 22);
            label9.Name = "label9";
            label9.Size = new Size(77, 22);
            label9.TabIndex = 16;
            label9.Text = "Draft FWD :";
            // 
            // draft_fwd_lbl
            // 
            draft_fwd_lbl.Anchor = AnchorStyles.Left;
            draft_fwd_lbl.AutoSize = true;
            draft_fwd_lbl.Location = new Point(399, 22);
            draft_fwd_lbl.Name = "draft_fwd_lbl";
            draft_fwd_lbl.Size = new Size(0, 22);
            draft_fwd_lbl.TabIndex = 17;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(286, 44);
            label10.Name = "label10";
            label10.Size = new Size(92, 22);
            label10.TabIndex = 18;
            label10.Text = "GM (Fluid) :";
            // 
            // gm_fluid_lbl
            // 
            gm_fluid_lbl.Anchor = AnchorStyles.Left;
            gm_fluid_lbl.AutoSize = true;
            gm_fluid_lbl.Location = new Point(399, 44);
            gm_fluid_lbl.Name = "gm_fluid_lbl";
            gm_fluid_lbl.Size = new Size(0, 22);
            gm_fluid_lbl.TabIndex = 19;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(286, 66);
            label11.Name = "label11";
            label11.Size = new Size(93, 22);
            label11.TabIndex = 20;
            label11.Text = "GM (Solid) :";
            // 
            // gm_solid_lbl
            // 
            gm_solid_lbl.Anchor = AnchorStyles.Left;
            gm_solid_lbl.AutoSize = true;
            gm_solid_lbl.Location = new Point(399, 66);
            gm_solid_lbl.Name = "gm_solid_lbl";
            gm_solid_lbl.Size = new Size(0, 22);
            gm_solid_lbl.TabIndex = 21;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(286, 88);
            label12.Name = "label12";
            label12.Size = new Size(97, 22);
            label12.TabIndex = 22;
            label12.Text = "FS Correction :";
            // 
            // fs_correction_lbl
            // 
            fs_correction_lbl.Anchor = AnchorStyles.Left;
            fs_correction_lbl.AutoSize = true;
            fs_correction_lbl.Location = new Point(399, 88);
            fs_correction_lbl.Name = "fs_correction_lbl";
            fs_correction_lbl.Size = new Size(0, 22);
            fs_correction_lbl.TabIndex = 23;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(286, 110);
            label13.Name = "label13";
            label13.Size = new Size(97, 22);
            label13.TabIndex = 24;
            label13.Text = "VCG Correction :";
            // 
            // vcg_correction_lbl
            // 
            vcg_correction_lbl.Anchor = AnchorStyles.Left;
            vcg_correction_lbl.AutoSize = true;
            vcg_correction_lbl.Location = new Point(399, 110);
            vcg_correction_lbl.Name = "vcg_correction_lbl";
            vcg_correction_lbl.Size = new Size(0, 22);
            vcg_correction_lbl.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 193);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Intact Criteria";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Limit, MinMaxValue, Actual, Margin, Pass });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(568, 155);
            dataGridView1.TabIndex = 0;
            // 
            // Limit
            // 
            Limit.DataPropertyName = "Limit";
            Limit.HeaderText = "Limit";
            Limit.MinimumWidth = 10;
            Limit.Name = "Limit";
            Limit.ReadOnly = true;
            // 
            // MinMaxValue
            // 
            MinMaxValue.DataPropertyName = "MinMaxValue";
            MinMaxValue.HeaderText = "Min/Max Value";
            MinMaxValue.MinimumWidth = 10;
            MinMaxValue.Name = "MinMaxValue";
            MinMaxValue.ReadOnly = true;
            // 
            // Actual
            // 
            Actual.DataPropertyName = "Actual";
            Actual.HeaderText = "Actual";
            Actual.MinimumWidth = 10;
            Actual.Name = "Actual";
            Actual.ReadOnly = true;
            // 
            // Margin
            // 
            Margin.DataPropertyName = "Margin";
            Margin.HeaderText = "Margin";
            Margin.MinimumWidth = 10;
            Margin.Name = "Margin";
            Margin.ReadOnly = true;
            // 
            // Pass
            // 
            Pass.DataPropertyName = "Pass";
            Pass.HeaderText = "Pass";
            Pass.MinimumWidth = 10;
            Pass.Name = "Pass";
            Pass.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 401);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(574, 193);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wind Criteria";
            // 
            // groupBox4
            // 
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 600);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(574, 196);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Errors and Warnings";
            // 
            // IntactStabilityView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "IntactStabilityView";
            Size = new Size(1464, 805);
            Load += IntactStabilityView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button graph_btn;
        private Button heel_btn;
        private Button trim_btn;
        private Button all_btn;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label trim_lbl;
        private Label label2;
        private Label heel_lbl;
        private Label label3;
        private Label displacement_lbl;
        private Label label4;
        private Label lcg_lbl;
        private Label label5;
        private Label tcg_lbl;
        private Label label6;
        private Label vcg_lbl;
        private Label label7;
        private Label draft_aft_lbl;
        private Label label8;
        private Label draft_ms_lbl;
        private Label label9;
        private Label draft_fwd_lbl;
        private Label label10;
        private Label gm_fluid_lbl;
        private Label label11;
        private Label gm_solid_lbl;
        private Label label12;
        private Label fs_correction_lbl;
        private Label label13;
        private Label vcg_correction_lbl;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Limit;
        private DataGridViewTextBoxColumn MinMaxValue;
        private DataGridViewTextBoxColumn Actual;
        private DataGridViewTextBoxColumn Margin;
        private DataGridViewTextBoxColumn Pass;
        private Panel UserViewPanel;
    }
}
