using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Transactions;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.WindowsPrincipal);
            Console.WriteLine("Cliente");
            Console.ReadLine();

            //var p = new legacyproxy.LegacyServiceSoapClient();  
            //p.HelloWorld()
            RuntimeSecurity();
            Console.ReadLine();  
        }

        public static void RuntimeSecurity()
        {
            var factory = new ChannelFactory<Compartir.ILog>("basic");
            //factory.Credentials.UserName.UserName = "developer";
            //factory.Credentials.UserName.Password = "Pa$$w0rd";  
            factory.Credentials.Windows.ClientCredential = System.Net.CredentialCache.DefaultNetworkCredentials;
            
            var proxy = factory.CreateChannel();

            proxy.LogMessage("cliente at " + DateTime.Now.ToLongTimeString() );  


        }

        public static  void runtime()
        {
            var proxy = new ChannelFactory<Compartir.ILog>("cliente").CreateChannel();





            try
            {
                using (var scope = new TransactionScope())
                {
                    proxy.LogMessage("log cliente");
                    proxy.LogMessage("queue test");
                    scope.Complete();  
                }            
            }
            catch (Exception ex)
            {
                
                
            }

        
            
    

            //proxy.Trace(new Compartir.TraceRequest() { Audit = DateTime.Now.ToLongTimeString(), Message = "mensaje del cliente" });

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
