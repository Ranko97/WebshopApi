using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Tracker_App_Api
{
    public class ConfigProperties
    {
        private string _connectionString;
        public string Secret { get; set; }

        public ConfigProperties()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            var config = builder.Build();
            //Secret = config.GetAppSettings("Secret");

            _connectionString = config.GetConnectionString("Default");
        }

        public String GetConnectionString()
        {
            return _connectionString;
        }
    }
}
