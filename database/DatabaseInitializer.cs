using RapidResponse.database.Seed;
using System.Data.Entity;

namespace RapidResponse.database
{
    public class RapidResponseDatabaseInitializer : DropCreateDatabaseAlways<RapidResponseDbContext>
    //    public class RapidResponseDatabaseInitializer : DropCreateDatabaseIfModelChanges<RapidResponseDbContext>
    {
        public override void InitializeDatabase(RapidResponseDbContext context)
        {
            if (context.Database.Exists())
            {
                // Set the database to SINGLE_USER so it can be dropped
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                                                   string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE",
                                                   context.Database.Connection.Database));
            }
            base.InitializeDatabase(context);
        }
        
        protected override void Seed(RapidResponseDbContext context)
        {
            base.Seed(context);
            AgencySeed.Seed(context);
            PersonSeed.Seed(context);
            TaskItemSeed.Seed(context);
            PostSeed.Seed(context);
            context.SaveChanges();
        }
    }
}