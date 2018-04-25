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
    public partial class TableCreation : Form
    {
        public TableCreation()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            LinearStep1 linearStep1 = new LinearStep1();
            linearStep1.Tag = this;
            linearStep1.Show(this);
            Hide();
        }
    }
}
