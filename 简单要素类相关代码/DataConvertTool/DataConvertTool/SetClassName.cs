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

        //����:��Ҫ��������
        public string m_SFclsName
        {
            get { return txtSFclsName.Text; }
        }

        private void IDOK_Click(object sender, EventArgs e)
        {
            if (txtSFclsName.Text == "")
            {
                MessageBox.Show("��Ҫ�������Ʋ���Ϊ��!");
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