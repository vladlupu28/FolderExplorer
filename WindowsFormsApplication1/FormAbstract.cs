﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public abstract partial class FormAbstract : Form
    {
        public FormAbstract()
        {
            InitializeComponent();
        }

        public abstract void button1_Click(object sender, EventArgs e);

        public abstract void button2_Click(object sender, EventArgs e);

    }
}
