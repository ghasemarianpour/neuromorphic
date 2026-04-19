using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MyApp : Form
    {
        public MyApp()
        {
            InitializeComponent();
        }

        private void btnsayhello_MouseMove(object sender, MouseEventArgs e)
        {
            btnsayhello.Text = "Say";
            btnsayhello.ForeColor = Color.Blue;
            btnsayhello.BackColor = Color.Cyan;
        }

        private void btnsayhello_MouseLeave(object sender, EventArgs e)
        {
            btnsayhello.Text = "Say Hello";
            btnsayhello.ForeColor = Color.Black;
            btnsayhello.BackColor = Color.Transparent;
        }
    }
}
