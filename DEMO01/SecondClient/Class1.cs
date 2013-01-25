using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondClient
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente");
            Console.ReadLine();

            var p = new Proxy.LogClient();
            p.LogMessage("proxy  auto ");
            p.Close();  

            Console.ReadLine();
        }
    }
}
