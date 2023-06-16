namespace DataConvertTool
{
    partial class SetClassName
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSFclsName = new System.Windows.Forms.TextBox();
            this.lblPnt = new System.Windows.Forms.Label();
            this.IDOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSFclsName
            // 
            this.txtSFclsName.Location = new System.Drawing.Point(113, 18);
            this.txtSFclsName.Name = "txtSFclsName";
            this.txtSFclsName.Size = new System.Drawing.Size(158, 21);
            this.txtSFclsName.TabIndex = 11;
            // 
            // lblPnt
            // 
            this.lblPnt.AutoSize = true;
            this.lblPnt.Location = new System.Drawing.Point(12, 21);
            this.lblPnt.Name = "lblPnt";
            this.lblPnt.Size = new System.Drawing.Size(77, 12);
            this.lblPnt.TabIndex = 10;
            this.lblPnt.Text = "输入类名称：";
            // 
            // IDOK
            // 
            this.IDOK.Location = new System.Drawing.Point(113, 57);
            this.IDOK.Name = "IDOK";
            this.IDOK.Size = new System.Drawing.Size(68, 30);
            this.IDOK.TabIndex = 12;
            this.IDOK.Text = "确定";
            this.IDOK.UseVisualStyleBackColor = true;
            this.IDOK.Click += new System.EventHandler(this.IDOK_Click);
            // 
            // SetClassName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 99);
            this.Controls.Add(this.txtSFclsName);
            this.Controls.Add(this.lblPnt);
            this.Controls.Add(this.IDOK);
            this.Name = "SetClassName";
            this.Text = "设置类名称";
            this.Load += new System.EventHandler(this.SetClassName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSFclsName;
        private System.Windows.Forms.Label lblPnt;
        private System.Windows.Forms.Button IDOK;
    }
}