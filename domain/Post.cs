using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class Post
    {
        public Post()
        {
            Comments = new List<PostComment>();
        }

        [Key]
        [Required]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public DateTime CreatedUTC { get; set; }
        [DataMember]
        public virtual Person PostAuthor { get; set; }
        [DataMember]
        public Guid PostAuthorId {get; set; }
        [DataMember]
        public List<PostComment> Comments { get; set; }
    }
}
