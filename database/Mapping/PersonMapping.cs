using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class PersonMapping : EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            ToTable("Person");

            HasKey(x => x.Id);

            Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(DataLengthStandards.FirstName);

            Property(x => x.MiddleName)
                .HasColumnName("MiddleName")
                .HasMaxLength(DataLengthStandards.MiddleName);

            Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(DataLengthStandards.LastName);

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(DataLengthStandards.Title);

            Property(x => x.Location.Latitude)
                .HasColumnName("Latitude");

            Property(x => x.Location.Longitude)
                .HasColumnName("Longitude");

            HasMany(x => x.Tasks)
                .WithMany(x => x.Owners);

            HasMany(x => x.Posts)
                .WithRequired(x => x.PostAuthor)
                .WillCascadeOnDelete(false);

            HasMany(x => x.Comments)
                .WithRequired(x => x.CommentAuthor)
                .WillCascadeOnDelete(false);
        }
    }
}
