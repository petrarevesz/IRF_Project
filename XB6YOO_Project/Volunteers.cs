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
    }
}
