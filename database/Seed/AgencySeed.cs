using RapidResponse.domain;
using System;

namespace RapidResponse.database.Seed
{
    public static class AgencySeed
    {
        public static void Seed(RapidResponseDbContext context)
        {
            Agency WestFargoPD = new Agency()
            {
                Id = new Guid("{FBDFBC45-5B59-4D70-9EA2-CA47EA3656E2}"),
                Name = "West Fargo Police Department",
                City = "West Fargo",
                StreetAddress = "800 4th Ave E #2",
                State = "ND",
                Zip = "58078",
                GeoPosition = new GeoPosition(46.8733591m, -96.8880235m)
            };

            Agency FargoPD = new Agency()
            {
                Id = new Guid("{300CB338-CFB1-499E-B530-D44286CA489E}"),
                Name = "Fargo Police Department",
                City = "Fargo",
                StreetAddress = "",
                State = "ND",
                Zip = "",
                GeoPosition = new GeoPosition(46.8787524m, -96.7871322m)
            };

            Agency MoorheadPD = new Agency()
            {
                Id = new Guid("{CFCC0300-F3AA-44E0-BBB3-A69B96D313D1}"),
                Name = "Moorhead Police Department",
                StreetAddress = "915 9 Ave N",
                City = "Moorhead",
                State = "MN",
                Zip = "56560",
                County = "Clay",
                GeoPosition = new GeoPosition(46.8866335m, -96.7852307m)
            };

            Agency NorthDakotaBCI = new Agency()
            {
                Id = new Guid("{2EC383D8-10C5-4280-A305-59A6186CB202}"),
                Name = "North Dakota Bureau of Criminal Investigation",
                StreetAddress = "4205 State St, State Capitol, 600 E Boulevard Ave, Dept 125",
                City = "Bismarck",
                State = "ND",
                Zip = "58505",
                County = "Burleigh",
                GeoPosition = new GeoPosition(46.851584m, -100.7729977m)
            };

            context.Agencies.Add(WestFargoPD);
            context.Agencies.Add(FargoPD);
            context.Agencies.Add(MoorheadPD);
            context.Agencies.Add(NorthDakotaBCI);
        }
    }
}
