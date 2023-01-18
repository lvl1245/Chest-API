using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest.Persistence
{
    public class ChestConfiguration : IEntityTypeConfiguration<Domain.Chest> 
    {
        public void Configure(EntityTypeBuilder<Domain.Chest> builder)
        {
            builder.HasKey(Chest => Chest.Id);
            builder.HasIndex(Chest => Chest.Id).IsUnique();
            builder.HasMany(Chest => Chest.StuffCollection);
            
        }

    }
}
