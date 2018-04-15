using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class PostMapping : EntityTypeConfiguration<Post>
    {
        public PostMapping()

        {
            ToTable("Post");

            HasKey(x => x.Id);

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(DataLengthStandards.PostTitle);

            Property(x => x.Content)
                .HasColumnName("Content");

            Property(x => x.CreatedUTC)
                .HasColumnName("CreatedUTC");

            HasRequired(x => x.PostAuthor)
                .WithMany(x => x.Posts)
                .WillCascadeOnDelete(false);
        }
    }
}
