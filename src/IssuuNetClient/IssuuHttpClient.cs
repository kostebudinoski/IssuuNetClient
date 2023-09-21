using System.Net.Http.Json;

namespace IssuuNetClient;

public interface IIssuuHttpClient
{
    Task<IssuuDocument?> GetDocument(string userName, string documentName, CancellationToken cancellationToken);
}

public class IssuuHttpClient : IIssuuHttpClient
{
    private readonly HttpClient _httpClient;

    public IssuuHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<IssuuDocument?> GetDocument(string userName, string documentName, CancellationToken cancellationToken)
    {
        return _httpClient.GetFromJsonAsync<IssuuDocument>(GetDocumentPath(userName, documentName), cancellationToken);
    }
    
    private static string GetDocumentPath(string userName, string documentName)
    {
        return $"{userName}/{documentName}/reader3_4.json";
    }
}