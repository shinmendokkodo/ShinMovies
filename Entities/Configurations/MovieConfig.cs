using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities.Configurations;

public class MovieConfig : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(m => m.Title).HasMaxLength(250).IsRequired();
        builder.Property(m => m.PosterUrl).HasMaxLength(500).IsUnicode(false);
    }
}
