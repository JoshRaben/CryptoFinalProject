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
    
    public partial class LinearStep1 : Form
    {
        bool isCorrect = false;
        public LinearStep1()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (isCorrect)//then proceed to next screen
            {
                LinearStep2 linearStep2 = new LinearStep2();
                linearStep2.Tag = this;
                linearStep2.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("You have not yet correctly answered the question!");
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            LinearHome linearHome = new LinearHome();
            linearHome.Tag = this;
            linearHome.Show(this);
            Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void tableCreation_Click(object sender, EventArgs e)
        {
            TableCreation tableCreation = new TableCreation();
            tableCreation.Tag = this;
            tableCreation.Show(this);
            Hide();
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            string currItem = ansListBox1.SelectedItem.ToString();
            if ((currItem == "(4, 4)   ->   9") || (currItem == "(2, 2)   ->   1"))//if they picked one of the correct answers
            {
                feedbackText.Text = "Correct! The most optimal masks displayed on the table\n" +
                                    "are (4, 4) and (2, 2), because they parities they produced\n" +
                                    "out of the 10 samples were the furthest from 50%.";
                isCorrect = true;
            }
            else //they picked the wrong answer
            {
                feedbackText.Text = "Incorrect. Remember, we want our masks to make the \n" +
                                    "parities of the texts to seem 'random'.";
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
