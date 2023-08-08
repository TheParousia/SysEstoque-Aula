using SysEstoque.Models;

namespace SysEstoque {
    public partial class FormLogin : Form {

        Usuario usuario = new Usuario();

        public FormLogin() {
            InitializeComponent();
            /*
            using (var db = new EstoqueContext())
            {
                if (db.Database.CanConnect()){
                    MessageBox.Show("Pode conectar");
                }else{
                    MessageBox.Show("Não pode conectar");
                }
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLogar_Click(object sender, EventArgs e) {
            Usuario usuario = new Usuario();
            using (var db = new EstoqueContext()) {
                usuario = db.Usuario.FirstOrDefault(x => x.Login == txbLogin.Text);
            }

            if (usuario != null) {
                if (usuario.HashSenha == txbSenha.Text) {
                    FormProdutos formProdutos = new FormProdutos();
                    formProdutos.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Acesso negado");
                }
            } else {
                MessageBox.Show("Acesso negado");
            }
        }
    }
}