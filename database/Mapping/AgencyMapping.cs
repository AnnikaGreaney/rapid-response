using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class AgencyMapping : EntityTypeConfiguration<Agency>
    {
        public AgencyMapping()
        {
            ToTable("Agency");

            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(DataLengthStandards.LegalName);

            Property(x => x.StreetAddress)
                .HasColumnName("StreetAddress")
                .HasMaxLength(DataLengthStandards.StreetAddress);

            Property(x => x.City)
                .HasColumnName("City")
                .HasMaxLength(DataLengthStandards.City);

            Property(x => x.State)
                .HasColumnName("State")
                .HasMaxLength(DataLengthStandards.State);

            Property(x => x.Zip)
                .HasColumnName("Zip")
                .HasMaxLength(DataLengthStandards.ZipCode);

            Property(x => x.County)
                .HasColumnName("County")
                .HasMaxLength(DataLengthStandards.County);

            Property(x => x.GeoPosition.Latitude)
                .HasColumnName("Latitude");

            Property(x => x.GeoPosition.Longitude)
                .HasColumnName("Longitude");

        }
    }
}
