using Microsoft.EntityFrameworkCore;
using SysEstoque.Models;
using SysEstoque.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Utils {
	internal class Globais {
		public static string HomeSys = System.Environment.CurrentDirectory;
		public static string DBString = "Server=127.0.0.1;port=3306;database=estoque;uid=root;password=#Root2022";
		public static string HomeImgsProdutos = HomeSys + "\\img\\produtos\\";
		internal static string pathFileInit = HomeSys + "\\data.init";

		public static Usuario usuarioAtual { get; internal set; }

		internal static string GetDBString() {
			return "";
		}

		public static void init() {
			if (!File.Exists(Globais.pathFileInit)) {
				try {
					FormConfigBancoDados formConfigBancoDados = new FormConfigBancoDados();
					formConfigBancoDados.ShowDialog();

					formConfigBancoDados.Close();

					//Atualiza o DBString com os dados da nova conexão
					DBString = DBDataConection.getString();

					using (var db = new EstoqueContext()) {
						db.Database.Migrate();
					}
				} catch (Exception error) {
					MessageBox.Show(error.Message);
				}

			} else {
				DBString =  AdminCredenciais.read();
			}
		}
	}
}
