using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.IO;

namespace LogWebApp
{
    [AspNetCompatibilityRequirements( RequirementsMode= AspNetCompatibilityRequirementsMode.Required)]
    public class LogService : Compartir.ILog
    {
        public void LogMessage(string message)
        {
           
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/salida.txt", message);

            //HttpContext.Current.Trace.Warn(message); 
        }
        

        public void LogMessageObject(Compartir.LogMessage    message)
        {
            throw new NotImplementedException();
        }


        public Compartir.TraceResponse Trace(Compartir.TraceRequest trace)
        {
            throw new NotImplementedException();
        }
    }
}