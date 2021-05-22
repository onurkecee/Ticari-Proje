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

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMailAdres.Text = mail;
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("deneme mail", "şifre");
            client.Port = 587;
            client.Host = "smtp.outlook.com";
            client.EnableSsl = true;
            mesaj.To.Add(txtMailAdres.Text);
            mesaj.From = new MailAddress("deneme mail");
            mesaj.Subject = txtKonu.Text;
            mesaj.Body = txtMesaj.Text;
            client.Send(mesaj);
            MessageBox.Show("Mesaj Gönderildi");
        }
    }
}
