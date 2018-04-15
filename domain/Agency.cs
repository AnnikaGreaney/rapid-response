using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class Agency
    {
        [Key]
        [Required]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual Person Contact { get; set; }
        [DataMember]
        public string StreetAddress { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string County { get; set; }
        [DataMember]
        public GeoPosition GeoPosition { get; set; }
    }
}
