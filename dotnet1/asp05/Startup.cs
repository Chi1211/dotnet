using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace asp05
{
    public class Startup
    {
        IConfiguration _congiguration;
        public Startup(IConfiguration configuration){
            _congiguration=configuration;

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // Mail Server
            // Server: Mail Stransporter
            services.AddOptions();
            var mailSetting= _congiguration.GetSection("MailSetting");
            services.Configure<MailSetting>(mailSetting);          
            services.AddTransient<SendMailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/sendMail", async (context)=>{
                    var  message= await MailUtils.SendMail("bichchi1211@gmail.com","bichchi344@gmail.com","TEST","Hello bichchi");
                    await context.Response.WriteAsync(message);
                });
                endpoints.MapGet("/sendGmail", async (context)=>{
                    var  message= await MailUtils.SendGmail("bichchi1211@gmail.com","bichchi1211@gmail.com","TEST","Hello bichchi", "bichchi1211@gmail.com", "vovanhuy");
                    await context.Response.WriteAsync(message);
                });
                endpoints.MapGet("/sendMailKit", async (context) => {
                    
                    var sendMailService=context.RequestServices.GetService<SendMailService>();;
                    MailContent mailContent=new MailContent();
                    mailContent.MailTo="bichchi1211@gmail.com";
                    mailContent.Subject="Xin chào Chi";
                    mailContent.Body="Chào mừng bạn đến với sendmail";
                    var message= await sendMailService.SendMail(mailContent);
                    await context.Response.WriteAsync(message);
                });
            });
        }
    }
}
