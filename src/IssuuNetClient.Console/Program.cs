using IssuuNetClient;

const string host = "https://reader3.isu.pub";

var client = IssuuHttpClientFactory.Create(host);

var issuuDocument = await client.GetDocument("tesco_magazine", "tesco_20magazine_january", default);

Console.WriteLine($"Status: {issuuDocument?.Status}, Page Count: {issuuDocument?.Document.Pages.Length}");