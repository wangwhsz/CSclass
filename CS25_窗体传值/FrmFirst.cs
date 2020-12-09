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
    
    public partial class FrmFirst : Form
    {
        public FrmFirst()
        {
            InitializeComponent();
        }

        public string passText { get; set; }
        // public string cText;
        private void FrmFirst_Load(object sender, EventArgs e)
        {
            TxtShow.Text = "StringLine1";
            TxtShow.Text += "\r\n"+"StringLine2";
            // MessageBox.Show();
            passText = TxtShow.Text;

            //todo 方案1 利用构造函数
            //todo 方案2 利用共有属性或字段
        }

        private void BtnOPEN_Click(object sender, EventArgs e)
        {
            FrmSecond form = new FrmSecond();
            form.Owner = this;
            form.cText = this.TxtShow.Text;
            form.ShowDialog();
            this.TxtShow.Text = form.cText;
        }

        private void BtnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
