using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Compartir
{
    [DataContract]
    public class LogMessage
    {
        [DataMember]
        public string text {get;set;}
        [DataMember]
        public DateTime date {get;set;}
    }

    [ServiceContract]
    public interface ILog
    {
        [OperationContract]
        void LogMessage(string message);
        [OperationContract]
        void LogMessageObject(LogMessage message);
        [OperationContract]
        TraceResponse Trace(TraceRequest trace);

    }
}
