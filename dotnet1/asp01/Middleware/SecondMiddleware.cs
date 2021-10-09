using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using System;

namespace asp01{
    public class SecondMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if(context.Request.Path=="/xxx.html"){
                await context.Response.WriteAsync("Bạn không được truy cập");
                var dataFirstMiddleware= context.Items["DataFirstMiddleware"];
                if(dataFirstMiddleware!=null)
                {
                    await context.Response.WriteAsync((string)dataFirstMiddleware);
                }
                context.Response.Headers.Add("SecondMiddleware","Ban khong duoc truy cap");
            }else{
                context.Response.Headers.Add("SecondMiddleware","Ban duoc truy cap");
                var dataFirstMiddleware= context.Items["DataFirstMiddleware"];
                if(dataFirstMiddleware!=null)
                {
                    await context.Response.WriteAsync((string)dataFirstMiddleware);
                }
                await next(context);
            }
        }
    }


}