using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS22_窗体
{
    partial class Frm : Form
    {
        public Frm()
        {
            //todo:先执行构造函数 然后form的load事件 最后是Show()方法
            InitializeComponent();
        }
        // public 
        private void Frm_Load(object sender, EventArgs e)
        {

        }

        private string FileName = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            // if (File.Exists(@"D:\doc.docx"))
            // {
            //     DialogResult dr;
            //     dr = MessageBox.Show("目标文件已存在 确定覆盖吗", "Title", MessageBoxButtons.OKCancel,MessageBoxIcon.Information
            //     ,MessageBoxDefaultButton.Button2);
            //     if (dr == DialogResult.OK)
            //     {
            //         File.Copy(@"D:\doc1.docx", @"D:\users\doc.docx", true);
            //
            //     }
            // }
            // else
            // {
            //     File.Copy(@"D:\doc1.docx",@"D:\users\doc.docx");
            // }
            OpenFileDialog dialog = new OpenFileDialog();
            // string SourceFilePath = "";
            // string TatgetFilePath = "";
            dialog.Title = "请选择文件夹";
            dialog.Filter = "文本文件(*.txt)|*.txt|图标文件(*.ico)|*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dialog.FileName;
                FileName = Path.GetFileName(dialog.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择要复制到的文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show("您选择的路径为空，请重新选择");
                    return;
                }

                label2.Text = dialog.SelectedPath;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            string fileNeedToCopy;
            fileNeedToCopy = $"{label2.Text}"+'\\'+FileName;
            if (File.Exists(fileNeedToCopy))
            {
                DialogResult dr;
                dr = MessageBox.Show("目标文件已存在，是否覆盖？", "MSGBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    File.Copy(label1.Text,label2.Text+$"{FileName}",true);
                }

            }
            else
            {
                // MessageBox.Show("该文件不存在");
                File.Copy(label1.Text,fileNeedToCopy,false);
                MessageBox.Show("Copied！");
            }
        }
    }
}
