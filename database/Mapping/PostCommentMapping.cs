using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class PostCommentMapping : EntityTypeConfiguration<PostComment>
    {
        public PostCommentMapping()
        {
            ToTable("PostComment");

            HasKey(x => x.Id);

            HasRequired(x => x.Post)
                .WithMany(x => x.Comments);

            Property(x => x.Text)
                .HasColumnName("Text")
                .HasMaxLength(DataLengthStandards.PostContent);

            Property(x => x.Visibliity)
                .HasColumnName("Visibility");

            HasRequired(x => x.CommentAuthor)
                .WithMany(x => x.Comments)
                .WillCascadeOnDelete(false);
        }
    }
}
