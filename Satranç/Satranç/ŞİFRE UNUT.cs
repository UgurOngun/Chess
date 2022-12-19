using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace Satranç
{
    public partial class Sifre_Unut : Form
    {
        public Sifre_Unut()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string kod;
        SqlConnection bag = new SqlConnection(@"Data Source=PC\UGUR;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == kod)
            {
                Yeni_Sifre f3 = new Yeni_Sifre();
                this.Hide();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("hata");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {


            kod = rnd.Next(100,999).ToString();


            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("kod@bilalsino.com");
            mesaj.To.Add(textBox1.Text);
            mesaj.Subject = "GÜVENLİK KODU";
            mesaj.Body = kod;

            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("kod@bilalsino.com", "159753024680Ab");
            a.Port = 587;
            a.Host = "mail.bilalsino.com";
            a.EnableSsl = false;
            object userState = mesaj;

            try
            {
                a.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Mail Gönderilmiştir");
            }

            catch (SmtpException ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }














            //MailMessage message = new MailMessage();

            //SmtpClient client = new SmtpClient();

            //client.Credentials = new NetworkCredential("ugur_ongun@outlook.com", "Mavis5902");
            //client.Port = 465;
            //client.UseDefaultCredentials = true;
            //client.Host = "smtp-mail.outlook.com";
            //client.EnableSsl = true;

            //message.To.Add(textBox1.Text);
            //message.From = new MailAddress("ugur_ongun@outlook.com", "Mavis5902");
            //message.Subject = "GÜVENLİK KODU";
            //message.Body = kod;

            //client.Send(message);

            //MessageBox.Show("MAİL GÖNDERİLDİ");





            //string senderEmail = "ugur_ongun@outlook.com";
            //string senderPassword = "Mavis5902";
            //string recipentEmail = textBox1.Text;

            //string subject = "GÜVENLİK KODU";
            //string body = kod;

            //SendEmail(senderEmail, senderPassword, recipentEmail, subject, body);



        }
        //static void SendEmail(string senderEmail, string senderPassword, string recipientEmail, string subject, string body)
        //{
        //    // Gönderici ve alıcı bilgilerini kullanarak MailMessage sınıfından bir nesne oluştur
        //    MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, body);

        //    // Gönderici hesabının bilgilerini kullanarak SmtpClient sınıfından bir nesne oluştur
        //    SmtpClient client = new SmtpClient("smtp.live.com", 587);
        //    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
        //    client.EnableSsl = true;

        //    // Mail gönderme işlemini gerçekleştir
        //    client.Send(mail);
        //}
    }
}
