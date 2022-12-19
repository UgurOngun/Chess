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
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=PC\UGUR;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAYİT f2 = new KAYİT();
            f2.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Kullanici_Adi_Eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kaydol_Ekrani_Click(object sender, EventArgs e)
        {
            Sifre_Unut f3 = new Sifre_Unut();
            f3.ShowDialog();
        }

        private void Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Click(object sender, EventArgs e)
        {
            try
            {
                bag.Open();
                string sql = "select * from kayit where email=@email and sifre=@sfr";
                SqlParameter prw1 = new SqlParameter("email",Eposta.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sfr", Sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, bag);
                komut.Parameters.Add(prw1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Satranc_Oyun satranc_Oyun = new Satranc_Oyun();
                    satranc_Oyun.Show();
                }

                this.Hide();
            }
            catch (Exception hata)
            {

                MessageBox.Show("HATALI GİRİŞ");
            }

        }
    }
}
