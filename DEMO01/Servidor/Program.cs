using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server");  
            var host = new ServiceHost(typeof(Logger));
            host.Open();
            Console.ReadLine();
            host.Close();  
        }
    }
}
