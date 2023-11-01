namespace VesselLoader
{
    partial class IntactTrimView
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
            intact_trim_pic_box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)intact_trim_pic_box).BeginInit();
            SuspendLayout();
            // 
            // intact_trim_pic_box
            // 
            intact_trim_pic_box.Dock = DockStyle.Fill;
            intact_trim_pic_box.Location = new Point(0, 0);
            intact_trim_pic_box.Name = "intact_trim_pic_box";
            intact_trim_pic_box.Size = new Size(810, 668);
            intact_trim_pic_box.SizeMode = PictureBoxSizeMode.StretchImage;
            intact_trim_pic_box.TabIndex = 0;
            intact_trim_pic_box.TabStop = false;
            // 
            // IntactTrimView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(intact_trim_pic_box);
            Name = "IntactTrimView";
            Size = new Size(810, 668);
            Load += IntactTrimView_Load;
            ((System.ComponentModel.ISupportInitialize)intact_trim_pic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox intact_trim_pic_box;
    }
}
