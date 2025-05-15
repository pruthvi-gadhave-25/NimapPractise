//using System.Web.Mvc;
using EcomMvc.Migrations;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EcomMvc.Filters
{
    public class AdminAuditLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);

            var user = filterContext.HttpContext.User.Identities;
            Console.WriteLine("OnActionExecuting Create ");

            var controller = filterContext.RouteData.Values["controller"]?.ToString();
            var action = filterContext.RouteData.Values["action"]?.ToString();

            Console.WriteLine($"[Audit] {user} executed {controller}/{action}");
        }

    }
}
