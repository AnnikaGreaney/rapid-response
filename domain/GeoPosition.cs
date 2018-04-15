using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RapidResponse.domain
{
    [DataContract]
    public class GeoPosition
    {
        #region Constructors

        public GeoPosition()
        {
        }

        public GeoPosition(decimal lat, decimal lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        #endregion

        #region Properties

        [DataMember]
        [Range(typeof(decimal), "-90.0", "90")]
        public decimal Latitude { get; set; }

        [DataMember]
        [Range(typeof(decimal), "-180.0", "180")]
        public decimal Longitude { get; set; }

        #endregion
    }
}
