using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class FormDialog : Form
    {
        // Declare delagete callback function
        // 값을 보내는 곳의 Form 쪽에 이벤트 선언해야 한다
        public DataGetEventHandler DataSendEvent;

        public FormDialog()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxItem.Text.Length == 0)
            {
                MessageBox.Show("값이 입력되지 않았습니다");
                return;
            }
            else
            {
                DataSendEvent(textBoxItem.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}