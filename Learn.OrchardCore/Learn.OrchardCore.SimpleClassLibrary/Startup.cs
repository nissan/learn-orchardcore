using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Learn.OrchardCore.SimpleClassLibrary
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoints)
        {
            endpoints.Map("/simpleHello", async context =>
            {
                await context.Response.WriteAsync("Hello there!");
            });
        }
    }
}
