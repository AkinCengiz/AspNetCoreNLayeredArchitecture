using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.DTOs;
using FluentValidation;

namespace AspNetCoreNLayeredArchitecture.Service.Validations;
public class ProductDtoValidator : AbstractValidator<ProductDto>
{
	public ProductDtoValidator()
	{
		RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required...").NotEmpty()
			.WithMessage("{PropertyName} is not empty...");
		RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
		RuleFor(x => x.Stock).InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
		RuleFor(x => x.CategoryId).NotEmpty().WithMessage("{PropertyName} is required...").InclusiveBetween(0,int.MaxValue).WithMessage("{PropertyName} must be greater 0");
	}
}
