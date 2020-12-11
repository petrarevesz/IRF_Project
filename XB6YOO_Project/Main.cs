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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void BtnPetition_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl p = new Petition();
            panel1.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }
    }
}
