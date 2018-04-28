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
    public partial class LinearStep3 : Form
    {
        bool isCorrect = false;
        public LinearStep3()
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

        private void back_Click(object sender, EventArgs e)
        {
            LinearStep2 linearStep2 = new LinearStep2();
            linearStep2.Tag = this;
            linearStep2.Show(this);
            Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (isCorrect)
            {
                LinearStep4 linearStep4 = new LinearStep4();
                linearStep4.Tag = this;
                linearStep4.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("You have not yet correctly answered the question!");
            }
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            string currItem = ansListBox1.SelectedItem.ToString();
            if (currItem == "Use the known ciphertext, the S-box, and M to calculate a guessed K2.")//if they picked the correct answer
            {
                feedbackText.Text = "Correct! We have all of the information we need to \n" +
                                    "efficiently calcuate a guess at K2. We know P, M, K1,\n" +
                                    "C, and how the S-Box works.";
                infoText2.Text = "Now to confirm that the K1 and K2 you picked are correct,\n" +
                                 "simply run through the entire process of encrypting the\n" +
                                 "plaintext through both rounds. If it ends up not working,\n" +
                                 "simply repeat the process on the previous slide for the \n" +
                                 "next likely key.";
                isCorrect = true;
            }
            else if (currItem == "Brute force K2 as previously running through every possible value using the masks.")
            {
                feedbackText.Text = "Incorrect. This is an unnecessary waste of time. Try to \n" +
                                    "think of a better way of using our current information to\n" +
                                    "easily figure out K2.";
                isCorrect = false;
            }
            else if (currItem == "Re-calculate the approximation table, except now using 'M' as the plaintext.")
            {
                feedbackText.Text = "Incorrect. Remember that our approximation table should hold\n" +
                                    "for ANY plantexts we throw at it, because our S-Box did not \n" +
                                    "change. Also, try to think of the information we currently\n" +
                                    "know and see if you can easily derive K2.";
                isCorrect = false;
            }
            else if (currItem == "Send multiple strings through the S-Box to try to gain more information about it.")
            {
                feedbackText.Text = "Incorrect. Remember that we already know all of the information\n" +
                                    "about how the S-Box works! Try to think of the information we\n" +
                                    "currently know and see if you can easily derive K2.";
                isCorrect = false;
            }
        }

        private void ansListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < ansListBox1.Items.Count; ++i)
                if (i != e.Index) ansListBox1.SetItemChecked(i, false);
        }
    }
}
