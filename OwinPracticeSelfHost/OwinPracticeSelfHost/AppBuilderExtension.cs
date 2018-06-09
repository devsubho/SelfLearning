using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinPracticeSelfHost
{
    public static class AppBuilderExtension
    {
       public static IAppBuilder CustomWelcome(this IAppBuilder appBuilder)
        {
            return appBuilder.CustomWelcome(new WelcomeMessage("ITSL DT-12", "Welcome to this practice App"));
        }

        public static IAppBuilder CustomWelcome(this IAppBuilder appBuilder,WelcomeMessage obj)
        {
            return appBuilder.Use(typeof(CustomMiddleWare), new WelcomeMessage("ITSL DT-12", "Welcome to this practice App"));
        }

        public static IAppBuilder CustomWelcome2(this IAppBuilder appBuilder)
        {
            return appBuilder.CustomWelcome2(new WelcomeMessage("ITSL DT-12", "Welcome to this practice App"));
        }

        public static IAppBuilder CustomWelcome2(this IAppBuilder appBuilder, WelcomeMessage obj)
        {
            return appBuilder.Use(typeof(CustomMiddleware2), new WelcomeMessage("ITSL DT-12", "Welcome to this practice App"));
        }
    }
}
