using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataConvertTool
{
    public partial class SetClassName : Form
    {
        public SetClassName()
        {
            InitializeComponent();
        }

        //属性:简单要素类名称
        public string m_SFclsName
        {
            get { return txtSFclsName.Text; }
        }

        private void IDOK_Click(object sender, EventArgs e)
        {
            if (txtSFclsName.Text == "")
            {
                MessageBox.Show("简单要素类名称不能为空!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetClassName_Load(object sender, EventArgs e)
        {

        }
    }
}