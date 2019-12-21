using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TransportWebAPI
{
    public interface IEmailSendingClient
    {
       void SendLogEmail(string logMessage);
    }

    public class EmailSendingClient : IEmailSendingClient
    {
        private SmtpClient smtpClient;
        public EmailSendingClient()
        {
            smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com", // set your SMTP server name here
                Port = 587, // Port 
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("atomicspedlog@gmail.com", "atomic1234")
                
            };
        }

        public async void SendLogEmail(string logMessage)
        {
            using (var message = new MailMessage("atomicspedlog@gmail.com", "atomicspedlog@gmail.com")
            {
                Subject = "Atomic Sped Log",
                Body = logMessage
            })
            {
                await smtpClient.SendMailAsync(message);
            }
        }
    }
}
