using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core;
public abstract class BaseEntity
{
	public int Id { get; set; }
	public DateTime CreateAt { get; set; }
	public DateTime UpdateAt { get; set; }
	public bool IsDeleted { get; set; }
	public bool IsActive { get; set; }
}
