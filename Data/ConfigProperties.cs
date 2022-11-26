// namespace Data
// {
//     public class ConfigProperties
//     {
//         public string ConnectionString { get; private set; }

//         public ConfigProperties()
//         {
//             var builder = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json");

//             var config = builder.Build();

//             ConnectionString = config.GetConnectionString("Default");
//         }
//     }
// }
