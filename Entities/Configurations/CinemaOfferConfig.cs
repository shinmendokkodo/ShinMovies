using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies.Entities.Configurations;

public class CinemaOfferConfig : IEntityTypeConfiguration<CinemaOffer>
{
    public void Configure(EntityTypeBuilder<CinemaOffer> builder)
    {
        builder.Property(co => co.DiscountPercentage).HasPrecision(precision: 5, scale: 2);
    }
}
