using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    class DairyContext : DbContext
    {
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=DairyDb; Username=postgres; Password=2651");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dairy>(entity =>
            {
                entity.ToTable("agenda", "First");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).UseSerialColumn(); 
            });
        }

        public DbSet<Dairy> agenda { get; set; }



    }


    }

