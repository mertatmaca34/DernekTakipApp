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
        public async Task<string> MailSend(string mailName, string subject, string body)
        {
            SmtpClient smtpClient = new()
            {
                EnableSsl = true,
                Port = 587,
                Host = "smtp-mail.outlook.com",
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("mertemirgorsel@outlook.com", "mertemir123")
            };

            MailMessage mailMessage = new()
            {
                From = new MailAddress("mertemirgorsel@outlook.com"),
                Subject = $"programdan",
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(mailName);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);

                return "success";
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);

                return ex.Message;
            }
        }
    }
}
