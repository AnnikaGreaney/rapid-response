using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class PostComment
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public Post Post { get; set; }
        public Guid PostId { get; set; }
        public DateTime Created { get; set; }
        public virtual Person CommentAuthor { get; set; }
        public Guid CommentAuthorId { get; set; }
        public string Text { get; set; }
        public Visibility Visibliity { get; set; }
    }
}
