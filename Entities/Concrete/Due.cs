using Core.Entities;

namespace Entities.Concrete
{
    public class Due : IEntity
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public double DueAmount { get; set; }
    }
}
