using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Compartir
{
    [MessageContract]
    public class TraceRequest
    {
        [MessageHeader]
        public string Audit { get; set; }
        [MessageBodyMember]
        public string Message { get; set; }
        [MessageBodyMember]
        public string UIMessage { get; set; }
    }
    [MessageContract]
    public class TraceResponse
    {

    }
}
