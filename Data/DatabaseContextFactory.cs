
// using Data.Models;

// namespace Data
// {
//     public class DatabaseContextFactory
//     {
//         public AppDbContext CreateDbContext(string[] args)
//         {
//             var props = new ConfigProperties();
//             var connstr = props.ConnectionString;

//             if (string.IsNullOrWhiteSpace(connstr))
//             {
//                 throw new InvalidOperationException(
//                     "Could not find a connection string named 'Default'.");
//             }

//             var optionsBuilder =
//                  new DbContextOptionsBuilder<AppDbContext>();

//             optionsBuilder.UseSqlServer(connstr);

//             var options = optionsBuilder.Options;

//             return new AppDbContext();
//         }
//     }
// }
