using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinPracticeSelfHost
{
    public class CustomMiddleware2 : OwinMiddleware
    {
        public readonly WelcomeMessage _option;

        public CustomMiddleware2(OwinMiddleware next,WelcomeMessage option) : base(next)
        {
            this._option = option;
        }

        public override async Task Invoke(IOwinContext context)
        {
            Console.WriteLine("This is from MiddleWare2");
            string welcome = $"This is from Host : {_option.HostName}.{_option.Message}";
            await context.Response.WriteAsync(welcome).ConfigureAwait(false);
        }
    }
}
