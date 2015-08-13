using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ModelBinder.Binders;

namespace ModelBinder
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

        public override void Init()
        {
            base.Init();
            ModelBinders.Binders.Remove(typeof(DateTime?));
            ModelBinders.Binders.Add(typeof(DateTime?), new DateTimeBinder());
        }
    }
}
