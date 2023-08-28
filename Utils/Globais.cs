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
		//internal static string pathFileInit = HomeSys + "\\data.init";
		internal static string pathFileInit = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\data.init";

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

			//Trecho de código para nunta ter nenhum usuário na tabela Usuario do banco de dados
			using (var db = new EstoqueContext()) {
				int qtdUser = db.Usuario.ToList().Count();

				
				if (qtdUser <= 0) {
					Usuario usuario = new Usuario();
					
					usuario.Login = "root";
					//Senha toor
					usuario.HashSenha = "2B64F2E3F9FEE1942AF9FF60D40AA5A719DB33B8BA8DD4864BB4F11E25CA2BEE00907DE32A59429602336CAC832C8F2EEFF5177CC14C864DD116C8BF6CA5D9A9";
					usuario.Endereco = null;
					usuario.EhMaster = true;
					usuario.Nome = "Usuário Padrão";
					usuario.Sobrenome = "Usuário Padrão";

					db.Usuario.Add(usuario);
				}
			}

		}
	}
}
