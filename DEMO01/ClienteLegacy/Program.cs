using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente legacy ");
            var p = new Proxy.Logger();
            p.LogMessage("legacy  client");
            Console.ReadLine();
        }
    }
}
