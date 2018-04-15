using NUnit.Framework;
using RapidResponse.database;
using System.Linq;

namespace RapidRespone.database.tests
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void CanCreateTheDatabaseSuccessfully()
        {
            // Arrange
             RapidResponseDbContext db = new RapidResponseDbContext();

            // Act
            var agencies = db.Agencies.ToList();

            // Assert

        }
    }
}
