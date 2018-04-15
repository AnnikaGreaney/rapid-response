using RapidResponse.database.Mapping;
using RapidResponse.domain;
using System;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace RapidResponse.database
{
    public class RapidResponseDbContext : DbContext
    {
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public RapidResponseDbContext() : base()
        {
            InitializeContext();
        }

        public RapidResponseDbContext(string connectionString) : base(connectionString)
        {
            InitializeContext();
        }

        private void InitializeContext()
        {
            System.Data.Entity.Database.SetInitializer(new RapidResponseDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AgencyMapping())
                                       .Add(new GeoPositionMapping())
                                       .Add(new PersonMapping())
                                       .Add(new PostMapping())
                                       .Add(new PostCommentMapping())
                                       .Add(new TaskItemMapping());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            UpdateDates();
            return base.SaveChanges();
        }

        private void UpdateDates()
        {
            foreach (var change in ChangeTracker.Entries<RapidResponseDbContext>())
            {
                var values = change.CurrentValues;
                foreach (var name in values.PropertyNames)
                {
                    var value = values[name];
                    if (value is DateTime)
                    {
                        var date = (DateTime)value;
                        if (date < SqlDateTime.MinValue.Value)
                        {
                            values[name] = SqlDateTime.MinValue.Value;
                        }
                        else if (date > SqlDateTime.MaxValue.Value)
                        {
                            values[name] = SqlDateTime.MaxValue.Value;
                        }
                    }
                }
            }
        }
    }
}
