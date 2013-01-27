using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace Servidor
{
    public class BLogica
    {
        
        public void Pagar(string juan)
        {
            var vl = new BLogica();
            vl.Pagar("juan");

        }
    }




    [ServiceBehavior( 
        InstanceContextMode = InstanceContextMode.PerSession, 
        ConcurrencyMode = ConcurrencyMode.Single,
         TransactionAutoCompleteOnSessionClose =  true, 
          ReleaseServiceInstanceOnTransactionComplete = true)]
    public  class Logger :  Compartir.ILog
    {
        public Logger() {
            Console.WriteLine("Construccion " + DateTime.Now.ToLongTimeString());
        }
        
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true )]
        public void LogMessage(string message)
        {         
            Console.WriteLine(message);  
        }
        public void LogMessageObject(Compartir.LogMessage message)
        {
            Console.WriteLine(message.ToString());  
        }


        public Compartir.TraceResponse Trace(Compartir.TraceRequest trace)
        {
            return new Compartir.TraceResponse();
        }
    }
}
