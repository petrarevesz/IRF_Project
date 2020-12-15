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
            btnPetition.Text = Resource.Petitions;
            btnCompany.Text = Resource.Tracker;
            btnVolunter.Text = Resource.Volunteers;
        }

        private void BtnPetition_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl p = new Petition();
            panel1.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl c = new Company();
            panel1.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }

        private void BtnVolunter_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl v = new Volunteers();
            panel1.Controls.Add(v);
            v.Dock = DockStyle.Fill;
        }
    }
}
