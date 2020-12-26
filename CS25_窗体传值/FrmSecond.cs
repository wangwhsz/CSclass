using System;
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
    public partial class FrmSecond : Form
    {
        public string cText;

        public FrmSecond(string ShowText)
        {
            InitializeComponent();
            TxtShow.Text = ShowText;
        }


        public FrmSecond()
        {
            InitializeComponent();
        }

        private void FrmSecond_Load(object sender, EventArgs e)
        {
            // TxtShow.Text = ((FrmFirst) Owner).passText;
            // TxtShow.Text =  Owner.passText;
            TxtShow.Text = cText;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            cText = TxtShow.Text;
            DialogResult = DialogResult.OK;
            Close();
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
            Dispose();
        }

        private void FrmSecond_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cText = TxtShow.Text;
        }

        private void FrmSecond_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                cText = TxtShow.Text;
            }

            if (DialogResult == DialogResult.Cancel)
            {
                cText = "cancel";
            }
            
        }

        private void TxtShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}