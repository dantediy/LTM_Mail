using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mail;

namespace Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                Attachment file = new Attachment("D:\\textfile.txt");
                message.Attachments.Add(file);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(txtSender.Text, txtPass.Text);
            MailMessage message = new MailMessage(txtSender.Text, txtTo.Text);
            message.Subject = txtSubject.Text;
            message.Body = txtContent.Text;
            mailclient.Send(message);
        }
    }
}
