using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1_EF
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Task> Taasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB1_EF;Integrated Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .ToTable("NewTask");

            modelBuilder.Entity<Task>()
                .Property(x => x.Date)
                .HasColumnName("Deadline");
        }
    }
}
