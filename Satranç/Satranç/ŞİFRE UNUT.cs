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
    public partial class Sifre_Unut : Form
    {
        public Sifre_Unut()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Yeni_Sifre f3 = new Yeni_Sifre();
            this.Hide();
            f3.ShowDialog();
            
        }
    }
}
