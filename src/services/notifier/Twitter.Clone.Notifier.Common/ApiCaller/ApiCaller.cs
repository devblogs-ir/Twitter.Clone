using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Clone.Notifier.Common.ApiCaller
{
    public static class ApiCaller
    {
        public async static Task<HttpResponseMessage> PostAsync(string resuestUri,object content)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, resuestUri);
            var serializedContent = JsonConvert.SerializeObject(content);
            var httpContent = new StringContent(serializedContent, null, "application/json");
            request.Content = httpContent;
            var response = await client.SendAsync(request);

            return response;
        }
    }
}
