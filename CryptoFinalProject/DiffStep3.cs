using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Collections;

namespace CryptoFinalProject
{
    public partial class DiffStep3 : Form
    {
        bool ans1Correct = false;
        bool ans2Correct = false;
        bool ans3Correct = false;
        int CurrQuestion = 0;
        string[] question1Answers = { "It reduces the possible amount of keys we need to check, as only a certain amount of keys will\n" +
                                      "give us values that hold true to the differential rule we are holding (that the input differential = 2,\n" +
                                      "and the output differential = 4).",
                                      "It gives us all the information to calculate the keys. All we have to do is simply plug our chosen plaintext and\n" +
                                      "ciphertext into a 'calculator' and it will give us the only two possible keys.",
                                      "We can use our knowledge gained from finding the good candidate to learn more about how the S-Box functions." };

        string[] question2Answers = { "It doesn't, we still have to brute force every possible key.",
            "It does, by reducing the amount of possible keys that could give us values that satisfy our differential rule.",
            "It does, through linearization of the S-Box." };

        string[] question3Answers = { "This particular property does not get affected by the adding of the round key.",
            "This particular property does not get affected by the S-Box.",
            "The differential of the two plaintexts XOR'd to the  differential of the two ciphertexts is the key." };

        string[] question1Feedback = { "Correct!", "Incorrect. Now that we have a good candidate for the chosen plaintext," +
                                                   "we have 'reduced' the amount of possible correct keys. The only way to check" +
                                                   "which key is the correct one is to go through all of the choices to see which" +
                                                   "ones hold true our differential rule. After you find a pair of keys, run through" +
                                                   "the whole algorithm with the keys to see if the outputs match what we found out" +
                                                   "earlier.",
                                                   "Incorrect. Remember that we already know what is going on inside the S-Box! We are" +
                                                   "now trying to figure out the keys that are being used in the encryption algorithm we" +
                                                   "are trying to break." };

        string[] question2Feedback = { "Incorrect. From the information learned from the differential table, we can reduce the amount of" +
                                       "potential keys we need to check to ensure that our differential rule holds true.",
                                       "Correct! Furthermore, if we had an encryption algorithm that had more rounds to it (or larger keys)," +
                                       "the time saved would be exponential, as the amount of time it would take to brute force every key in a" +
                                       "more complicated algorithm would be extremely long.",
                                        "Incorrect. Remember that this cryptanalysis method is about exploiting differentials, not linearization." };

        string[] question3Feedback = {"Correct! This is how we reduce the amount of possible keys. Since we have 2 chosen plaintexts that give us " +
                "a specific differential, and because the adding of the round key doesn't affect the differential of the two results of the adding, " +
                "we can easily figure out the possible inputs/outputs to the middle S-Box.",
            "Incorrect. The differential property actually can get affected by the S-box, and in most cases it does.",
            "Incorrect. This is not how we obtain the key. Think about the properties that the differential has, and how it gets changed through each " +
            "step of the algorithm." };

        OrderedDictionary CorrectAnswers = new OrderedDictionary();
        OrderedDictionary questionAndAnswers = new OrderedDictionary();
        OrderedDictionary questionAndFeedback = new OrderedDictionary();
        public DiffStep3()
        {
            InitializeComponent();
            questionAndAnswers.Add("We now have a good candidate for our chosen plaintext attack. How does this help us?", question1Answers);

            questionAndAnswers.Add("Does this improve the time it takes to figure out the keys?", question2Answers);

            questionAndAnswers.Add("Why did we pick to use the XOR differential as our 'property'?", question3Answers);

            CorrectAnswers.Add("Question1", "It reduces the possible amount of keys we need to check, as only a certain amount of keys will\n" +
                                      "give us values that hold true to the differential rule we are holding (that the input differential = 2,\n" +
                                      "and the output differential = 4).");

            CorrectAnswers.Add("Does this improve the time it takes to figure out the keys?", "It does, by reducing the amount of possible keys that could give us values that satisfy our differential rule.");

            CorrectAnswers.Add("Why did we pick to use the XOR differential as our 'property'?", "This particular property does not get affected by the adding of the round key.");

            questionAndFeedback.Add("We now have a good candidate for our chosen plaintext attack. How does this help us?", question1Feedback);

            questionAndFeedback.Add("Does this improve the time it takes to figure out the keys?", question2Feedback);

            questionAndFeedback.Add("Why did we pick to use the XOR differential as our 'property'?", question3Feedback);

            var ODEntry = questionAndAnswers.Cast<DictionaryEntry>().ElementAt(CurrQuestion);

            questionTextLabel.Text = ODEntry.Key.ToString();

            string[] answers = (string [])ODEntry.Value;
            Answer1.Text = answers[0];
            Answer2.Text = answers[1];
            Answer3.Text = answers[2];
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (ans1Correct && ans2Correct && ans3Correct)
            {
                DiffStep4 diffStep4 = new DiffStep4();
                diffStep4.Tag = this;
                diffStep4.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("You have not yet correctly answered all the questions!");
            }            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DiffStep2 diffStep2 = new DiffStep2();
            diffStep2.Tag = this;
            diffStep2.Show(this);
            Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool ans1IsChecked = Answer1.Checked;
            bool ans2IsChecked = Answer2.Checked;
            bool ans3IsChecked = Answer3.Checked;
            var FeedbackODEntry = questionAndFeedback.Cast<DictionaryEntry>().ElementAt(CurrQuestion);
            string[] feedbackArr = (string[])FeedbackODEntry.Value;
            string chosenAnswer = "";
            string feedback = "";
            if (ans1IsChecked)
            {
                chosenAnswer = Answer1.Text;
                feedback = feedbackArr[0];
            }                
            else if (ans2IsChecked)
            {
                chosenAnswer = Answer2.Text;
                feedback = feedbackArr[1];

            }
            else
            {
                chosenAnswer = Answer3.Text;
                feedback = feedbackArr[2];
            }
            string correctAnswer = "";
            var ODEntry = CorrectAnswers.Cast<DictionaryEntry>().ElementAt(CurrQuestion);
            correctAnswer = ODEntry.Value.ToString();

            if (chosenAnswer == correctAnswer)
            {                
                if (CurrQuestion == 0)
                {
                    MessageBox.Show("Correct!");
                    ans1Correct = true;
                }
                else if (CurrQuestion == 1)
                {
                    MessageBox.Show("Correct!");
                    ans2Correct = true;
                }
                else if (CurrQuestion == 2)
                {
                    MessageBox.Show("Correct, you may now progress to the next step!");
                    ans3Correct = true;
                }

                if (CurrQuestion < 2)
                {
                    CurrQuestion++;
                }

                ODEntry = questionAndAnswers.Cast<DictionaryEntry>().ElementAt(CurrQuestion);
                questionTextLabel.Text = ODEntry.Key.ToString();
                string[] answers = (string[])ODEntry.Value;
                Answer1.Text = answers[0];
                Answer2.Text = answers[1];
                Answer3.Text = answers[2];
            }
            else
            {
                MessageBox.Show(feedback);
            }

        }
    }
}
