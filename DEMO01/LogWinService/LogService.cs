using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LogWinService
{
    public class LogService : Compartir.ILog
    {
        public void LogMessage(string message)
        {
            File.AppendAllText(@"C:\NETWCF\NETWCF\DEMO01\LogWinService\bin\Debug\salida.txt", message);
        }

        public void LogMessageObject(Compartir.LogMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
