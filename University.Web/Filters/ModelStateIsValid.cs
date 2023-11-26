﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace University.Web.Filters
{
    public class ModelStateIsValid : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ViewResult
                {
                    StatusCode = 400,
                    TempData = ((Controller)context.Controller).TempData,
                    ViewData = ((Controller)context.Controller).ViewData
                };
            }
        }
    }
}
