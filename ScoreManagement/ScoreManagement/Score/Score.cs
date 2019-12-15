﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement.Score
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            this.btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var temp = this.Owner;
            temp.RemoveOwnedForm(this);
            this.Close();
            temp.Show();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreManagementDataSetDiem.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.scoreManagementDataSetDiem.DIEM);
            // TODO: This line of code loads data into the 'scoreManagementDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.scoreManagementDataSet.MONHOC);

        }
    }
}
