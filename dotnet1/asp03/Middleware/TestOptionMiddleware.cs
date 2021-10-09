using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

public class TesOptionMiddleware : IMiddleware
{
    TestOption _testOption { get; set; }
    public TesOptionMiddleware(IOptions<TestOption> option)
    {
        _testOption = option.Value;
    }
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name {_testOption.name}\n");
        stringBuilder.Append($"Price {_testOption.price}\n");
        stringBuilder.Append($"Hang {_testOption.hang}");

        await context.Response.WriteAsync("Hello everyone");
        await next(context);
    }
}