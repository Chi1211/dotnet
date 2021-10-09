using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace asp01
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine(@"Url: {0}", context.Request.Path);
            context.Items.Add("DataFirstMiddleware", $"<p> URL{context.Request.Path}</p>");
            await _next(context);
        }

    }
}