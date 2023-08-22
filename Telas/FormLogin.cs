using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using SysEstoque.Models;
using SysEstoque.Utils;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace SysEstoque {
	public partial class FormLogin : Form {
		Thread otherThread;

		Usuario usuario = new Usuario();

		public FormLogin() {
			InitializeComponent();

			FormLogin.MessageBeep(BeepType.Ok);

			using (var db = new EstoqueContext()) {
				if (db.Database.CanConnect()) {
					MessageBox.Show("Pode conectar");
					MessageBeep(BeepType.IconExclamation);
				} else {
					MessageBeep(BeepType.IconAsterisk);
					MessageBox.Show("Não pode conectar");
				}
			}
		}

		[DllImport("kernel32.dll")]
		public static extern bool Beep(int frequency, int duration);




		public enum BeepType {
			SimpleBeep = -1,
			IconAsterisk = 0x00000040,
			IconExclamation = 0x00000030,
			IconHand = 0x00000010,
			IconQuestion = 0x00000020,
			Ok = 0x00000000,
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

					foreach (var b in hasValue) {
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
					MessageBeep(BeepType.IconHand);
					Beep(1040, 100);
					Beep(1040, 100);
					Beep(1040, 300);
				}
			} else {
				MessageBox.Show("Acesso negado");
				MessageBeep(BeepType.IconExclamation);
				Beep(1040, 100);
				Beep(1040, 300);
			}
		}

		private void btnPlay_Click(object sender, EventArgs e) {
			Beep((int)upFrequency.Value, (int)upDuration.Value);
		}



		[DllImport("user32.dll")]
		public static extern bool MessageBeep(BeepType beepType);


		private void cmdMessageBeep_Click(object sender, EventArgs e) {
			switch (cboBeepType.Text) {
				case "Ok":
					MessageBeep(BeepType.Ok);
					break;

				case "SimpleBeep":
					MessageBeep(BeepType.SimpleBeep);
					break;

				case "IconAsterisk":
					MessageBeep(BeepType.IconAsterisk);

					break;

				case "IconExclamation":
					MessageBeep(BeepType.IconExclamation);
					break;

				case "IconQuestion":
					MessageBeep(BeepType.IconQuestion);
					break;

				case "IconHand":
					MessageBeep(BeepType.IconHand);

					break;

				default:
					MessageBeep(BeepType.Ok);

					break;
			}

		}


	}
}