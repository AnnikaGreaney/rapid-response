using RapidResponse.domain;
using System;
using System.Collections.Generic;

namespace RapidResponse.database.Seed
{
    public static class PersonSeed
    {
        public static void Seed(RapidResponseDbContext context)
        {
            Person ChiefJahnke = new Person()
            {
                Id = new Guid("{0EC303A1-9033-405E-A69A-8B09E1226403}"),
                FirstName = "Heith",
                LastName = "Jahnke",
                Title = "Chief of Police",
                Posts = new List<Post>(),
                Comments = new List<PostComment>(),
                Tasks = new List<TaskItem>(),
                Location = new GeoPosition(46.8733591m, -96.8880235m)
            };

            Person AssistantChiefBoyer = new Person()
            {
                Id = new Guid("{D087DF93-5DE3-4A9A-A2A4-F5E6BD834B2A}"),
                FirstName = "Jerry",
                LastName = "Boyer",
                Title = "Assistant Chief of Police",
                Posts = new List<Post>(),
                Comments = new List<PostComment>(),
                Tasks = new List<TaskItem>(),
                Location = new GeoPosition(46.8733591m, -96.8880235m)
            };

            Person OfficerTravisJohnson = new Person()
            {
                Id = new Guid("{9998156C-1DFA-4656-8A91-CD86F8B4B74B}"),
                FirstName = "Travis",
                LastName = "Johnson",
                Title = "Detective",
                Posts = new List<Post>(),
                Comments = new List<PostComment>(),
                Tasks = new List<TaskItem>(),
                Location = new GeoPosition(46.8733591m, -96.8880235m)
            };

            Person LieutenantWarren = new Person()
            {
                Id = new Guid("{37F1FA59-AF2A-44CF-98A8-18500571569D}"),
                FirstName = "Greg",
                LastName = "Warren",
                Title = "Lieutenant",
                Posts = new List<Post>(),
                Comments = new List<PostComment>(),
                Tasks = new List<TaskItem>(),
                Location = new GeoPosition(46.8733591m, -96.8880235m)
            };

            Person DetectiveLykken = new Person()
            {
                Id = new Guid("{F8A5FE35-06B7-4499-A3CF-E0E945259523}"),
                FirstName = "Mark",
                LastName = "Lykken",
                Title = "Detective",
                Posts = new List<Post>(),
                Comments = new List<PostComment>(),
                Tasks = new List<TaskItem>(),
                Location = new GeoPosition(46.8733591m, -96.8880235m)
            };

            context.People.Add(ChiefJahnke);
            context.People.Add(AssistantChiefBoyer);
            context.People.Add(LieutenantWarren);
            context.People.Add(OfficerTravisJohnson);
            context.People.Add(DetectiveLykken);

            context.SaveChanges();
        }
    }
}
