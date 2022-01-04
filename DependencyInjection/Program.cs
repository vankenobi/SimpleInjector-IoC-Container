using SimpleInjector;
using System;

namespace DependencyInjection
{
    public class Program
    {
        private ConnectionHelper _connectionHelper;
        public Program(IConnection connection)
        {
            _connectionHelper = new ConnectionHelper(new PostgreSqlConnection());
        }
        public string GetData()
        {
            return _connectionHelper.GetData();
        }
        static void Main(string[] args)
        {
            Program program = new Program(new MsSqlConnection());
            string output = program.GetData();
            Console.WriteLine(output);
        }
    }
}
