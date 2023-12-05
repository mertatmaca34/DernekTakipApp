using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class IBKSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=IBKSContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Due> Dues { get; set; }
        public DbSet<DuePayment> DuePayments { get; set; }
        public DbSet<EmailSettings> EmailSettings { get; set; }
    }
}
