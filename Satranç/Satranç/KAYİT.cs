using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranç
{
    public partial class KAYİT : Form
    {
        public KAYİT()
        {
            InitializeComponent();
        }

        

        protected void textBox1_Focus(Object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (true)
            {
                checkBox1.Checked = true;
                button1.Visible = true;
            }
            else
            {
                checkBox1.Checked = false;
                button1.Visible = false;
            }
              
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
