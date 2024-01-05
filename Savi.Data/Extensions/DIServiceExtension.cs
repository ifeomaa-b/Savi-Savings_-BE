﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Savi.Data.Context;

namespace Savi.Data.Extensions
{
	public static class DIServiceExtension
	{
		public static void AddDependencies(this IServiceCollection services, IConfiguration config)
		{
			
			services.AddDbContext<SaviDbContext>(options =>
			options.UseSqlServer(config.GetConnectionString("SaviSavings push origin ")));
		}
	}
}
