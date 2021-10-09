using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using Microsoft.Extensions.Options;

namespace asp03
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration configuration){
            _configuration=configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<TesOptionMiddleware>();
            services.AddOptions();
            var testOption= _configuration.GetSection("TestOption");
            services.Configure<TestOption>(testOption);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware<TesOptionMiddleware>();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/showOption", async context =>
                {
                    var testOptions=context.RequestServices.GetService<IOptions<TestOption>>().Value;
                    
                    // var name=testOptions["name"];
                    // var price=testOptions["price"];
                    // var hang=testOptions["hang"];

                    await context.Response.WriteAsync(stringBuilder.ToString());
                });
            });
        }
    }
}
