
namespace CS26_文件
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(100, 73);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(1029, 169);
            this.TxtShow.TabIndex = 0;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(134, 267);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 35);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "打开";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(351, 267);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 35);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(242, 267);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 35);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1248, 355);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.TxtShow);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}

