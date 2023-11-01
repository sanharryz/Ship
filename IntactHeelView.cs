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
    public partial class IntactHeelView : UserControl
    {
        private float _heelAngle = 0.0f;
        public IntactHeelView(float heelAngle)
        {
            InitializeComponent();
            _heelAngle = heelAngle;
        }

        private void IntactHeelView_Load(object sender, EventArgs e)
        {
            Image img = Helper.ImageProcessing.putOverLayerOnImage(Helper.ImageProcessing.RotateImage(
                Image.FromFile(@"Resources\HeelImage.jpg"), _heelAngle));

            Intact_Heel_pic_box.Image = img;
            Intact_Heel_pic_box.Update();
        }
    }
}
