using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace asp02
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                   
                    var menu=HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    var html=HtmlHelper.HtmlDocument("Hello",menu+HtmlHelper.HtmlTrangchu());
                    
                    await context.Response.WriteAsync(html);
                });
                endpoints.MapGet("/RequestInfo", async (context)=>{
                    var menu=HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    var html=HtmlHelper.HtmlDocument("Hello",menu+RequestProcess.RequestInfo(context.Request));
                    await context.Response.WriteAsync(html);
                });
                endpoints.MapGet("/Encoding", async (context)=>{
                    await context.Response.WriteAsync("Encoding");
                });
                endpoints.MapGet("/Cookies/{*action}", async (context)=>{
                    var menu=HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    // var action= context.GetRouteValue("action");
                    var html=HtmlHelper.HtmlDocument("Hello",menu+RequestProcess.RequestInfo(context.Request));
                    await context.Response.WriteAsync("Cookies");
                });
                endpoints.MapGet("/Json", async (context)=>{
                    var p= new{Tensp="Bàn", Gia= 500000, Hang="Nam Thành"};
                    context.Response.ContentType="application/json";
                    var json=JsonConvert.SerializeObject(p);

                    await context.Response.WriteAsync(json);
                });
                endpoints.MapMethods("/Form",new string[]{"POST", "GET"}, async (context)=>{
                    var menu=HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                    var html=HtmlHelper.HtmlDocument("Form",menu+RequestProcess.FormInfo(context.Request));
                    await context.Response.WriteAsync(html);
                });
            });
        }
    }
}
