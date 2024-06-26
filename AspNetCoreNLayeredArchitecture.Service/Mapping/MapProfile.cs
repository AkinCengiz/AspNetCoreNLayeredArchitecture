﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.DTOs;
using AspNetCoreNLayeredArchitecture.Core.Models;
using AutoMapper;

namespace AspNetCoreNLayeredArchitecture.Service.Mapping;
public class MapProfile : Profile
{
	public MapProfile()
	{
		CreateMap<Product, ProductDto>().ReverseMap();
		CreateMap<Category, CategoryDto>().ReverseMap();
		CreateMap<ProductFeature, ProductFeatureDto>();
		CreateMap<ProductUpdateDto, Product>();
		CreateMap<Product, ProductWithCategoryDto>();
		CreateMap<Category, CategoryWithProductsDto>();
	}
}
