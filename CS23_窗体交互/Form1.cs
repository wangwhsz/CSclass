using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS23_消息对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("text", "title", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk,
                // MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                DialogResult dr;
                dr = MessageBox.Show("text", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (dr == DialogResult.Yes)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
                // MessageBox.Show($"{dr.ToString()}");
        }
    }
}
