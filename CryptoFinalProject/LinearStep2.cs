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
    public partial class LinearStep2 : Form
    {
        int CurrentStep = 1;
        public LinearStep2()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep < 6)
            {
                CurrentStep++;
                Image currentStepImage = Image.FromFile($@"Resources\Linear_K1Guess_Step{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep > 1)
            {
                CurrentStep--;
                Image currentStepImage = Image.FromFile($@"Resources\Linear_K1Guess_Step{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            LinearStep1 linearStep1 = new LinearStep1();
            linearStep1.Tag = this;
            linearStep1.Show(this);
            Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            LinearStep3 linearStep3 = new LinearStep3();
            linearStep3.Tag = this;
            linearStep3.Show(this);
            Hide();
        }
    }
}
