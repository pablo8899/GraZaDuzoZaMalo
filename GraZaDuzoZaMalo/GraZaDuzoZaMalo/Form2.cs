﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraZaDuzoZaMalo
{
    public partial class Form2 : Form
    {
        DataTable dt;
        public Form2(DataTable dtb)
        {
            dt = dtb;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
