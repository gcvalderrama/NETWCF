using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;

namespace LogWinService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        protected ServiceHost host;  
        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(LogService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null) host.Close();  
        }
    }
}
