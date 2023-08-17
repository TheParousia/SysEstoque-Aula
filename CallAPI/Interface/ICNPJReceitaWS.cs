using Refit;

namespace SysEstoque.CallAPI.Interface {
	internal interface ICNPJReceitaWS {
		// Recuros a ser buscado na URL https://receitaws.com.br/v1
		[Get("/v1/cnpj/{cnpj}")]
		//Task<string> GetAddressAsync(string cnpj);
		Task<CnpjDTO> GetAddressAsync(string cnpj);
	}
}
