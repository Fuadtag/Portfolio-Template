using System.Web.Mvc;

namespace _20191910WeekendTask.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Login", controller = "Login", id = UrlParameter.Optional },
                namespaces: new string[]{"_20191910WeekendTask.Areas.Admin.Controllers"}
                
            );
           
        }
    }
}