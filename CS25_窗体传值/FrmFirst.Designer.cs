
namespace CS25_窗体传值
{
    partial class FrmFirst
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
            this.BtnCLOSE = new System.Windows.Forms.Button();
            this.BtnOPEN = new System.Windows.Forms.Button();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCLOSE
            // 
            this.BtnCLOSE.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCLOSE.Location = new System.Drawing.Point(348, 190);
            this.BtnCLOSE.Name = "BtnCLOSE";
            this.BtnCLOSE.Size = new System.Drawing.Size(75, 37);
            this.BtnCLOSE.TabIndex = 5;
            this.BtnCLOSE.Text = "关闭";
            this.BtnCLOSE.UseVisualStyleBackColor = true;
            this.BtnCLOSE.Click += new System.EventHandler(this.BtnCLOSE_Click);
            // 
            // BtnOPEN
            // 
            this.BtnOPEN.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnOPEN.Location = new System.Drawing.Point(258, 191);
            this.BtnOPEN.Name = "BtnOPEN";
            this.BtnOPEN.Size = new System.Drawing.Size(75, 36);
            this.BtnOPEN.TabIndex = 4;
            this.BtnOPEN.Text = "打开";
            this.BtnOPEN.UseVisualStyleBackColor = true;
            this.BtnOPEN.Click += new System.EventHandler(this.BtnOPEN_Click);
            // 
            // TxtShow
            // 
            this.TxtShow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtShow.Location = new System.Drawing.Point(76, 74);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(338, 67);
            this.TxtShow.TabIndex = 3;
            // 
            // FrmFirst
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(499, 301);
            this.Controls.Add(this.BtnCLOSE);
            this.Controls.Add(this.BtnOPEN);
            this.Controls.Add(this.TxtShow);
            this.Name = "FrmFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的第一个窗体";
            this.Load += new System.EventHandler(this.FrmFirst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCLOSE;
        private System.Windows.Forms.Button BtnOPEN;
        private System.Windows.Forms.TextBox TxtShow;
    }
}

