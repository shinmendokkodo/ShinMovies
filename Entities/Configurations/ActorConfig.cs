using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities.Configurations;

public class ActorConfig : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(a => a.Name).IsRequired();
        builder.Property(a => a.Biography).HasColumnType("nvarchar(max)");
    }
}
