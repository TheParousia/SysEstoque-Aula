using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Utils {
	internal class AdminCredenciais {
		internal static bool salve(string ConnectionString) {
			try {
				string dado = AESAlgorithm.Encriptar(ConnectionString);

				bool initFileExists = File.Exists(Globais.pathFileInit);
			
				if (!initFileExists) {
					FileStream initFile = File.Create(Globais.pathFileInit);
					initFile.Close();
				}

				File.WriteAllText(Globais.pathFileInit, dado);

				return true;

			}catch (Exception erro) {
				MessageBox.Show(
					erro.Message,
					"Erro Inesperado",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return false;
			}			
		}

		internal static string read() {
			try {
				string dado;

				bool initFileExists = File.Exists(Globais.pathFileInit);

				if (!initFileExists) {
					throw new Exception("O arquivo foi excluido");
				}

				dado = File.ReadAllText(Globais.pathFileInit);

				dado = AESAlgorithm.Decriptar(dado);

				return dado;

			}catch (Exception erro) {
				MessageBox.Show(
					erro.Message,
					"Erro Inesperado",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return string.Empty;
			}
}
	}
}
