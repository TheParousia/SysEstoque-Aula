using SysEstoque.Models;

namespace SysEstoque {
	public partial class FormLogin : Form {

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

		private void btnLogar_Click(object sender, EventArgs e) {
			string login = txbLogin.Text;
			string senha = txbSenha.Text;

			Usuario user = null;

			using (var db = new EstoqueContext()) {
				user = db.Usuario.FirstOrDefault(x => x.Login == login);
			}

			if (user != null) {
				if(user.HashSenha == senha) {
					this.Hide();

					FormMain formMain = new FormMain();
					formMain.Show();
				} else {
					MessageBox.Show("Acesso negado");
				}
			} else {
				MessageBox.Show("Acesso negado");
			}
		}
	}
}