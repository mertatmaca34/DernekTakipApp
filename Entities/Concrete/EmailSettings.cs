﻿using Core.Entities;

namespace Entities.Concrete
{
    public class EmailSettings : IEntity
    {
        public int Id { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public bool IncludeDebtInfo { get; set; }
    }
}
