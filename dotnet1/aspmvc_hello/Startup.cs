using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using aspmvc_hello.Service;
using aspmvc_hello.Models;
using Microsoft.EntityFrameworkCore;

namespace aspmvc_hello
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(option=>
            {
                string connect=Configuration.GetConnectionString("connect");
                option.UseSqlServer(connect);
            }
            );
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddSingleton<ProductService>();
            services.AddSingleton<PlanetService>();

            services.Configure<RazorViewEngineOptions>(option=>{
                option.ViewLocationFormats.Add("/ViewStart/{1}/{0}"+RazorViewEngine.ViewExtension);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseStatusCodePages();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllerRoute(
                //     name: "default",
                //     pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name:"firt_product",
                    pattern: "/{id?}",
                    defaults: new {
                        controller= "Home",
                        action="Index",
                        
                    }
                );
                // endpoints.MapControllerRoute(
                //     name:"firt_product",
                //     pattern: "/{controller}/{id}",
                //     defaults: new {
                //         controller= "Planet",
                //         action="OnGetDetail",
                        
                //     }
                // );
            });
        }
    }
}
