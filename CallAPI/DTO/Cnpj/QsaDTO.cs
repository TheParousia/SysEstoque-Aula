using System.Text.Json.Serialization;

public class QsaDTO {
    [JsonPropertyName("nome")]
    public string? nome {get; set;}

    [JsonPropertyName("qual")]
    public string? qual {get; set;}

    [JsonPropertyName("pais_origem")]
    public string? pais_origem {get; set;}

    [JsonPropertyName("nome_rep_legal")]
    public string? nome_rep_legal {get; set;}

    [JsonPropertyName("qual_rep_legal")]
    public string? qual_rep_legal {get; set;}
}