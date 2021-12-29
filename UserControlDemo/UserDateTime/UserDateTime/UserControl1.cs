using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDateTime
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            MessageBox.Show(date, "오늘 날짜");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            MessageBox.Show(time, "현재 시간");
        }
    }
}
