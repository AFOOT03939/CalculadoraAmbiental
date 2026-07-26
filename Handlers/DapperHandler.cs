using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CalculadoraAmbienta.Handlers
{
    public class DapperHandler
    {
        private const string ConnectionString = "Data Source=CalculadoraAmbiental.db";

        public IDbConnection CreateConnection()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}
