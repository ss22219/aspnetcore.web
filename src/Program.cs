using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
namespace AspNetCore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    new WebHostBuilder()
		.UseKestrel()
		.UseContentRoot(Directory.GetCurrentDirectory())
		.UseStartup<Startup>()
		.Build()
		.Run();
        }
    }
}
