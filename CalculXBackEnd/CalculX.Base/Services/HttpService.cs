using System.Net.Http;
using System.Net.Http.Json;

namespace CalculX.Base.Services;

public class HttpService (IHttpClientFactory httpClientFactory)
{
    [LogExecution]
    public async Task<T?> PostAsync<T>(string url, object payload)
    {
        HttpClient httpClient = httpClientFactory.CreateClient();

        HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, payload);

        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<T>();

        return default;
    }

    [LogExecution]
    public async Task<T?> GetAsync<T>(string url)
    {
        HttpClient httpClient = httpClientFactory.CreateClient();

        return await httpClient.GetFromJsonAsync<T>(url);
    }
}
