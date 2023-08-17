using Refit;
using SysEstoque.CallAPI.Interface;
using SysEstoque.Properties;
using SysEstoque.Utils;
using System.Reflection;

namespace SysEstoque.Models {
	public partial class FormEndereco : Form {
		ICollection<Endereco> listaEnderecos = new List<Endereco>();
		BindingSource bindingSourceEnderecos = new BindingSource();

		Endereco endereco = new Endereco();

		public FormEndereco() {
			InitializeComponent();

			dgvEnderecos.AutoGenerateColumns = false;

			using (var db = new EstoqueContext()) {
				listaEnderecos = db.Enderecos.ToList();

				bindingSourceEnderecos.DataSource = listaEnderecos;

				dgvEnderecos.DataSource = bindingSourceEnderecos;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			if (dgvEnderecos.SelectedRows.Count > 0) {
				endereco = dgvEnderecos.SelectedRows[0].DataBoundItem as Endereco;

				bindingSourceEnderecos.Remove(endereco);

				try {
					using (var db = new EstoqueContext()) {
						db.Enderecos.Remove(endereco);
						db.SaveChanges();
					}

					bindingSourceEnderecos.Remove(endereco);

				} catch (Microsoft.EntityFrameworkCore.DbUpdateException ex) {
					statusMsg.Text = "Você deve selecionar uma linha para exclui-la";
					statusMsg.ForeColor = Color.Red;

					Task.Delay(2000).ContinueWith((task) => {
						statusMsg.Text = "";
						statusMsg.ForeColor = Color.Red;
					});
				}
			} else {
				statusMsg.Text = "Você deve selecionar uma linha para exclui-la";
				statusMsg.ForeColor = Color.Red;

				Task.Delay(5000).ContinueWith((task) => {
					statusMsg.Text = "";
					statusMsg.ForeColor = Color.Red;
				});
			}
		}

		private void btnAtualizar_Click(object sender, EventArgs e) {
			if (dgvEnderecos.SelectedRows.Count > 0) {
				endereco = dgvEnderecos.SelectedRows[0].DataBoundItem as Endereco;

				txbId.Text = endereco.Id.ToString();
				txbCEP.Text = endereco.CEP;
				txbRua.Text = endereco.Rua;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e) {



			if (txbId.Text != "") {
				endereco.Id = Convert.ToInt32(txbId.Text);
				endereco.CEP = txbCEP.Text;
				endereco.Rua = txbRua.Text;
				endereco.Numero = txbNumero.Text;
				endereco.Bairro = txbBairro.Text;

				using (var db = new EstoqueContext()) {
					db.Enderecos.Update(endereco);
					db.SaveChanges();

					listaEnderecos = db.Enderecos.ToList();

					dgvEnderecos.Refresh();
				}

				txbId.Text = "";
				txbCEP.Text = "";
				txbRua.Text = "";
				txbNumero.Text = "";
				txbBairro.Text = "";

			} else {
				endereco.Id = 0;
				endereco.CEP = txbCEP.Text;
				endereco.Rua = txbRua.Text;
				endereco.Numero = txbNumero.Text;
				endereco.Bairro = txbBairro.Text;

				using (var db = new EstoqueContext()) {

					db.Enderecos.Add(endereco);
					db.SaveChanges();

					bindingSourceEnderecos.DataSource = db.Enderecos.ToList();

					dgvEnderecos.Refresh();
				}

				txbId.Text = "";
				txbCEP.Text = "";
				txbRua.Text = "";
				txbNumero.Text = "";
				txbBairro.Text = "";
			}
		}

		private void dgvCategorias_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {

		}

		private async void btnConsultar_Click(object sender, EventArgs e) {
			lbStaturConsultaAPI.Text = "Consultando...";
			lbStaturConsultaAPI.ForeColor = Color.LightGreen;

			this.Cursor = Cursors.WaitCursor;

			try {
				var httpClient = new HttpClient(new HttpLoggingHandler()) { BaseAddress = new Uri("https://viacep.com.br/") };
				//var cepCliente = RestService.For<IEndereco>("https://viacep.com.br/");
				var cepCliente = RestService.For<IEndereco>(httpClient);
				string cepInformado = txbCEP.Text;

				var Endereco = await cepCliente.GetAddressAsync(cepInformado);
				txbBairro.Text = Endereco.Bairro;
				txbRua.Text = Endereco.Logradouro;

			} catch {
				lbStaturConsultaAPI.Text = "Erro na consulta";
				lbStaturConsultaAPI.ForeColor = Color.Red;
			} finally {
				this.Cursor = Cursors.Default;

				lbStaturConsultaAPI.Text = "";
				lbStaturConsultaAPI.ForeColor = Color.Black;
			}


			Task.Delay(5000).ContinueWith((task) => {
				lbStaturConsultaAPI.Text = "";
				lbStaturConsultaAPI.ForeColor = Color.Black;
			});
		}
	}
}
