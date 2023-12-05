using Core.Entities;

namespace Entities.Concrete
{
    public class DuePayment : IEntity
    {
        public int Id { get; set; }
        public int DueId { get; set; }
        public string MemberTC { get; set; }
        public string PaymentTotal { get; set; }
        public DateTime PaymentTime { get; set; }
    }
}
