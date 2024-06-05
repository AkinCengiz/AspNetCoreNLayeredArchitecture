using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core.DTOs;
public class NoContentDto
{
	[JsonIgnore]
	public int StatusCode { get; set; }
	public List<String> Errors { get; set; }

	public static NoContentDto Success(int statusCode)
	{
		return new NoContentDto() { StatusCode = statusCode, Errors = null };
	}

	public static NoContentDto Error(int statusCode, List<string> errors)
	{
		return new NoContentDto() { StatusCode = statusCode, Errors = errors };
	}
	public static NoContentDto Error(int statusCode, string error)
	{
		return new NoContentDto() { StatusCode = statusCode, Errors = new() { error } };
	}

}
