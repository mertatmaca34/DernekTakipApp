using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class DTPContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DernekTakipContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TCKN'yi birincil anahtar olarak belirt
            modelBuilder.Entity<Member>().HasKey(m => m.TcKimlik);
        }

        public DbSet<Member>? Members { get; set; }
        public DbSet<Due>? Dues { get; set; }
        public DbSet<DuePayment>? DuePayments { get; set; }
        public DbSet<EmailSettings>? EmailSettings { get; set; }
    }
}
