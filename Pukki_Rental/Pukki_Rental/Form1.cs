﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pukki_Rental
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rentAVehicleOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmRentOut myformView = new frmRentOut();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            
            frmVehicleInfo formviewing = new frmVehicleInfo();
            formviewing.MdiParent = this;

            //formviewing.Size = ClientSize;
            formviewing.Dock = DockStyle.Fill;


            formviewing.Show();
        }
    }
}
