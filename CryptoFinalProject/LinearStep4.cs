using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoFinalProject
{
    public partial class LinearStep4 : Form
    {
        public LinearStep4()
        {
            InitializeComponent();
            linearKeyPicBox.Image = Image.FromFile(@"Resources\KeyLinearHalf.png");
        }

        private void keyClaimBtn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }
    }
}
