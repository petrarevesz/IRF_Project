using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XB6YOO_Project
{
    public partial class Petition : UserControl
    {
        public Petition()
        {
            InitializeComponent();
            TableLoad();
        }
        DataTable table = new DataTable();

        private void TableLoad()
        {
            table.Columns.Add("Project", typeof(string));
            table.Columns.Add("Start", typeof(DateTime));
            table.Columns.Add("Finish", typeof(DateTime));
            dataGridView1.DataSource = table;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, dateTimePicker1.Value, dateTimePicker2.Value);

            dataGridView1.DataSource = table;
        }
    }
}
