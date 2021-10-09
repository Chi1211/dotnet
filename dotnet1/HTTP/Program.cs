using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace HTTP
{
    class Program
    {
        public static async Task<string> GetWebContend(string url){
            var httpClient=new HttpClient();
            HttpResponseMessage httpResponseMessage= await httpClient.GetAsync(url);
            string html=await httpResponseMessage.Content.ReadAsStringAsync();
            return html;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
