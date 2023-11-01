namespace VesselLoader
{
    partial class LongitudnaStrengthView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            max_shear_val_lbl = new Label();
            label2 = new Label();
            max_shear_location_val_lbl = new Label();
            label3 = new Label();
            min_shear_val_lbl = new Label();
            label4 = new Label();
            min_shear_location_val_lbl = new Label();
            label5 = new Label();
            max_bending_moment_val_lbl = new Label();
            label6 = new Label();
            max_bending_moment_location_val_lbl = new Label();
            label7 = new Label();
            min_bending_moment_val_lbl = new Label();
            label8 = new Label();
            min_bending_moment_location_val_lbl = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            FrameNumber = new DataGridViewTextBoxColumn();
            FrameDistance = new DataGridViewTextBoxColumn();
            ShearForce = new DataGridViewTextBoxColumn();
            ShearForcePercentage = new DataGridViewTextBoxColumn();
            BendingMoment = new DataGridViewTextBoxColumn();
            BendingMomentPercentage = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(chart1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(869, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(611, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(255, 644);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LS Summary";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(max_shear_val_lbl, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(max_shear_location_val_lbl, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(min_shear_val_lbl, 1, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(min_shear_location_val_lbl, 1, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(max_bending_moment_val_lbl, 1, 4);
            tableLayoutPanel3.Controls.Add(label6, 0, 5);
            tableLayoutPanel3.Controls.Add(max_bending_moment_location_val_lbl, 1, 5);
            tableLayoutPanel3.Controls.Add(label7, 0, 6);
            tableLayoutPanel3.Controls.Add(min_bending_moment_val_lbl, 1, 6);
            tableLayoutPanel3.Controls.Add(label8, 0, 7);
            tableLayoutPanel3.Controls.Add(min_bending_moment_location_val_lbl, 1, 7);
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
            tableLayoutPanel3.Size = new Size(243, 170);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Max Shear";
            // 
            // max_shear_val_lbl
            // 
            max_shear_val_lbl.Anchor = AnchorStyles.Right;
            max_shear_val_lbl.AutoSize = true;
            max_shear_val_lbl.Location = new Point(240, 0);
            max_shear_val_lbl.Name = "max_shear_val_lbl";
            max_shear_val_lbl.Size = new Size(0, 21);
            max_shear_val_lbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 2;
            label2.Text = "Max. Shear Location";
            // 
            // max_shear_location_val_lbl
            // 
            max_shear_location_val_lbl.Anchor = AnchorStyles.Right;
            max_shear_location_val_lbl.AutoSize = true;
            max_shear_location_val_lbl.Location = new Point(240, 21);
            max_shear_location_val_lbl.Name = "max_shear_location_val_lbl";
            max_shear_location_val_lbl.Size = new Size(0, 21);
            max_shear_location_val_lbl.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "Min. Shear";
            // 
            // min_shear_val_lbl
            // 
            min_shear_val_lbl.Anchor = AnchorStyles.Right;
            min_shear_val_lbl.AutoSize = true;
            min_shear_val_lbl.Location = new Point(240, 42);
            min_shear_val_lbl.Name = "min_shear_val_lbl";
            min_shear_val_lbl.Size = new Size(0, 21);
            min_shear_val_lbl.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 63);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 6;
            label4.Text = "Min. Shear Location";
            // 
            // min_shear_location_val_lbl
            // 
            min_shear_location_val_lbl.Anchor = AnchorStyles.Right;
            min_shear_location_val_lbl.AutoSize = true;
            min_shear_location_val_lbl.Location = new Point(240, 63);
            min_shear_location_val_lbl.Name = "min_shear_location_val_lbl";
            min_shear_location_val_lbl.Size = new Size(0, 21);
            min_shear_location_val_lbl.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 8;
            label5.Text = "Max. Bending Moment";
            // 
            // max_bending_moment_val_lbl
            // 
            max_bending_moment_val_lbl.Anchor = AnchorStyles.Right;
            max_bending_moment_val_lbl.AutoSize = true;
            max_bending_moment_val_lbl.Location = new Point(240, 84);
            max_bending_moment_val_lbl.Name = "max_bending_moment_val_lbl";
            max_bending_moment_val_lbl.Size = new Size(0, 21);
            max_bending_moment_val_lbl.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 105);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 10;
            label6.Text = "Max. Bending Moment Location";
            // 
            // max_bending_moment_location_val_lbl
            // 
            max_bending_moment_location_val_lbl.Anchor = AnchorStyles.Right;
            max_bending_moment_location_val_lbl.AutoSize = true;
            max_bending_moment_location_val_lbl.Location = new Point(240, 105);
            max_bending_moment_location_val_lbl.Name = "max_bending_moment_location_val_lbl";
            max_bending_moment_location_val_lbl.Size = new Size(0, 21);
            max_bending_moment_location_val_lbl.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 126);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 12;
            label7.Text = "Min. Bending Moment";
            // 
            // min_bending_moment_val_lbl
            // 
            min_bending_moment_val_lbl.Anchor = AnchorStyles.Right;
            min_bending_moment_val_lbl.AutoSize = true;
            min_bending_moment_val_lbl.Location = new Point(240, 126);
            min_bending_moment_val_lbl.Name = "min_bending_moment_val_lbl";
            min_bending_moment_val_lbl.Size = new Size(0, 21);
            min_bending_moment_val_lbl.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 147);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 14;
            label8.Text = "Min. Bending Moment Location";
            // 
            // min_bending_moment_location_val_lbl
            // 
            min_bending_moment_location_val_lbl.Anchor = AnchorStyles.Right;
            min_bending_moment_location_val_lbl.AutoSize = true;
            min_bending_moment_location_val_lbl.Location = new Point(240, 147);
            min_bending_moment_location_val_lbl.Name = "min_bending_moment_location_val_lbl";
            min_bending_moment_location_val_lbl.Size = new Size(0, 23);
            min_bending_moment_location_val_lbl.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "LS Calculation";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FrameNumber, FrameDistance, ShearForce, ShearForcePercentage, BendingMoment, BendingMomentPercentage });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(243, 170);
            dataGridView1.TabIndex = 1;
            // 
            // FrameNumber
            // 
            FrameNumber.DataPropertyName = "FrameNumber";
            FrameNumber.HeaderText = "Frame No.";
            FrameNumber.MinimumWidth = 10;
            FrameNumber.Name = "FrameNumber";
            FrameNumber.ReadOnly = true;
            // 
            // FrameDistance
            // 
            FrameDistance.DataPropertyName = "FrameDistance";
            FrameDistance.HeaderText = "Frame Distance";
            FrameDistance.MinimumWidth = 10;
            FrameDistance.Name = "FrameDistance";
            FrameDistance.ReadOnly = true;
            // 
            // ShearForce
            // 
            ShearForce.DataPropertyName = "ShearForce";
            ShearForce.HeaderText = "Shear Force (T)";
            ShearForce.MinimumWidth = 10;
            ShearForce.Name = "ShearForce";
            ShearForce.ReadOnly = true;
            // 
            // ShearForcePercentage
            // 
            ShearForcePercentage.DataPropertyName = "ShearForcePercentage";
            ShearForcePercentage.HeaderText = "Shear Force (%)";
            ShearForcePercentage.MinimumWidth = 10;
            ShearForcePercentage.Name = "ShearForcePercentage";
            ShearForcePercentage.ReadOnly = true;
            // 
            // BendingMoment
            // 
            BendingMoment.DataPropertyName = "BendingMoment";
            BendingMoment.HeaderText = "Bending Moment (T-m)";
            BendingMoment.MinimumWidth = 10;
            BendingMoment.Name = "BendingMoment";
            BendingMoment.ReadOnly = true;
            // 
            // BendingMomentPercentage
            // 
            BendingMomentPercentage.DataPropertyName = "BendingMomentPercentage";
            BendingMomentPercentage.HeaderText = "Bending Moment (%)";
            BendingMomentPercentage.MinimumWidth = 10;
            BendingMomentPercentage.Name = "BendingMomentPercentage";
            BendingMomentPercentage.ReadOnly = true;
            // 
            // chart1
            // 
            chart1.BorderlineColor = Color.Black;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            chart1.Size = new Size(602, 644);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            chart1.Visible = false;
            // 
            // LongitudnaStrengthView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LongitudnaStrengthView";
            Size = new Size(869, 650);
            Load += LongitudnaStrengthView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label max_shear_val_lbl;
        private Label label2;
        private Label max_shear_location_val_lbl;
        private Label label3;
        private Label min_shear_val_lbl;
        private Label label4;
        private Label min_shear_location_val_lbl;
        private Label label5;
        private Label max_bending_moment_val_lbl;
        private Label label6;
        private Label max_bending_moment_location_val_lbl;
        private Label label7;
        private Label min_bending_moment_val_lbl;
        private Label label8;
        private Label min_bending_moment_location_val_lbl;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FrameNumber;
        private DataGridViewTextBoxColumn FrameDistance;
        private DataGridViewTextBoxColumn ShearForce;
        private DataGridViewTextBoxColumn ShearForcePercentage;
        private DataGridViewTextBoxColumn BendingMoment;
        private DataGridViewTextBoxColumn BendingMomentPercentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
