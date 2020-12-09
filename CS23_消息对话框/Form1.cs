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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Console.WriteLine("click");
            DialogResult dialogResult = MessageBox.Show("你饿了吗",
                "c#shili",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("你真饿了");
            }
            else
            {
                MessageBox.Show("等会再吃");
            }
        }

        private void btnOpen_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("enter");
        }

        private void btnOpen_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("leave");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("按下");
        }

        #region feichude

        

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("松开");
            // MouseEventArgs
        }

        #endregion

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("鼠标进入了");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("鼠标离开");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            // Application.Exit();
        }
    }
}
