using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chest.Persistence
{
    public class StuffConfiguration : IEntityTypeConfiguration<Domain.Stuff>
    {
        public void Configure(EntityTypeBuilder<Domain.Stuff> builder)
        {
            builder.HasKey(Stuff => Stuff.Id);
            builder.HasIndex(Stuff => Stuff.Id).IsUnique();
        }

    }
}
