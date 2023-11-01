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
    public partial class IntactTrimView : UserControl
    {
        private float _trimAngle = 0.0f;
        public IntactTrimView(float trimAngle)
        {
            InitializeComponent();
            _trimAngle = trimAngle;
        }

        private void IntactTrimView_Load(object sender, EventArgs e)
        {
            Image img = Helper.ImageProcessing.putOverLayerOnImage(Helper.ImageProcessing.RotateImage(
                Image.FromFile(@"Resources\TrimImage.jpg"), _trimAngle));
            intact_trim_pic_box.Image = img;
            intact_trim_pic_box.Update();
        }
    }
}
