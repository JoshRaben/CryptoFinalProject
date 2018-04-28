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
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void linear_Click(object sender, EventArgs e)
        {
            LinearHome linearHome = new LinearHome();
            linearHome.Tag = this;
            linearHome.Show(this);
            Hide();
        }

        private void differential_Click(object sender, EventArgs e)
        {
            DiffHome diffHome = new DiffHome();
            diffHome.Tag = this;
            diffHome.Show(this);
            Hide();
        }
    }
}
