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
            //legenerálom a propertibe hash cuccot
            var password_hash = Properties.Settings.Default.Password.GetHashCode();
            var password_given = txtBoxPassword.Text.GetHashCode();

            if (txtBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter the password!");
                return;
            }
            else if (password_hash == password_given)
            {
                Main m = new Main();
                DialogResult result = m.ShowDialog();
                txtBoxPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please enter the correct password!");
                return;
            }

           

           
        }
    }
}
