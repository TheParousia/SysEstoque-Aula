using SysEstoque.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque.Telas {
	public partial class FormNotaSaida : Form {
		public FormNotaSaida() {
			InitializeComponent();
		}

		private void FormNotaSaida_Load(object sender, EventArgs e) {
			txbNome.Text =  Globais.usuarioAtual.Nome;
			txbSobrenome.Text =  Globais.usuarioAtual.Sobrenome;
			txbEmail.Text =  Globais.usuarioAtual.Email;
			txbTelefone.Text =  Globais.usuarioAtual.Telefone;
			txbEndereco.Text =  Globais.usuarioAtual.getStringEndereco();
		}

		private void dgvProdutoDaNota_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void label6_Click(object sender, EventArgs e) {

		}
	}
}
