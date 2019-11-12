using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;

namespace CIS174.Filters
{
    public class RequestResponseLogAttribute:Attribute, IResourceFilter

    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Debug.WriteLine("Charles - LogResource Filter Executed");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Debug.WriteLine("Charles - LogResource Filter Executing");
        }
    }
}
