using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
namespace AspNetCore.Web
{
	public class Startup
	{
		public void Configure(IApplicationBuilder builder)
		{
			builder.UseStaticFiles();
		}
	}
				
}
