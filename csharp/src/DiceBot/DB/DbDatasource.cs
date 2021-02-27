using Npgsql;
using System.Data;
using System.Configuration;
using System;

namespace Dice.Sample.Bot.DB
{
    public class DbDatasource
    {
        public DbDatasource() { }

        public static IDbConnection getConnection()
        {
            // Get connectionString from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["postgres"].ConnectionString;

            // Connect to a PostgreSQL database
            IDbConnection Connection = new NpgsqlConnection(connectionString);

            return Connection;
        }

    }
}
