using SysEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Exceptions {
	internal class UsuarioNaoPermitidoException : Exception{
		internal UsuarioNaoPermitidoException(string mensagem) : base(mensagem) {
			
		}
	}
}
