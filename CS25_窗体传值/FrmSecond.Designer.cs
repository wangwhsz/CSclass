
namespace CS25_窗体传值
{
    partial class FrmSecond
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
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtShow
            // 
            this.TxtShow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtShow.Location = new System.Drawing.Point(48, 70);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(338, 67);
            this.TxtShow.TabIndex = 0;
            this.TxtShow.TextChanged += new System.EventHandler(this.TxtShow_TextChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnOK.Location = new System.Drawing.Point(230, 187);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 36);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCancel.Location = new System.Drawing.Point(320, 186);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 37);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSecond
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(410, 250);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtShow);
            this.Name = "FrmSecond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "第二个窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSecond_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSecond_FormClosed);
            this.Load += new System.EventHandler(this.FrmSecond_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}