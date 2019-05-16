using Microsoft.AspNetCore.Components.Builder;
// using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WonkaBlazorClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /*
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            */
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

            // app.UseCors(options => options.AllowAnyOrigin());
        }
    }
}
