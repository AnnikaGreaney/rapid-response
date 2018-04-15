using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class TaskItem
    {
        public TaskItem()
        {
            Owners = new List<Person>();
        }

        [Key]
        [Required]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public TaskPriority Priority {get; set; }
        [DataMember]
        public TaskStatus Status { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public GeoPosition Location { get; set; }
        [DataMember]
        public DateTime CreatedUTC { get; set; }
        [DataMember]
        public DateTime? CompletedUTC { get; set; }
        [DataMember]
        public List<Person> Owners { get; set; }
    }
}
