using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class MsSqlConnection : IConnection
    {
        private string _connectionString;

        public MsSqlConnection(string ConnectionString)
        {
            _connectionString = ConnectionString;   
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
            return "MsSqlConnection"; 
        }
    }
}
