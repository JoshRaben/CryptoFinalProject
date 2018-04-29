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
    public partial class DiffMission : Form
    {
        public DiffMission()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            DiffStep1 diffStep1 = new DiffStep1();
            diffStep1.Tag = this;
            diffStep1.Show(this);
            Hide();
        }
    }
}
