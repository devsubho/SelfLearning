using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinPracticeSelfHost
{
    public class CustomMiddleWare : OwinMiddleware
    {
        private readonly WelcomeMessage _option;
        public CustomMiddleWare(OwinMiddleware owinmiddleware,WelcomeMessage option) : base(owinmiddleware)
        {
            this._option = option;
        }

        public override async Task Invoke(IOwinContext owinContext)
        {
            Console.WriteLine($"This is from Custom Middleware. HTTP Requests getting at : {DateTime.Now.ToLocalTime()} ");
            await Next.Invoke(owinContext);

            string welcome = $"This is your Host : {_option.HostName}.{_option.Message}{Environment.NewLine}{Environment.OSVersion}{Environment.NewLine}";
            await owinContext.Response.WriteAsync(welcome).ConfigureAwait(false);
        }
    }
}
