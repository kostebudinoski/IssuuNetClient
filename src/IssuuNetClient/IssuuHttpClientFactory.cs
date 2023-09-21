using System.Net;
using System.Net.Http.Headers;

namespace IssuuNetClient;

public class IssuuHttpClientFactory
{
    public static IIssuuHttpClient Create(string host)
    {
        var httpClient = new HttpClient(new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        });

        httpClient.BaseAddress = new Uri(host);
        
        ConfigureHttpClient(httpClient);

        return new IssuuHttpClient(httpClient);
    }

    private static void ConfigureHttpClient(HttpClient httpClient)
    {
        ConfigureHttpClientCore(httpClient);
    }

    internal static void ConfigureHttpClientCore(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}