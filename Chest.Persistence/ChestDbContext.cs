using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chest.Domain.Interfaces;
using Chest.Domain;

namespace Chest.Persistence
{
    public class ChestDbContext : DbContext , IChestDbContext
    {
        
       public DbSet<ChestType> chestTypes { get; set; }
       public DbSet<Domain.Chest>? Chests { get; set; }
       public DbSet<Stuff>? Stuffs { get ; set ; }

        public ChestDbContext(DbContextOptions<ChestDbContext> options)
            : base(options) { }
        ChestDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ChestTypeConfiguration());
            builder.ApplyConfiguration(new ChestConfiguration());
            builder.ApplyConfiguration(new StuffConfiguration());
            
            base.OnModelCreating(builder);
        }

        
       
    }
}
