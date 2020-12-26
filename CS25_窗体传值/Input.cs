﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS25_窗体传值
{
    public partial class Input : Form
    {
        public string InputText;
        public Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // InputText
        }

        public string cText;

        private void Input_Load(object sender, EventArgs e)
        {
            textBox1.Text = cText;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 48 || e.KeyChar >= 57)
            {
                e.Handled = true;
            }
        }
    }
}
