﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phongkhachsan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            btnAddRoom.PerformClick();

        }
        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

       
    }
}
