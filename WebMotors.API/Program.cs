using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebMotors.API
{
    class Program
    {
        static void Main(string[] args) =>
            BuilderWebHost(args).Run();

        public static IWebHost BuilderWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
    }
}
