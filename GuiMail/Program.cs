﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace GuiMail
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential("abc@gmail.com", "password");
            MailMessage message = new MailMessage("abc@gmail.com","xyz@gmail.com");
            message.Subject = "Hello!";
            message.Body = "Im abc!";
            mailclient.Send(message);
            Console.WriteLine("Mail sent successfully!");
        }
    }
}
