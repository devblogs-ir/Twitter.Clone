namespace Twitter.Clone.Messenger.Shared.SettingRequests
{
    public class SettingService : ISettingService
    {
        private readonly IHttpClientFactory? _httpClientFactory;

        public SettingService()
        {

        }

        public SettingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> GetBlockedUser(Guid userId, ICollection<Guid> ParticipantIds)
        {
            //Replace the URL in new HttpRequestMessage(HttpMethod.Get, "[^1^][1]") with the actual API endpoint you want to call.
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "[^1^][1]");

            //httpRequestMessage.Headers.Add(HeaderNames.Accept, "application/vnd.github.v3+json");

            //httpRequestMessage.Headers.Add(HeaderNames.UserAgent, "HttpRequestsSample");

            var httpClient = _httpClientFactory?.CreateClient();
            if (httpClient != null)
            {
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    //using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
                    return true;
                    // Deserialize the response content (e.g., using System.Text.Json)
                    // Example: GitHubBranches = await JsonSerializer.DeserializeAsync<IEnumerable<GitHubBranch>>(contentStream);
                }
            }


            return false;
        }
    }
}
