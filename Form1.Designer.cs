namespace VesselLoader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            vessel_info_btn = new Button();
            fixed_weight_btn = new Button();
            loading_btn = new Button();
            intact_btn = new Button();
            damage_stability_btn = new Button();
            logitudnal_strength_btn = new Button();
            settings_btn = new Button();
            MainPanel = new Panel();
            exit_btn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(vessel_info_btn);
            flowLayoutPanel1.Controls.Add(fixed_weight_btn);
            flowLayoutPanel1.Controls.Add(loading_btn);
            flowLayoutPanel1.Controls.Add(intact_btn);
            flowLayoutPanel1.Controls.Add(damage_stability_btn);
            flowLayoutPanel1.Controls.Add(logitudnal_strength_btn);
            flowLayoutPanel1.Controls.Add(settings_btn);
            flowLayoutPanel1.Controls.Add(exit_btn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2014, 220);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // vessel_info_btn
            // 
            vessel_info_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            vessel_info_btn.Location = new Point(4, 2);
            vessel_info_btn.Margin = new Padding(4, 2, 4, 2);
            vessel_info_btn.Name = "vessel_info_btn";
            vessel_info_btn.Size = new Size(204, 209);
            vessel_info_btn.TabIndex = 0;
            vessel_info_btn.Text = "Info";
            vessel_info_btn.UseVisualStyleBackColor = true;
            vessel_info_btn.Click += vessel_info_btn_Click;
            // 
            // fixed_weight_btn
            // 
            fixed_weight_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fixed_weight_btn.Location = new Point(216, 2);
            fixed_weight_btn.Margin = new Padding(4, 2, 4, 2);
            fixed_weight_btn.Name = "fixed_weight_btn";
            fixed_weight_btn.Size = new Size(204, 209);
            fixed_weight_btn.TabIndex = 3;
            fixed_weight_btn.Text = "Fixed Weight";
            fixed_weight_btn.UseVisualStyleBackColor = true;
            fixed_weight_btn.Click += fixed_weight_btn_Click;
            // 
            // loading_btn
            // 
            loading_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loading_btn.Location = new Point(428, 2);
            loading_btn.Margin = new Padding(4, 2, 4, 2);
            loading_btn.Name = "loading_btn";
            loading_btn.Size = new Size(204, 209);
            loading_btn.TabIndex = 2;
            loading_btn.Text = "Loading";
            loading_btn.UseVisualStyleBackColor = true;
            loading_btn.Click += loading_btn_Click;
            // 
            // intact_btn
            // 
            intact_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            intact_btn.Location = new Point(640, 2);
            intact_btn.Margin = new Padding(4, 2, 4, 2);
            intact_btn.Name = "intact_btn";
            intact_btn.Size = new Size(204, 209);
            intact_btn.TabIndex = 4;
            intact_btn.Text = "Intact Stability";
            intact_btn.UseVisualStyleBackColor = true;
            intact_btn.Click += intact_btn_Click;
            // 
            // damage_stability_btn
            // 
            damage_stability_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            damage_stability_btn.Location = new Point(852, 2);
            damage_stability_btn.Margin = new Padding(4, 2, 4, 2);
            damage_stability_btn.Name = "damage_stability_btn";
            damage_stability_btn.Size = new Size(204, 209);
            damage_stability_btn.TabIndex = 6;
            damage_stability_btn.Text = "Damage Stability";
            damage_stability_btn.UseVisualStyleBackColor = true;
            damage_stability_btn.Click += damage_stability_btn_Click;
            // 
            // logitudnal_strength_btn
            // 
            logitudnal_strength_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logitudnal_strength_btn.Location = new Point(1064, 2);
            logitudnal_strength_btn.Margin = new Padding(4, 2, 4, 2);
            logitudnal_strength_btn.Name = "logitudnal_strength_btn";
            logitudnal_strength_btn.Size = new Size(204, 209);
            logitudnal_strength_btn.TabIndex = 5;
            logitudnal_strength_btn.Text = "Longitudnal Strength";
            logitudnal_strength_btn.UseVisualStyleBackColor = true;
            logitudnal_strength_btn.Click += logitudnal_strength_btn_Click;
            // 
            // settings_btn
            // 
            settings_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            settings_btn.Location = new Point(1276, 2);
            settings_btn.Margin = new Padding(4, 2, 4, 2);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(204, 209);
            settings_btn.TabIndex = 1;
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 220);
            MainPanel.Margin = new Padding(4, 2, 4, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(2014, 721);
            MainPanel.TabIndex = 3;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exit_btn.Location = new Point(1488, 2);
            exit_btn.Margin = new Padding(4, 2, 4, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(204, 209);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2014, 941);
            Controls.Add(MainPanel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Vessel Loader V1.0";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button vessel_info_btn;
        private Button settings_btn;
        private Panel MainPanel;
        private Button loading_btn;
        private Button fixed_weight_btn;
        private Button intact_btn;
        private Button logitudnal_strength_btn;
        private Button damage_stability_btn;
        private Button exit_btn;
    }
}