using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XB6YOO_Project.Entities;
using System.IO;

namespace XB6YOO_Project
{
    public partial class Volunteers : UserControl
    {
        List<Person> Population = new List<Person>();

        public Volunteers()
        {
            InitializeComponent();
            
            Population = GetPopulation("Volunteers.csv");
            dataGridView1.DataSource = Population;
            lblp1.Text = Resource.Project1;
            lblp2.Text = Resource.Project2;
            lblp3.Text = Resource.Project3;
            btnAdd1.Text = Resource.Add;
            btnAdd2.Text = Resource.Add;
            btnAdd3.Text = Resource.Add;
        }

        public List<Person> GetPopulation(string csvpath)
        {

            
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(',');
                    Population.Add(new Person()
                    {
                        Surname = (line[0]).ToString(),
                        Name = (line[1]).ToString(),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[2]),
                        //NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return Population;
            
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            GetButtons1();
        }

        private void GetButtons1()
        {
            decimal n = nUpDown1.Value;
            int count = Convert.ToInt32(n);
            int x = 0;
            int y = 1;
            for (int i = 0; i < count; i++)
            {
                ProjectMembers btn = new ProjectMembers();
                btn.Text = y.ToString();
                btn.Name = y.ToString();
                btn.Location = new Point(btn.Width * x + 200, 260);
                x++;
                y++;
                Controls.Add(btn);
            }
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            GetButtons2();
        }

        private void GetButtons2()
        {
            decimal n = nUpDown2.Value;
            int count = Convert.ToInt32(n);
            int x = 0;
            int y = 1;
            for (int i = 0; i < count; i++)
            {
                ProjectMembers btn = new ProjectMembers();
                btn.Text = y.ToString();
                btn.Name = y.ToString();
                btn.Size = new Size(30, 30);
                btn.Location = new Point(btn.Width * x + 200, 290);
                x++;
                y++;
                Controls.Add(btn);
            }
        }

        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            GetButtons3();
        }

        private void GetButtons3()
        {
            decimal n = nUpDown3.Value;
            int count = Convert.ToInt32(n);
            int x = 0;
            int y = 1;
            for (int i = 0; i < count; i++)
            {
                ProjectMembers btn = new ProjectMembers();
                btn.Text = y.ToString();
                btn.Name = y.ToString();
                btn.Size = new Size(30, 30);
                btn.Location = new Point(btn.Width * x + 200, 320);
                x++;
                y++;
                Controls.Add(btn);
            }
        }

    }
}
