using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BrisaWebApiSample.Models.Filter
{
    public class ActionFilterSample : ActionFilterAttribute
    {

      
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}

