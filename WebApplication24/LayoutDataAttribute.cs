using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication24
{
    public class LayoutDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var rnd = new Random();
            filterContext.Controller.ViewBag.Number = rnd.Next(1, 1000);
            //filterContext.HttpContext.User.Identity.IsAuthenticated
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}