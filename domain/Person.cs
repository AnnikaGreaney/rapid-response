using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class Person
    {
        #region Constructors

        public Person()
        {
            Tasks = new List<TaskItem>();
            Posts = new List<Post>();
        }

        #endregion 

        [Key]
        [Required]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public GeoPosition Location { get; set; }
        [DataMember]
        public List<TaskItem> Tasks { get; set; }
        [DataMember]
        public List<Post> Posts { get; set; }
        [DataMember]
        public List<PostComment> Comments { get; set; }
    }
}
