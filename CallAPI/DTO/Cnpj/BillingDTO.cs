using System.Text.Json.Serialization;

public class BillingDTO {
    [JsonPropertyName("free")]
    public bool? free {get; set;}
    [JsonPropertyName("database ")]
    public bool? database {get; set;}
}