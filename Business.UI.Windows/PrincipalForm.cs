﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void neToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientIncludeForm f= new ClientIncludeForm();
            f.ShowDialog();
        }
    }
}
