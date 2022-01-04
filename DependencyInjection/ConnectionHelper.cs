using System;
using System.Collections.Generic;
using System.Text;
using SimpleInjector;


namespace DependencyInjection
{
    public class ConnectionHelper
    {
        private IConnection _connection;

        public ConnectionHelper(IConnection connection)
        {
            _connection = connection;
        }

        public string GetData() 
        {
            return _connection.GetData();
        }
    }
}
