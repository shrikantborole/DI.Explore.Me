using DI.Common.Explore.Me.Model;
using System.Text.Json;
using System.Net.Http.Formatting;

namespace DI.LifeTime.Web.Explore.Me
{
    public interface IHttpClientDemo
    {
        public Task<IEnumerable<User>?> GetUsersAsync();
    }
    public class HttpClientDemo : IHttpClientDemo
    {
        private HttpClient _httpClient;
        public HttpClientDemo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<User>?> GetUsersAsync()
        {
            using var response = await _httpClient.GetAsync("/users");
            if (response != null && response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<User>>();
            }
            return null;
        }
    }
}
