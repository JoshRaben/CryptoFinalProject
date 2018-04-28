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
            infoText.Text = "Congratulations! You've successfully made your way though Linear\n" +
                            "Cryptanalysis! Here is the secret key needed to pass through to the\n" +
                            "final secret. Make sure you write this key down.";
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
