using System;
using DependencyInjection;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace IoC_Container
{
    class Program
    {
        static readonly Container container;
        static Program()
        {
            container = new Container();
            container.Register<IConnection>(() => new MsSqlConnection("connectionString"),Lifestyle.Transient);   // You should remove the comment for singleton example
            //container.Register<IConnection>(() => new MsSqlConnection("connectionString"), Lifestyle.Singleton);  // You should remove the comment for singleton example
            container.Verify();
        }
        static void Main(string[] args)
        {
            
            var result = container.GetInstance<IConnection>(); // There gives an instance from MsSqlConnection class if i call GetInstance method.
            result.SetConnectionString("connectionString is changed."); // I created two instance for see the different between Singleton and Transient and i changed connection string value of first instance at this line
            Console.WriteLine(result.GetConnectionString());

            var result2 = container.GetInstance<IConnection>();
            Console.WriteLine(result2.GetConnectionString());


        }
    }
}
