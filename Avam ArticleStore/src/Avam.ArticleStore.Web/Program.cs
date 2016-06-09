using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Avam.ArticleStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                //.UseUrls("http://0.0.0.0:8080")
                .UseUrls("http://localhost:8080")
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();


            host.Run();
        }
    }
}
