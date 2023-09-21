using System.Text.Json.Serialization;

namespace IssuuNetClient;

public class IssuuDocument
{
    [JsonPropertyName("document")]
    public required Document Document { get; set; }
    
    [JsonPropertyName("error")]
    public string? Error { get; set; }
    
    [JsonPropertyName("status")]
    public int Status { get; set; }
    
    [JsonPropertyName("version")]
    public int Version { get; set; }
}

public class Document
{
    [JsonPropertyName("isPaywallPreview")]
    public bool IsPaywallPreview { get; set; }
    
    [JsonPropertyName("originalPublishDate")]
    public required string OriginalPublishDate { get; set; }
    
    [JsonPropertyName("pages")]
    public required DocumentPages[] Pages { get; set; }
    
    [JsonPropertyName("publicationId")]
    public required string PublicationId { get; set; }
    
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; set; }
    
    [JsonPropertyName("smartzoomUri")]
    public string? SmartZoomUri { get; set; }
    
    [JsonPropertyName("textInfo")]
    public required DocumentTextInfo TextInfo { get; set; }
}

public class DocumentPages
{
    [JsonPropertyName("width")]
    public int Width { get; set; }
    
    [JsonPropertyName("height")]
    public int Height { get; set; }
    
    [JsonPropertyName("imageUri")]
    public required string ImageUri { get; set; }
    
    [JsonPropertyName("layersInfo")]
    public DocumentPageLayersInfo? LayersInfo { get; set; }
    
    [JsonPropertyName("IsPagePaywalled")]
    public bool IsPagePaywalled { get; set; }
    
    [JsonPropertyName("dominantColor")]
    public string? DominantColor { get; set; }
}

public class DocumentPageLayersInfo
{
    [JsonPropertyName("uri")]
    public required string Uri { get; set; }
    
    [JsonPropertyName("version")]
    public int Version { get; set; }
}

public class DocumentTextInfo
{
    [JsonPropertyName("size")]
    public int Size { get; set; }
    
    [JsonPropertyName("uri")]
    public required string Uri { get; set; }
    
    [JsonPropertyName("version")]
    public int Version { get; set; }
}