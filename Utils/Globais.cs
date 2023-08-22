using SysEstoque.Models;
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

		public static Usuario usuarioAtual { get; internal set; }

		internal static string GetDBString() {
			return "";
		}
	}
}
