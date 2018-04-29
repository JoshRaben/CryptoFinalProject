﻿using System;
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
    public partial class DiffHome : Form
    {
        public DiffHome()
        {
            InitializeComponent();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            DiffMission diffMission = new DiffMission();
            diffMission.Tag = this;
            diffMission.Show(this);
            Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Tag = this;
            landingForm.Show(this);
            Hide();
        }
    }
}
