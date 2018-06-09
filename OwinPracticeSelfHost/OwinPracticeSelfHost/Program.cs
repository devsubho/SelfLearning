using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinPracticeSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:1097";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Server is staring at.....{url}");
                Console.ReadKey();
            }
        }
    }
}
