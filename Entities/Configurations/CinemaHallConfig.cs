using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities.Configurations;

public class CinemaHallConfig : IEntityTypeConfiguration<CinemaHall>
{
    public void Configure(EntityTypeBuilder<CinemaHall> builder)
    {
        builder.Property(ch => ch.Cost).HasPrecision(precision: 9, scale: 2);
        builder.Property(ch => ch.CinemaHallType).HasDefaultValue(CinemaHallType.TwoDimensions);
    }
}
