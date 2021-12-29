using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class ChildForm1 : Form
    {
        private static int _id = 0;
        public ChildForm1()
        {
            InitializeComponent();
            _id++;
            this.Text += " [" + _id.ToString() + "]";
        }

        public void SetActionValue1(string param)
        {
            txtParam.Text = param;
        }
    }
}