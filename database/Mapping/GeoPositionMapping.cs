using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class GeoPositionMapping : ComplexTypeConfiguration<GeoPosition>
    {
        public GeoPositionMapping()
        {
            Property(x => x.Latitude)
                .HasColumnName("Latitude");
            Property(x => x.Longitude)
                .HasColumnName("Longitude");
        }
    }
}
