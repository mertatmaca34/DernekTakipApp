using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Email
{
    public class EmailService : IEmailService
    {
        public async Task<string> MailSend(string host, string port, string userName, string password, bool useSSL, bool useDefaultCredentials, string mailName, string subject, string body)
        {
            SmtpClient smtpClient = new()
            {
                EnableSsl = useSSL,
                Port = Convert.ToInt32(port),
                Host = host,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = useDefaultCredentials,
                Credentials = new NetworkCredential(userName, password)
            };

            MailMessage mailMessage = new()
            {
                From = new MailAddress(userName),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(mailName);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);

                return "Mail başarıyla gönderildi";
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);

                return ex.Message;
            }
        }
    }
}
