using Microsoft.EntityFrameworkCore;
using MidExam.Shared.Models;

namespace MidExam.Server.DataAccess
{
    public class DomainModelSqlContext : DbContext
    {
        public DomainModelSqlContext(DbContextOptions<DomainModelSqlContext> options):base(options) 
        { }
        public DbSet<Persons> Info { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

    }
}
