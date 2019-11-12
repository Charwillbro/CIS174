using CIS174.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174.Filters
{
    public class EnsurePersonExistsFilter : IActionFilter
    {
        private readonly PersonService _recipeService;

        public EnsurePersonExistsFilter(PersonService recipeService)
        {
            _recipeService = recipeService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = (int)context.ActionArguments["id"];

            if (!_recipeService.DoesPersonExist(id))
            {
                context.Result = new NotFoundResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Nothing to do here 
        }
    }

    public class EnsurePersonExistsAttribute : TypeFilterAttribute
    {
        public EnsurePersonExistsAttribute()
            : base(typeof(EnsurePersonExistsFilter))
        {

        }
    }
}
