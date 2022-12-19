using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Satranç
{
    public partial class Yeni_Sifre : Form
    {
        SqlConnection bag = new SqlConnection(@"Data Source=PC\UGUR;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        public Yeni_Sifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sifre_Tx.Text == SifreOnay_Tx.Text)
            {
                SqlCommand komut = new SqlCommand("insert into kayit(sifre) values('" + Sifre_Tx.Text.ToString() + "')", bag);
                this.Close();
            }
            else
            {
                MessageBox.Show("İKİ ŞİFRE AYNI DEĞİL");
            }

        
            
        }
    }
}
