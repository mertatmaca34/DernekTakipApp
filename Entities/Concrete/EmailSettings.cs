using Core.Entities;

namespace Entities.Concrete
{
    public class EmailSettings : IEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
