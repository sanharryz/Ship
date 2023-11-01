namespace VesselLoader
{
    partial class IntactHeelView
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
            Intact_Heel_pic_box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Intact_Heel_pic_box).BeginInit();
            SuspendLayout();
            // 
            // Intact_Heel_pic_box
            // 
            Intact_Heel_pic_box.Dock = DockStyle.Fill;
            Intact_Heel_pic_box.Location = new Point(0, 0);
            Intact_Heel_pic_box.Name = "Intact_Heel_pic_box";
            Intact_Heel_pic_box.Size = new Size(1260, 920);
            Intact_Heel_pic_box.SizeMode = PictureBoxSizeMode.StretchImage;
            Intact_Heel_pic_box.TabIndex = 0;
            Intact_Heel_pic_box.TabStop = false;
            // 
            // IntactHeelView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Intact_Heel_pic_box);
            Name = "IntactHeelView";
            Size = new Size(1260, 920);
            Load += IntactHeelView_Load;
            ((System.ComponentModel.ISupportInitialize)Intact_Heel_pic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Intact_Heel_pic_box;
    }
}
