using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Filters
{
    public class Shirts_ValidationShirtIdFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirtId = context.ActionArguments["id"] as int?;

            if (shirtId.HasValue)
            {

                if (shirtId.Value <= 0)
                {
                    context.ModelState.AddModelError("ShirtsId", "ShirtId is invalid");

                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                    // context.Result = new BadRequestObjectResult(context.ModelState);
                }
                else if (!ShirtsRepository.ShirtsExists(shirtId.Value))
                {
                    context.ModelState.AddModelError("ShirtsId", "ShirtId doesn't exist");

                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status404NotFound
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);

                    //context.Result = new NotFoundObjectResult(context.ModelState);

                }
            }
        }
    }
}
