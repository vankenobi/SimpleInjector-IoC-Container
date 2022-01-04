using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class PostgreSqlConnection : IConnection
    {
        private string _connectionString;
        public PostgreSqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public void SetConnectionString(string value) 
        {
            _connectionString = value;
        }

        public string GetData()
        {
            return "PostgreSqlConnection";
        }
    }
}
