# IssuuNetClient

IssuuNetClient is a lightweight C# package designed to effortlessly retrieve information about documents on Issuu. With this tool, you can easily access documents associated with a specific username and document name, all without the need for an API key. Streamlined and user-friendly, this package simplifies the process of gathering Issuu document details for seamless integration into your projects.

## Usage example

DI registration:

```csharp
const string host = "https://reader3.isu.pub";

builder.Services.AddIssuuHttpClient(client =>
{
    client.BaseAddress = new Uri(host);
});
```

API usage:

```csharp
var issuuHttpClient = serviceScope.ServiceProvider.GetRequiredService<IIssuuHttpClient>();
var issuuDocument = await issuuHttpClient.GetDocument("tesco_magazine", "tesco_20magazine_january", CancellationToken.None);
```
