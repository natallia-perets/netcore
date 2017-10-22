using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace netcore{
    public class Startup
    {
        public Startup(IHostingEnvironment env){

        }

        public void Configure(IApplicationBuilder app, 
        IHostingEnvironment env, 
        ILoggerFactory logger){
            app.Run(async(context) => {
                await context.Response.WriteAsync("Hello world!");
            });
        }
    }
}