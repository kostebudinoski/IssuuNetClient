using System.Net;
using Microsoft.Extensions.DependencyInjection;

namespace IssuuNetClient;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddIssuuHttpClient(this IServiceCollection services, Action<HttpClient> configureClient)
    {
        return services.AddHttpClient<IIssuuHttpClient, IssuuHttpClient>(httpClient =>
        {
            IssuuHttpClientFactory.ConfigureHttpClientCore(httpClient);
            configureClient(httpClient);
        }).ConfigurePrimaryHttpMessageHandler(config => new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
        });
    }
}