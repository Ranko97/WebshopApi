using Microsoft.EntityFrameworkCore;
using Webshop.Data;

namespace Tracker_App_Api.Data
{
    public class DatabaseContextFactory
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var connstr = new ConfigProperties().GetConnectionString();

            if (string.IsNullOrWhiteSpace(connstr))
            {
                throw new InvalidOperationException(
                    "Could not find a connection string named 'Default'.");
            }

            var optionsBuilder =
                 new DbContextOptionsBuilder<DatabaseContext>();

            optionsBuilder.UseSqlServer(connstr);

            var options = optionsBuilder.Options;

            return new DatabaseContext(options, null);
        }
    }
}
