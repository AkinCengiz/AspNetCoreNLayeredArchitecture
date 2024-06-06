using AspNetCoreNLayeredArchitecture.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreNLayeredArchitecture.WebAPI.Filters;

public class ValidateFilterAttribute : ActionFilterAttribute
{
	public override void OnActionExecuting(ActionExecutingContext context)
	{
		if (!context.ModelState.IsValid)
		{
			var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage)).ToList();
			context.Result = new BadRequestObjectResult(CustomResponseDto<NoContentDto>.Error(400,errors));
		}
		base.OnActionExecuting(context);
	}
}
