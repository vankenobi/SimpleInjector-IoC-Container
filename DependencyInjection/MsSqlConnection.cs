using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class MsSqlConnection : IConnection
    {
        public string GetData()
        {
            return "MsSqlConnection"; 
        }
    }
}
