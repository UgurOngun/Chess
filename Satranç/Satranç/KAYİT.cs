using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Satranç
{
    public partial class KAYİT : Form
    {
        public KAYİT()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=PC\UGUR;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand komut = new SqlCommand();


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
            try
            {
                

                if (Sifre_Tx.Text == SifreOnay_Tx.Text)
                {
                    bag.Open();
                    SqlCommand komut = new SqlCommand("insert into kayit(email,kullaniciAdi,sifre) values('" + Eposta_Tx.Text.ToString() + "','" + KullaniciAdi_Tx.Text.ToString() + "','" + Sifre_Tx.Text.ToString() + "')", bag);
                    komut.ExecuteNonQuery();
                    bag.Close();
                }

                else
                {
                    MessageBox.Show("ŞİFRELER AYNI DEĞİL");
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("SİSTEMDE ZATEN BÖYLE BİR KUllANICI VAR");
            }
            this.Hide();
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
