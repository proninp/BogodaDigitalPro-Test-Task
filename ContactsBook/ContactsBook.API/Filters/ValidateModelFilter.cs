using ContactsBook.Core.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ContactsBook.API.Filters;

public class ValidateModelFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.ModelState.IsValid)
            return;

        var errors = context.ModelState
            .Where(m => m.Value?.Errors.Count > 0)
            .ToDictionary(
                m => m.Key,
                m => m.Value.Errors.Select(e => e.ErrorMessage).ToArray()
            );
        throw new ValidationException("Model validation failed", errors);
    }
}
