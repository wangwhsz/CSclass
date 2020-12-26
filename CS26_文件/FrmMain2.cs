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
namespace CS26_文件
{
    public partial class FrmMain2 : Form
    {
        public FrmMain2()
        {
            InitializeComponent();
        }

        private string cPath = @"C:\Users\WangzyaaaA\Desktop";
        private string SelectedFilePath;
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            TxtPath.Text = cPath;
            // TreeNode treeNode = new TreeNode();
            // treeNode.Text = @"jike";
            // TrvFile.Nodes.Add(treeNode);
            //
            // TreeNode tn = new TreeNode();
            // tn.Text = "wulianwang";
            // treeNode.Nodes.Add(tn);


        }

        private void BtnListFile_Click(object sender, EventArgs e)
        {
            TrvFile.Nodes.Clear();
            // FileDialog.ShowDialog();
            FolderBrowserDialog FileDialog = new FolderBrowserDialog();
            FileDialog.SelectedPath = cPath;
            DialogResult dialogResult = FileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                cPath = FileDialog.SelectedPath;
                TxtPath.Text = cPath;
            }
            string[] cNames = Directory.GetFiles(cPath,"*.txt");
            // Directory.
            TreeNode tn = new TreeNode(cPath);
            foreach (string cName in cNames)
            {
                int nIndex = cName.LastIndexOf(@"\")+1;
                string cText = cName.Substring(nIndex);
                // string cText = cName;
                SelectedFilePath = cName;
                TreeNode tc = new TreeNode(cText);
                tn.Nodes.Add(tc);
            }
            
            TrvFile.Nodes.Add(tn);
            // tn.ExpandAll();
            TrvFile.ExpandAll();



            //////
            ///
            // DirectoryInfo directoryInfo = new DirectoryInfo(cPath);
            // FileInfo[] fInfo = directoryInfo.GetFiles("*.txt");
            // TreeNode tn = new TreeNode();
            // foreach (FileInfo fileInfo in fInfo)
            // {
            //     TreeNode tc = new TreeNode(fileInfo.Name);
            //     tn.Nodes.Add(tc);
            //
            // }
            //
            // TrvFile.Nodes.Add(tn);
            // TrvFile.ExpandAll();










            // Console.ReadLine();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // SaveFileDialog saveFileDialog = new SaveFileDialog();
            // StreamWriter sw = new StreamWriter();
            // SaveFileDialog saveFileDialog = new SaveFileDialog();
            // saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            // saveFileDialog.FileName = "文件" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            // if (saveFileDialog.ShowDialog() == DialogResult.OK)
            // {
                // StreamWriter streamWriter = new StreamWriter(cPath+"\\"+cName);
                // streamWriter.Write(this.textBox1.Text);
                // streamWriter.Close();
            // }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            saveFileDialog.FileName = @"1.txt";
            saveFileDialog.InitialDirectory = cPath;
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Console.ReadLine();
                // MessageBox.Show("1");
                string cName = saveFileDialog.FileName;
                using (StreamWriter streamWriter = new StreamWriter(cName))
                {
                    // const int nCount = 9;
                    // int nRow = 1;
                    // int nCol = 1;
                    // for (; nRow <= nCount; nRow++)
                    // {
                    //     for (nCol = 1; nCol <= nRow; nCol++)
                    //     {
                    //         streamWriter.Write("{0}x{1}={2}\t", nRow, nCol, nRow * nCol);
                    //     }
                    //
                    //     streamWriter.WriteLine();
                    // }   
                    streamWriter.Write(textBox1.Text);
                }
            }



            // string
            // using (StreamWriter sw = new StreamWriter())
            // {
            //
            // }





        }

        private void TrvFile_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // using (StreamReader streamReader = new StreamReader(e.Node.Text))
            {
                // MessageBox.Show(e.Node.Text);
            }
            if (TrvFile.SelectedNode == null)
            {
                // MessageBox.Show("选择先");
                return;
            }
            if (cPath == e.Node.Text)
                return;
                
            string cName = TrvFile.SelectedNode.Text;
                // MessageBox.Show(cName);
            
                // cName = string.Format($"{cPath}"+"\\"+"{cName}");
                
            cName = cPath +"\\" +cName;
                // MessageBox.Show(cPath + " " + cName);

            using (StreamReader sr = new StreamReader(cName))
            {
                    textBox1.Text = sr.ReadToEnd();
            }
            
        }

        private void TrvFile_DoubleClick(object sender, EventArgs e)
        {
            // TrvFile.SelectedNode.Text.;
            // FileStream(SelectedFilePath,)
            // var fileStream = new StreamReader();
            // using (FileStream fileStream = new FileStream(SelectedFilePath,FileMode.Append,FileAccess.ReadWrite))
            // {
            //     string FileContent;
            //     fileStream.Read();
            //
            // }



            // using (StreamReader streamReader = new StreamReader(SelectedFilePath))
            // {
            //     string line;
            //     textBox1.Text = string.Empty;
            //     // Read and display lines from the file until the end of
            //     // the file is reached.
            //     while ((line = streamReader.ReadLine()) != null)
            //     {
            //         textBox1.Text += line;
            //         textBox1.Text += "\r\n";
            //     }
            // }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmMain2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}


//todo 怎么实现菜单里的全局和alt快捷键
