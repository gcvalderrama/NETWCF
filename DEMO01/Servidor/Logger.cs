using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Servidor
{
    [ServiceBehavior( 
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public  class Logger :  Compartir.ILog
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);  
        }
        public void LogMessageObject(Compartir.LogMessage message)
        {
            Console.WriteLine(message.ToString());  
        }
    }
}
