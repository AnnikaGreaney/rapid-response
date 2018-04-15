using RapidResponse.domain;
using System;
using System.Linq;

namespace RapidResponse.database.Seed
{
    public static class PostSeed
    {
        public static void Seed(RapidResponseDbContext context)
        {
            Person officer = context.People.Where(x => x.FirstName == "Heith" && x.LastName == "Jahnke").Single();

            Post firstPost = new Post()
            {
                Id = new Guid("{3540C048-142B-43E3-875D-3B5F0AE5C839}"),
                Title = "Child reporting missing from near South Elementary",
                Content = "A child was reported missing near the South Elementary School. A stranger in a white panel van, possibly a late model Ford. The child's grandmother was supposed to pick up the child after school and remained there until 4:00pm and reported to the office that her granddaughter did not show up at her car. The girl is picked up by her grandmother daily. The girl was last seen wearing a red sweater, blue jeans, and white sneakers. She is approximately 4'6 with shoulder length straight blonde hair in a pony tail, blue eyes, and glasses.",
                CreatedUTC = DateTime.UtcNow,
                PostAuthor = officer
            };

            context.Posts.Add(firstPost);
        }
    }
}
