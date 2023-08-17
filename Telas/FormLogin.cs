using Microsoft.VisualBasic.ApplicationServices;
using SysEstoque.Models;
using SysEstoque.Utils;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace SysEstoque {
	public partial class FormLogin : Form {
		Thread otherThread;

		Usuario usuario = new Usuario();

		public FormLogin() {
			InitializeComponent();

			using (var db = new EstoqueContext()) {
				if (db.Database.CanConnect()) {
					MessageBox.Show("Pode conectar");
				} else {
					MessageBox.Show("Não pode conectar");
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
		}

		private void openProgram(object obj) {
			Application.Run(new FormMain());
		}

		private void btnLogar_Click(object sender, EventArgs e) {
			string login = txbLogin.Text;
			string senha = txbSenha.Text;

			Usuario user = null;

			using (var db = new EstoqueContext()) {
				user = db.Usuario.FirstOrDefault(x => x.Login == login);
			}

			if (user != null) {
				StringBuilder sb = new StringBuilder();

				using (SHA512 sha512 = SHA512.Create()) {
					byte[] hasValue = sha512.ComputeHash(Encoding.UTF8.GetBytes(senha));

                    foreach (var b in hasValue){
						sb.Append($"{b:X2}");
                    }

					senha = sb.ToString();
                }

				if (user.HashSenha == senha) {
					this.Close();
					
					Globais.usuarioAtual = user;

					// Cria uma nova Thread
					otherThread = new Thread(this.openProgram);
					otherThread.SetApartmentState(ApartmentState.STA);
					otherThread.Start();

				} else {
					MessageBox.Show("Acesso negado");
				}
			} else {
				MessageBox.Show("Acesso negado");
			}
		}
	}
}