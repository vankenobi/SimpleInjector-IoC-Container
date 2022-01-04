using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class PostgreSqlConnection : IConnection
    {
        public string GetData()
        {
            return "PostgreSqlConnection";
        }
    }
}
