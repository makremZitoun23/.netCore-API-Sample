using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication1.Filters
{
    public class Shirts_ValidationShirtIdFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirtId = context.ActionArguments["id"] as int?;

            if (shirtId.HasValue) {
            
            if(shirtId.Value <= 0) {
                    context.ModelState.AddModelError("ShirtsId","ShirtId is invalid");
                    context.Result = new BadRequestObjectResult
            }
        }
    }
}
