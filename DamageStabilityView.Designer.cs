namespace VesselLoader
{
    partial class DamageStabilityView
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
            groupBox1 = new GroupBox();
            detailed_report_list_view = new ListView();
            Description = new ColumnHeader();
            Value = new ColumnHeader();
            groupBox2 = new GroupBox();
            damage_criteria_list_view = new ListView();
            Limit = new ColumnHeader();
            MinMax = new ColumnHeader();
            Actual = new ColumnHeader();
            Margin = new ColumnHeader();
            Status = new ColumnHeader();
            damage_case_list_view = new ListView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(damage_case_list_view, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1328, 801);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(268, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1057, 795);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(detailed_report_list_view);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deatiled Report";
            // 
            // detailed_report_list_view
            // 
            detailed_report_list_view.Columns.AddRange(new ColumnHeader[] { Description, Value });
            detailed_report_list_view.Dock = DockStyle.Fill;
            detailed_report_list_view.GridLines = true;
            detailed_report_list_view.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            detailed_report_list_view.Location = new Point(3, 35);
            detailed_report_list_view.MultiSelect = false;
            detailed_report_list_view.Name = "detailed_report_list_view";
            detailed_report_list_view.OwnerDraw = true;
            detailed_report_list_view.Size = new Size(1045, 353);
            detailed_report_list_view.TabIndex = 0;
            detailed_report_list_view.UseCompatibleStateImageBehavior = false;
            detailed_report_list_view.View = View.Details;
            detailed_report_list_view.DrawColumnHeader += detailed_report_list_view_DrawColumnHeader;
            detailed_report_list_view.DrawItem += detailed_report_list_view_DrawItem;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 550;
            // 
            // Value
            // 
            Value.Text = "Value";
            Value.TextAlign = HorizontalAlignment.Center;
            Value.Width = 2000;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(damage_criteria_list_view);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1051, 392);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Damaged Case Criteria";
            // 
            // damage_criteria_list_view
            // 
            damage_criteria_list_view.Columns.AddRange(new ColumnHeader[] { Limit, MinMax, Actual, Margin, Status });
            damage_criteria_list_view.Dock = DockStyle.Fill;
            damage_criteria_list_view.GridLines = true;
            damage_criteria_list_view.Location = new Point(3, 35);
            damage_criteria_list_view.Name = "damage_criteria_list_view";
            damage_criteria_list_view.OwnerDraw = true;
            damage_criteria_list_view.Size = new Size(1045, 354);
            damage_criteria_list_view.TabIndex = 0;
            damage_criteria_list_view.UseCompatibleStateImageBehavior = false;
            damage_criteria_list_view.View = View.Details;
            damage_criteria_list_view.DrawColumnHeader += damage_criteria_list_view_DrawColumnHeader;
            damage_criteria_list_view.DrawItem += damage_criteria_list_view_DrawItem;
            // 
            // Limit
            // 
            Limit.Text = "Limit";
            Limit.Width = 500;
            // 
            // MinMax
            // 
            MinMax.Text = "Min/Max";
            MinMax.TextAlign = HorizontalAlignment.Center;
            MinMax.Width = 450;
            // 
            // Actual
            // 
            Actual.Text = "Actual";
            Actual.TextAlign = HorizontalAlignment.Center;
            Actual.Width = 450;
            // 
            // Margin
            // 
            Margin.Text = "Margin";
            Margin.TextAlign = HorizontalAlignment.Center;
            Margin.Width = 450;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 450;
            // 
            // damage_case_list_view
            // 
            damage_case_list_view.Dock = DockStyle.Fill;
            damage_case_list_view.FullRowSelect = true;
            damage_case_list_view.GridLines = true;
            damage_case_list_view.Location = new Point(3, 3);
            damage_case_list_view.Name = "damage_case_list_view";
            damage_case_list_view.Size = new Size(259, 795);
            damage_case_list_view.TabIndex = 1;
            damage_case_list_view.UseCompatibleStateImageBehavior = false;
            damage_case_list_view.ItemSelectionChanged += damage_case_list_view_ItemSelectionChanged;
            damage_case_list_view.Click += damage_case_list_view_Click;
            // 
            // DamageStabilityView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DamageStabilityView";
            Size = new Size(1328, 801);
            Load += DamageStabilityView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView damage_case_list_view;
        private ListView detailed_report_list_view;
        private ListView damage_criteria_list_view;
        private ColumnHeader Description;
        private ColumnHeader Value;
        private ColumnHeader Limit;
        private ColumnHeader MinMax;
        private ColumnHeader Actual;
        private ColumnHeader Margin;
        private ColumnHeader Status;
    }
}
