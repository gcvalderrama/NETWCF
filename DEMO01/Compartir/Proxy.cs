using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Compartir
{
    public class ProxyLog : ClientBase<ILog>, ILog
    {
        public ProxyLog(string config) : base(config) { }
        public void LogMessage(string message)
        {
            var w = new System.Diagnostics.Stopwatch();
            w.Start(); 
            base.Channel.LogMessage(message);
            w.Stop();
            Console.WriteLine(w.ElapsedMilliseconds.ToString());
        }

        public void LogMessageObject(LogMessage message)
        {
            base.Channel.LogMessageObject(message);
        }
    }
}
