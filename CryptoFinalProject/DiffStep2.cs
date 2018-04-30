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
    public partial class DiffStep2 : Form
    {
        int CurrentStep = 1;
        public DiffStep2()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep == 9)
            {
                DiffStep3 diffStep3 = new DiffStep3();
                diffStep3.Tag = this;
                diffStep3.Show(this);
                Hide();

            }
            else
            {
                MessageBox.Show("You have not yet finished viewing each slide!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DiffStep1 diffStep1 = new DiffStep1();
            diffStep1.Tag = this;
            diffStep1.Show(this);
            Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void nextStepBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep < 9)
            {
                CurrentStep++;
                Image currentStepImage = Image.FromFile($@"Resources\ChoosingPlaintexts{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }

            if (CurrentStep == 9)
            {
                stepsCompleteLabel.Text = "Now all that we need to do is check all of the potential\n" +
                                          "keys that produce outputs that still satisfy our differential\n" +
                                          "rule! Answer some questions on the next page to finish\n" +
                                          "your task!";
            }
        }

        private void prevStepBtn_Click(object sender, EventArgs e)
        {
            if (CurrentStep > 1)
            {
                CurrentStep--;
                Image currentStepImage = Image.FromFile($@"Resources\ChoosingPlaintexts{CurrentStep}.png");
                K1GuessPicBox.Image.Dispose();
                K1GuessPicBox.Image = currentStepImage;
            }
        }
    }
}
