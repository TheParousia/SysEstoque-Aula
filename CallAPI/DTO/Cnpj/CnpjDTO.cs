using System.Text.Json.Serialization;

public class CnpjDTO {
    [JsonPropertyName("status")]
    public string? status;
    [JsonPropertyName("ltima_atualizacao")]
    public DateTime? ultima_atualizacao {get;set;}
    [JsonPropertyName("cnpj")]
    public string? cnpj {get;set;}
    [JsonPropertyName("tipo")]
    public string? tipo {get;set;}
    [JsonPropertyName("porte")]
    public string? porte {get;set;}
    [JsonPropertyName("nome")]
    public string? nome {get;set;}
    [JsonPropertyName("fantasia")]
    public string? fantasia {get;set;}
    [JsonPropertyName("abertura")]
    public string? abertura {get;set;}

    [JsonInclude]
    [JsonPropertyName("atividade_principal")]
    public List<CnaeDTO>? atividadePrincipal;

    [JsonInclude]
    [JsonPropertyName("atividades_secundarias")]
    public List<CnaeDTO>? atividadesSecundarias;

    [JsonPropertyName("natureza_juridica")]
    public string? naturezaJuridica {get;set;}
    [JsonPropertyName("logradouro")]
    public string? logradouro {get;set;}
    [JsonPropertyName("numero")]
    public string? numero {get;set;}
    [JsonPropertyName("complemento")]
    public string? complemento {get;set;}
    [JsonPropertyName("cep")]
    public string? cep {get;set;}
    [JsonPropertyName("bairro")]
    public string? bairro {get;set;}
    [JsonPropertyName("municipio")]
    public string? municipio {get;set;}
    [JsonPropertyName("uf")]
    public string? uf {get;set;}
    [JsonPropertyName("email")]
    public string? email {get;set;}
    [JsonPropertyName("telefone")]
    public string? telefone {get;set;}
    [JsonPropertyName("efr")]
    public string? efr {get;set;}
    [JsonPropertyName("situacao")]
    public string? situacao {get;set;}
    [JsonPropertyName("data_situacao")]
    public string? data_situacao {get;set;}
    [JsonPropertyName("motivo_situacao")]
    public string? motivo_situacao {get;set;}
    [JsonPropertyName("situacao_especial")]
    public string? situacao_especial {get;set;}
    [JsonPropertyName("data_situacao_especial")]
    public string? data_situacao_especial {get;set;}
    [JsonPropertyName("capital_social")]
    public string? capital_social {get;set;}
    [JsonInclude]
    [JsonPropertyName("qsa")]
    public List<QsaDTO>? qsa;
    //[JsonConverter<BillingDTO>]
	[JsonPropertyName("billing")]
    public BillingDTO? billing {get;set;}
 }