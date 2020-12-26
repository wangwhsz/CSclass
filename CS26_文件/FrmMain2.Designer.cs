
namespace CS26_文件
{
    partial class FrmMain2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LblPath = new System.Windows.Forms.Label();
            this.BtnListFile = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.TrvFile = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.LblPath);
            this.panelTop.Controls.Add(this.BtnListFile);
            this.panelTop.Controls.Add(this.TxtPath);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1115, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("宋体", 12F);
            this.LblPath.Location = new System.Drawing.Point(12, 10);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(106, 24);
            this.LblPath.TabIndex = 2;
            this.LblPath.Text = "设置路径";
            // 
            // BtnListFile
            // 
            this.BtnListFile.Location = new System.Drawing.Point(829, 6);
            this.BtnListFile.Name = "BtnListFile";
            this.BtnListFile.Size = new System.Drawing.Size(132, 39);
            this.BtnListFile.TabIndex = 1;
            this.BtnListFile.Text = "列出文本文件";
            this.BtnListFile.UseVisualStyleBackColor = true;
            this.BtnListFile.Click += new System.EventHandler(this.BtnListFile_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPath.Location = new System.Drawing.Point(174, 5);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(640, 39);
            this.TxtPath.TabIndex = 0;
            this.TxtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.TrvFile);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(150, 340);
            this.panelLeft.TabIndex = 1;
            // 
            // TrvFile
            // 
            this.TrvFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvFile.Location = new System.Drawing.Point(0, 0);
            this.TrvFile.Name = "TrvFile";
            this.TrvFile.Size = new System.Drawing.Size(148, 288);
            this.TrvFile.TabIndex = 1;
            this.TrvFile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvFile_NodeMouseDoubleClick);
            this.TrvFile.DoubleClick += new System.EventHandler(this.TrvFile_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 50);
            this.panel2.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(0, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(146, 48);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "保存当前文件";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(150, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 340);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(982, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox1.Location = new System.Drawing.Point(0, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(963, 306);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // FrmMain2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1115, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简单的文件操作";
            this.Load += new System.EventHandler(this.FrmMain2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain2_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView TrvFile;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnListFile;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
    }
}