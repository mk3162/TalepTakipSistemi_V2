using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Session
{
    public class LoginAuthorization : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (SessionUserModel.CurrentUser == null)
            //{
            //    Controller controller = filterContext.Controller as Controller;
            //    string retUrl = HttpContext.Current.Request.Url.PathAndQuery;
            //    HttpContext.Current.Session["retUrl"] = retUrl;
            //    filterContext.Result = new RedirectResult("/Login/Index");
            //    return;
            //}
            //else
            //{
            //    base.OnActionExecuting(filterContext);
            //}
        }
    }
}
