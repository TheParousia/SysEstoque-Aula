using Refit;
using SysEstoque.CallAPI.DTO.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.CallAPI.Interface {
	internal interface IEndereco {
		// Recuros a ser buscado na URL https://viacep.com.br/
		[Get("/ws/{cep}/json/")]
		Task<EnderecoDTO> GetAddressAsync(string cep);
	}
}
