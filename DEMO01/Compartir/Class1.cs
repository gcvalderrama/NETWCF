using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

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

    [ServiceContract ()]
    public interface ILog
    {
        [OperationContract(IsOneWay = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void LogMessage(string message);
        [OperationContract(IsOneWay = true)]
        void LogMessageObject(LogMessage message);
        //[OperationContract]
        //TraceResponse Trace(TraceRequest trace);       

    }
    [ServiceContract]
    public interface ILogQuery
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json )]
        List<string> GetMessages();  

 
    }

}
