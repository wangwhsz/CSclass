using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS24_歌曲列表
{
    public partial class Form1 : Form
    {
        private Point formPoint = new Point();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // FormBorderStyle = FormBorderStyle.
            // ControlBox = false;

            // Form2 frmForm2 = new Form2();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSong.Items.Add("歌唱祖国");
            LstSong.Items.Add("Shadow");
            LstSong.Items.Add("Ensemble");
            // this.MaximizeBox = false;
            // this.MinimizeBox = false;
            // LstSong.Items.Add("");

        }

        private void LstSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstSong.SelectedItems.Count>0)
            {
                string cText = LstSong.SelectedItem.ToString();
                MessageBox.Show($"{cText}");
                // ShowDialog()
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            
            frm2.ShowDialog(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // frmForm2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                button3.Image = global::CS24_歌曲列表.Properties.Resources.Home;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                button3.Image = global::CS24_歌曲列表.Properties.Resources.Apps;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

                button3.Image = global::CS24_歌曲列表.Properties.Resources.Home;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                button3.Image = global::CS24_歌曲列表.Properties.Resources.Apps;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                this.Invalidate();

        }
    }
}
