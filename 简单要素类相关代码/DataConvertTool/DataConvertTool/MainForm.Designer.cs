namespace DataConvertTool
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdbList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_7xToSHP = new System.Windows.Forms.Button();
            this.Btn_7Xto6X = new System.Windows.Forms.Button();
            this.btn_67to7x = new System.Windows.Forms.Button();
            this.btnVctTo7x = new System.Windows.Forms.Button();
            this.btnShpTo7x = new System.Windows.Forms.Button();
            this.btnMifTo7x = new System.Windows.Forms.Button();
            this.btnE00To7x = new System.Windows.Forms.Button();
            this.btnDxfTo7x = new System.Windows.Forms.Button();
            this.xclsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdbList);
            this.groupBox2.Location = new System.Drawing.Point(1, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 402);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库列表";
            // 
            // gdbList
            // 
            this.gdbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdbList.FormattingEnabled = true;
            this.gdbList.ItemHeight = 12;
            this.gdbList.Location = new System.Drawing.Point(3, 17);
            this.gdbList.Name = "gdbList";
            this.gdbList.Size = new System.Drawing.Size(181, 382);
            this.gdbList.TabIndex = 16;
            this.gdbList.SelectedIndexChanged += new System.EventHandler(this.gdbList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_7xToSHP);
            this.groupBox1.Controls.Add(this.Btn_7Xto6X);
            this.groupBox1.Controls.Add(this.btn_67to7x);
            this.groupBox1.Controls.Add(this.btnVctTo7x);
            this.groupBox1.Controls.Add(this.btnShpTo7x);
            this.groupBox1.Controls.Add(this.btnMifTo7x);
            this.groupBox1.Controls.Add(this.btnE00To7x);
            this.groupBox1.Controls.Add(this.btnDxfTo7x);
            this.groupBox1.Location = new System.Drawing.Point(199, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 110);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转换操作";
            // 
            // btn_7xToSHP
            // 
            this.btn_7xToSHP.Location = new System.Drawing.Point(152, 65);
            this.btn_7xToSHP.Name = "btn_7xToSHP";
            this.btn_7xToSHP.Size = new System.Drawing.Size(65, 29);
            this.btn_7xToSHP.TabIndex = 15;
            this.btn_7xToSHP.Text = "7X->SHP";
            this.btn_7xToSHP.UseVisualStyleBackColor = true;
            this.btn_7xToSHP.Click += new System.EventHandler(this.btn_7xToSHP_Click);
            // 
            // Btn_7Xto6X
            // 
            this.Btn_7Xto6X.Location = new System.Drawing.Point(82, 65);
            this.Btn_7Xto6X.Name = "Btn_7Xto6X";
            this.Btn_7Xto6X.Size = new System.Drawing.Size(64, 29);
            this.Btn_7Xto6X.TabIndex = 14;
            this.Btn_7Xto6X.Text = "7X->6x";
            this.Btn_7Xto6X.UseVisualStyleBackColor = true;
            this.Btn_7Xto6X.Click += new System.EventHandler(this.Btn_7Xto6X_Click);
            // 
            // btn_67to7x
            // 
            this.btn_67to7x.Location = new System.Drawing.Point(13, 65);
            this.btn_67to7x.Name = "btn_67to7x";
            this.btn_67to7x.Size = new System.Drawing.Size(62, 30);
            this.btn_67to7x.TabIndex = 13;
            this.btn_67to7x.Text = "67->7x";
            this.btn_67to7x.UseVisualStyleBackColor = true;
            this.btn_67to7x.Click += new System.EventHandler(this.btn_67to7x_Click);
            // 
            // btnVctTo7x
            // 
            this.btnVctTo7x.Location = new System.Drawing.Point(294, 20);
            this.btnVctTo7x.Name = "btnVctTo7x";
            this.btnVctTo7x.Size = new System.Drawing.Size(65, 29);
            this.btnVctTo7x.TabIndex = 10;
            this.btnVctTo7x.Text = "VCT->7x";
            this.btnVctTo7x.UseVisualStyleBackColor = true;
            this.btnVctTo7x.Click += new System.EventHandler(this.btnVctTo7x_Click);
            // 
            // btnShpTo7x
            // 
            this.btnShpTo7x.Location = new System.Drawing.Point(223, 19);
            this.btnShpTo7x.Name = "btnShpTo7x";
            this.btnShpTo7x.Size = new System.Drawing.Size(65, 29);
            this.btnShpTo7x.TabIndex = 8;
            this.btnShpTo7x.Text = "SHP->7x";
            this.btnShpTo7x.UseVisualStyleBackColor = true;
            this.btnShpTo7x.Click += new System.EventHandler(this.btnShpTo7x_Click);
            // 
            // btnMifTo7x
            // 
            this.btnMifTo7x.Location = new System.Drawing.Point(152, 19);
            this.btnMifTo7x.Name = "btnMifTo7x";
            this.btnMifTo7x.Size = new System.Drawing.Size(65, 29);
            this.btnMifTo7x.TabIndex = 6;
            this.btnMifTo7x.Text = "MIF->7x";
            this.btnMifTo7x.UseVisualStyleBackColor = true;
            this.btnMifTo7x.Click += new System.EventHandler(this.btnMifTo7x_Click);
            // 
            // btnE00To7x
            // 
            this.btnE00To7x.Location = new System.Drawing.Point(81, 19);
            this.btnE00To7x.Name = "btnE00To7x";
            this.btnE00To7x.Size = new System.Drawing.Size(65, 29);
            this.btnE00To7x.TabIndex = 4;
            this.btnE00To7x.Text = "E00->7x";
            this.btnE00To7x.UseVisualStyleBackColor = true;
            this.btnE00To7x.Click += new System.EventHandler(this.btnE00To7x_Click);
            // 
            // btnDxfTo7x
            // 
            this.btnDxfTo7x.Location = new System.Drawing.Point(10, 19);
            this.btnDxfTo7x.Name = "btnDxfTo7x";
            this.btnDxfTo7x.Size = new System.Drawing.Size(65, 29);
            this.btnDxfTo7x.TabIndex = 2;
            this.btnDxfTo7x.Text = "DXF->7x";
            this.btnDxfTo7x.UseVisualStyleBackColor = true;
            this.btnDxfTo7x.Click += new System.EventHandler(this.btnDxfTo7x_Click);
            // 
            // xclsList
            // 
            this.xclsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.xclsList.FullRowSelect = true;
            this.xclsList.GridLines = true;
            this.xclsList.Location = new System.Drawing.Point(199, 8);
            this.xclsList.Name = "xclsList";
            this.xclsList.Size = new System.Drawing.Size(376, 272);
            this.xclsList.TabIndex = 20;
            this.xclsList.UseCompatibleStateImageBehavior = false;
            this.xclsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类名称";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类ID";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "几何类型";
            this.columnHeader3.Width = 204;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xclsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "数据转换";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox gdbList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVctTo7x;
        private System.Windows.Forms.Button btnShpTo7x;
        private System.Windows.Forms.Button btnMifTo7x;
        private System.Windows.Forms.Button btnE00To7x;
        private System.Windows.Forms.Button btnDxfTo7x;
        private System.Windows.Forms.ListView xclsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_67to7x;
        private System.Windows.Forms.Button Btn_7Xto6X;
        private System.Windows.Forms.Button btn_7xToSHP;
    }
}

