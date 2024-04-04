using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HelloWorldAPI.Controllers
{
    public static class HelloWorldEndpoint
    {
        public static void MapHelloWorldEndpoint(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/hello-world", async context =>
            {
                await context.Response.WriteAsync("Hello, world!");
            });
        }
    }
}
