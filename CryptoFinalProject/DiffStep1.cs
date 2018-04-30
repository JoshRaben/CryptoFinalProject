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
    public partial class DiffStep1 : Form
    {
        bool isCorrect = false;
        public DiffStep1()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (isCorrect)//then proceed to next screen
            {
                DiffStep2 diffStep2 = new DiffStep2();
                diffStep2.Tag = this;
                diffStep2.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("You have not yet correctly answered the question!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DiffMission diffMission = new DiffMission();
            diffMission.Tag = this;
            diffMission.Show(this);
            Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            string currItem = ansListBox1.SelectedItem.ToString();
            if ((currItem == "(2, 4)   ->   6"))//if they picked one of the correct answers
            {   
                feedbackText.Text = "Correct! We want to choose the differentials that\n" +
                                    "the most of the input/output pairs produced. This way,\n" +
                                    "when we choose our plaintext, we can make to only choose\n" +
                                    "messages which also follows this pattern.";
                isCorrect = true;
            }
            else //they picked the wrong answer
            {
                feedbackText.Text = "Incorrect. Think again about what we are trying to accomplish\n" +
                                    "here. We are trying to identify  patterns that occur often while\n" +
                                    "using our S-Box. We want to maximize the amount of messages that\n" +
                                    "follow the certain pattern when we choose our plaintext in the later steps.";
                isCorrect = false;
            }
        }

        private void tableCreation_Click(object sender, EventArgs e)
        {
            DiffTableCreation diffTableCreation = new DiffTableCreation();
            diffTableCreation.Tag = this;
            diffTableCreation.Show(this);
            Hide();
        }

        private void ansListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < ansListBox1.Items.Count; ++i)
                if (i != e.Index) ansListBox1.SetItemChecked(i, false);
        }
    }
}
