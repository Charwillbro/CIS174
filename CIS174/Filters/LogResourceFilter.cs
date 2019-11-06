using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Filters
{
    public class LogResourceFilter : Attribute, IResourceFilter
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
