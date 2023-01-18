using Chest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest.Persistence
{
    public class ChestTypeConfiguration : IEntityTypeConfiguration<ChestType>
    {
        public void Configure(EntityTypeBuilder<ChestType> builder)
        {
            builder.HasKey(ChestType => ChestType.Id);
            builder.HasIndex(ChestType => ChestType.Id).IsUnique();
        }
    }
}
