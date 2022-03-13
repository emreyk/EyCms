using EyCms.CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EyCms.REPOSITORY
{
    public class EyCmsContext : DbContext
    {
        public EyCmsContext(DbContextOptions<EyCmsContext> options) : base(options)
        {

        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Setting { get; set; }

    }
}
