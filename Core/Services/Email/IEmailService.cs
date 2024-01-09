using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Email
{
    public interface IEmailService
    {
        public Task<string> MailSend(string host, string port, string userName, string password, bool useSSL,
            bool useDefaultCredentials, string mailName, string subject, string body);
    }
}
