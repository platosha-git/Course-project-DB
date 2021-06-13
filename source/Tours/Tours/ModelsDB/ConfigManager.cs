using Microsoft.Extensions.Configuration;
using System;

namespace Tours
{
    public enum AccessLevel : int
    {
        Guest,
        Tourist,
        Manager
    }
    public static class ConfigManager
    {
        public static string GetConnectionString(AccessLevel lvl)
        {
            string connectionStr = null; 
            try
            {
                IConfiguration config = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .Build();

                if (lvl == AccessLevel.Manager)
                {
                    connectionStr = config["Connections:Manager"];
                }

                else if (lvl == AccessLevel.Tourist)
                {
                    connectionStr = config["Connections:Tourist"];
                }

                else if (lvl == AccessLevel.Guest)
                {
                    connectionStr = config["Connections:Guest"];
                }               
            }

            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }

            return connectionStr;
        }

        public static string GetLogFile()
        {
            string logStr = null;
            try
            {
                IConfiguration config = new ConfigurationBuilder()
                       .AddJsonFile("appsettings.json")
                       .Build();
                logStr = config["Logger"];
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }

            return logStr;
        }
    }
}
