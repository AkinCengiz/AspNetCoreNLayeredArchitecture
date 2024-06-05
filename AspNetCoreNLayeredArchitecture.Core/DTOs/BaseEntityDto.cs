using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core.DTOs;
public abstract class BaseEntityDto
{
	public int Id { get; set; }
	public DateTime CreateAt { get; set; }
}
