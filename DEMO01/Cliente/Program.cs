using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente");
            Console.ReadLine();
            runtime();
            Console.ReadLine();  
        }
        public static  void runtime()
        {
            var proxy = new ChannelFactory<Compartir.ILog>("cliente").CreateChannel();
            proxy.LogMessage("log cliente");

            proxy.Trace(new Compartir.TraceRequest() { Audit = DateTime.Now.ToLongTimeString(), Message = "mensaje del cliente" });

            ((IClientChannel)proxy).Close();  
        }
        public static void customproxy()
        {
            var proxy = new Compartir.ProxyLog("cliente");
            proxy.LogMessage("log custom proxy");
            proxy.Close();  
        }

    }
}
