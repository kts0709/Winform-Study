using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public delegate void DataPushEventHandler(string value);
    public delegate void DataGetEventHandler(string item);

    public partial class MainForm : Form
    {
        // 값을 보내는 곳의 Form 쪽에 이벤트 선언해야 한다
        public DataPushEventHandler DataSendEvent;  

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFrm1_Click(object sender, EventArgs e)
        {
            // 같은 폼이 2개 이상 뜨지 않도록 처리하는 코드
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "ChildForm1")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                    }
                    openForm.Activate();
                    return;
                }
            }

            ChildForm1 frm1 = new ChildForm1();
            this.DataSendEvent += new DataPushEventHandler(frm1.SetActionValue1);
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
            frm1.Show();
        }

        private void txtParam_TextChanged(object sender, EventArgs e)
        {
            // 텍스트박스에 값을 입력하면 실시간적으로 자식폼으로 값이 전달됨
            DataSendEvent(txtParam.Text);
        }

        private void btnOpenFrm2_Click(object sender, EventArgs e)
        {
            // 같은 폼이 2개 이상 뜨지 않도록 처리하는 코드
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "ChildForm2")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                    }
                    openForm.Activate();
                    return;
                }
            }

            ChildForm2 frm2 = new ChildForm2();
            this.DataSendEvent += new DataPushEventHandler(frm2.SetActionValue2);
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y + 100);
            frm2.Show();
        }

        private void btnScenario2_Click(object sender, EventArgs e)
        {
            // 같은 폼이 2개 이상 뜨지 않도록 처리하는 코드
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "FormDialog")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                    }
                    openForm.Activate();
                    return;
                }
            }

            FormDialog frm3 = new FormDialog();
            frm3.DataSendEvent = new DataGetEventHandler(this.Form3DataAction);
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y + 250);
            frm3.Show();
        }

        private void Form3DataAction(string item)
        {
            listBox.Items.Add(item);
        }
    }
}