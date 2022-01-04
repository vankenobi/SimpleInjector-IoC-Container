using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IConnection
    {
        string GetData();

        string GetConnectionString();

        void SetConnectionString(string value);
    }
}
