using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinPracticeSelfHost
{
    public class WelcomeMessage
    {
        public string HostName { get; set; }
        public string Message { get; set; }
        public WelcomeMessage(string HostName,string Message)
        {
            this.HostName = HostName;
            this.Message = Message;
        }
    }

}
