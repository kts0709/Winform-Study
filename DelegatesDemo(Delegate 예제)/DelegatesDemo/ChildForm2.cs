using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class ChildForm2 : Form
    {
        private static int _id = 0;
        public ChildForm2()
        {
            InitializeComponent();
            _id++;
            this.Text += " [" + _id.ToString() + "]";
        }

        public void SetActionValue2(string param)
        {
            txtParam.Text = param;
        }
    }
}