using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Utils {
	internal class DBDataConection {
		internal static string Server;
		internal static string port;
		internal static string database;
		internal static string uid;
		internal static string password;

		internal static string getString() {
			if (Server == "" || Server == null) {
				throw new Exception("Informe o servidor do banco de dados");
			}

			if (port == "" || port == null) {
				throw new Exception("Informe a porta de conexão com o servidor do banco de dados");
			}

			if (database == "" || database == null) {
				throw new Exception("Informe o nome do banco de dados");
			}

			if (uid == "" || uid == null) {
				throw new Exception("Informe o nome de usuário do banco de dados");
			}

			if (uid == "" || uid == null) {
				throw new Exception("Informe a senha de conexão do banco de dados");
			}

			return $"Server={Server};port={port};database={database};uid={uid};password={password};";
		}
	}
}
