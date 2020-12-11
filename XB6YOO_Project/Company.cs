using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XB6YOO_Project
{
    public partial class Company : UserControl
    {
        public Company()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Data";
                ofd.Filter = "CSV File|*.csv";
                ofd.ShowDialog();
                string fn = ofd.FileName;
                string readfile = File.ReadAllText(fn);
                string[] line = readfile.Split('\n');
                Console.WriteLine(line);
                int count = 0;
                foreach (string str in line[0].Split(',', ';'))
                {
                    count++;
                }

                dataGridView1.ColumnCount = count;
                foreach (string s1 in readfile.Split('\n'))
                {
                    if (s1 != "")
                    {
                        dataGridView1.Rows.Add(s1.Split(',', ';'));
                    }
                }

            }

            catch (Exception)
            {

                MessageBox.Show("You did not open any file so you will not get any output \n Thank you!");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("CleanEnergy", Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value));
            chart1.Series["Series1"].Points.AddXY("NaturalGas", Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value));
            chart1.Series["Series1"].Points.AddXY("Coal", Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value));
            chart1.Series["Series1"].Points.AddXY("Nuclear", Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value));
        }


    }
}
