using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XB6YOO_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGo.Text = Resource.Go;

        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter the password!");
                return;
            }

            if (txtBoxPassword.Text != "Password123")
            {
                MessageBox.Show("Password incorrect, please try it again!");
                return;
            }

            Main m = new Main();
            DialogResult result = m.ShowDialog();
            txtBoxPassword.Clear();
        }
    }
}
