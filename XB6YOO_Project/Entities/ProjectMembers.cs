using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XB6YOO_Project.Entities
{
    public class ProjectMembers: Button
    {

        private bool _value;
        public bool Value
        {
            get { return _value; }
            set
            {
                _value = value;

                if (_value == true)
                { BackColor = Color.Red; }
                else
                {
                    BackColor = Color.White;
                }
            }
        }

        public ProjectMembers()
        {
            Height = 30;
            Width = Height;
            BackColor = Color.White;
            MouseDown += ProjectMembers_MouseDown;
        }
        private void ProjectMembers_MouseDown(object sender, MouseEventArgs e)
        {
            if (Value == true)
            {
                Value = false;
            }
            else
            {
                Value = true;
            }
        }
    }
}
