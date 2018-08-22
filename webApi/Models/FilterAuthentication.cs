using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace webApi.Models
{
    public class TokenAuthenticationAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //if (actionContext.Request.Headers.Authorization != null)
            //{
            //    if (actionContext.Request.Headers.Authorization.Scheme == "Bearer")
            //    {
            //        if (!Library.validKey(actionContext.Request.Headers.Authorization.Parameter))
            //        {
            //            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden,
            //            new { Error = true, Message = "Token parametro NOT valid" });
            //        }
            //    }
            //    else
            //    {
            //        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.MethodNotAllowed,
            //           new { Error = true, Message = "Token esquema NOT valid" });
            //    }
            //}
            //else
            //{
            //    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NonAuthoritativeInformation,
            //        new { Error = true, Message = "Token NOT send" });
            //}
            return true;
        }
    }
}