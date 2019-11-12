using CIS174.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174.Filters
{
    public class EnsureRecipeExistsFilter : IActionFilter
    {
        private readonly PersonService _recipeService;

        public EnsureRecipeExistsFilter(PersonService recipeService)
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

    public class EnsureRecipeExistsAttribute : TypeFilterAttribute
    {
        public EnsureRecipeExistsAttribute()
            : base(typeof(EnsureRecipeExistsFilter))
        {

        }
    }
}
