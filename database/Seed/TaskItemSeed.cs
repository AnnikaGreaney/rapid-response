using RapidResponse.domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RapidResponse.database.Seed
{
    public static class TaskItemSeed
    {
        public static void Seed(RapidResponseDbContext context)
        {
            Person detectiveLykken = context.People.Where(x => x.LastName == "Lykken").Single();

            TaskItem firstTask = new TaskItem()
            {
                Id = new Guid("{49113D88-ABC1-4169-A55E-D825974DC337}"),
                Description = "Possible sighting of child and suspect at 117 6th Ave W, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8676976m, -96.894285m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem secondTask = new TaskItem()
            {
                Id = new Guid("{43866F57-56A4-4836-83D5-9DD6A822AAE4}"),
                Description = "Possible sighting of child and suspect at 501 Main Ave E, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8746439m, -96.8930728m),
                Owners = new List<Person>() { detectiveLykken }
            };


            TaskItem thirdTask = new TaskItem()
            {
                Id = new Guid("{D636D33E-F3D8-4E69-B0DC-B34D3A648520}"),
                Description = "Possible sighting of child and suspect at 825 Main Ave E, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8746439m, -96.8930728m),
                Owners = new List<Person> { detectiveLykken }
            };

            TaskItem fourthTask = new TaskItem()
            {
                Id = new Guid("{F970D39B-DE30-4DFC-88E6-F4C5A75A2851}"),
                Description = "Possible sighting of child and suspect at 1100 13th Ave E, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8634012m, -96.882675m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem fifthTask = new TaskItem()
            {
                Id = new Guid("{E4C1AAD9-6F5A-412A-899F-6667948DEDC4}"),
                Description = "Possible sighting of child and suspect at 1410 13th Ave E, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8618309m, -96.8770229m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem sixthTask = new TaskItem()
            {
                Id = new Guid("{68036303-F304-4520-B3A4-9AFD7D2704AA}"),
                Description = "Possible sighting of child and suspect at 1660 13th Ave E, West Fargo, ND 58078",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8616128m, -96.8745476m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem seventhTask = new TaskItem()
            {
                Id = new Guid("{7658C203-B702-476E-840E-2DCAE4590035}"),
                Description = "Possible sighting of child and suspect at 7263, 4971 13th Ave S, Fargo, ND 58103",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8614557m, -96.8691252m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem eighthTask = new TaskItem()
            {
                Id = new Guid("{F22791B7-4583-449B-AC8F-0E5F26049AAF}"),
                Description = "Possible sighting of child and suspect",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8616651m, -96.8644363m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem ninthTask = new TaskItem()
            {
                Id = new Guid("{BD51BCFF-00FA-403F-B3B2-D345000065D4}"),
                Description = "Possible sighting of child and suspect",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8617567m, -96.8629818m),
                Owners = new List<Person>() { detectiveLykken }
            };

            TaskItem tenthTask = new TaskItem()
            {
                Id = new Guid("{2C7CDA4D-8D5D-4AE3-B882-890B30C8325E}"),
                Description = "Possible sighting of child and suspect",
                CreatedUTC = DateTime.UtcNow,
                CompletedUTC = null,
                Priority = TaskPriority.High,
                Status = domain.TaskStatus.Assigned,
                Location = new GeoPosition(46.8618723m, -96.8610584m),
                Owners = new List<Person>() { detectiveLykken }
            };

            context.TaskItems.Add(firstTask);
            context.TaskItems.Add(secondTask);
            context.TaskItems.Add(thirdTask);
            context.TaskItems.Add(fourthTask);
            context.TaskItems.Add(fifthTask);
            context.TaskItems.Add(sixthTask);
            context.TaskItems.Add(seventhTask);
            context.TaskItems.Add(eighthTask);
            context.TaskItems.Add(ninthTask);
            context.TaskItems.Add(tenthTask);
        }
    }
}
