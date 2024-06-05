using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core.DTOs;
public class ProductDto : BaseEntityDto
{
	public string Name { get; set; }
	public int Stock { get; set; }
	public decimal Price { get; set; }
	public int CategoryId { get; set; }
}
