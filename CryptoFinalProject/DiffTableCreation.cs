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
    public partial class DiffTableCreation : Form
    {
        int CurrentStep = 1;

        public DiffTableCreation()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            DiffStep1 diffStep1 = new DiffStep1();
            diffStep1.Tag = this;
            diffStep1.Show(this);
            Hide();
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
            if (CurrentStep < 5)
            {
                CurrentStep++;
                Image currentStepImage = Image.FromFile($@"Resources\DifferentialTableCreation{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep > 1)
            {
                CurrentStep--;
                Image currentStepImage = Image.FromFile($@"Resources\DifferentialTableCreation{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }
        }
    }
}
