using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace CIS174.Filters
{
    public class FeatureEnabledAttribute : Attribute, IResourceFilter
    {
        public bool IsEnabled { get; set; }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Nothing to do here 
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!IsEnabled)
            {
                context.Result = new BadRequestResult();
            }
        }
    }

}
