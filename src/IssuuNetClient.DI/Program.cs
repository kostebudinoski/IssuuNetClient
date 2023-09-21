using IssuuNetClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

const string host = "https://reader3.isu.pub";

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddIssuuHttpClient(client =>
{
    client.BaseAddress = new Uri(host);
});

using var appHost = builder.Build();

using var serviceScope = appHost.Services.CreateScope();

var issuuHttpClient = serviceScope.ServiceProvider.GetRequiredService<IIssuuHttpClient>();
var issuuDocument = await issuuHttpClient.GetDocument("tesco_magazine", "tesco_20magazine_january", default);
Console.WriteLine($"Status: {issuuDocument?.Status}, Page Count: {issuuDocument?.Document.Pages.Length}");

await appHost.RunAsync();