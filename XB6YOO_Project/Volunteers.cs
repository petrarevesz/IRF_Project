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
            Population = GetVolunteers("Volunteers.csv");
            dataGridView1.DataSource = Population;
            lblp1.Text = Resource.Project1;
            btnAdd1.Text = Resource.Add;
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            GetButtons();
        }

        public List<Person> GetVolunteers(string csvpath)
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
                    });
                }
            }
            return Population;       
        }


        private void GetButtons()
        {
            decimal n = nUpDown1.Value;
            int count = Convert.ToInt32(n);
            int x = 0;
            int y = 1;
            int position1 = 200;
            int position2 = 260;

            for (int i = 0; i < count; i++)
            {
                ProjectMembers btn = new ProjectMembers();
                btn.Text = y.ToString();
                btn.Location = new Point(btn.Width * x + position1, position2);
                x++;
                y++;
                Controls.Add(btn);
            }
        }

        

    }
}
