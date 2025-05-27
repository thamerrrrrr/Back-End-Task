using Microsoft.EntityFrameworkCore;
using ThamerDraidi_Task1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace ThamerDraidi_Task1.Data
   
{
   public class ApplicationDbContext: DbContext

    {
        public DbSet<User> users { set; get; }
        public DbSet<Blog> blogs { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=ASP11_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
