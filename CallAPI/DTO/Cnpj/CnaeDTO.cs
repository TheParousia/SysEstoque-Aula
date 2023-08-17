using System.Text.Json.Serialization;

public class CnaeDTO {
    [JsonPropertyName("code")]
    public string? code {get; set;}
    [JsonPropertyName("text")]
    public string? text {get; set;}
}