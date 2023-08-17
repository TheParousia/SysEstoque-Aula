using MySqlX.XDevAPI;
using System.Text.Json;
using Refit;
using SysEstoque.CallAPI.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysEstoque.CallAPI.DTO.Endereco;

namespace SysEstoque {
	public partial class FormCRUDFornecedor : Form {

		CnpjDTO temp = new CnpjDTO();
		EnderecoDTO endereco = new EnderecoDTO();

		public FormCRUDFornecedor() {
			InitializeComponent();
		}

		public void ClearStatusMsg() {
			statusMsg.Text = "";
			statusMsg.ForeColor = Color.Black;
		}

		private async Task buscarDadosCNPJ(string cnpj) {
			var cnpjClient = RestService.For<ICNPJReceitaWS>("https://receitaws.com.br/");

			var cnpjData = await cnpjClient.GetAddressAsync(cnpj);

			temp = cnpjData;

			if (cnpjData != null) {
				txbNomeFantazia.Text = cnpjData.fantasia;
				txbRazaoSocial.Text = cnpjData.nome;
				txbTelefone.Text = cnpjData.telefone;
				txbEmail.Text = cnpjData.email;
				txbCnaePrincipal.Text = cnpjData.atividadePrincipal[0].text;

				// Get Address data
				txbCEP.Text = cnpjData.cep;
				txbBairro.Text = cnpjData.bairro;
				txbRua.Text = cnpjData.logradouro;
				txbNumero.Text = cnpjData.numero;

				statusMsg.Text = "Busca realizada com sucesso";
				statusMsg.ForeColor = Color.Green;
			}

			Task.Delay(6000).ContinueWith((task) => {
				ClearStatusMsg();
			});
		}

		private void btnConsultarCNPJ_Click(object sender, EventArgs e) {
			statusMsg.Text = "Consutando dados do CNPJ...";
			statusMsg.ForeColor = Color.LightGreen;
			string cnpjDigitado = txbCNPJ.Text;

			try {
				this.buscarDadosCNPJ(cnpjDigitado);
			} catch {
				statusMsg.Text = "Erro ao consultar dados";
				statusMsg.ForeColor = Color.Red;

				ClearStatusMsg();
			}
		}

		private void btnConsultaCEP_Click(object sender, EventArgs e) {
			string cepDigitado = txbCEP.Text;

			try {
				this.buscarDadosCEP(cepDigitado);
			} catch {
				statusMsg.Text = "Erro ao consultar dados";
				statusMsg.ForeColor = Color.Red;
			}
		}

		private async Task buscarDadosCEP(string cepDigitado) {
			var cepClient = RestService.For<IEndereco>("https://viacep.com.br/");
			var cepDados = await cepClient.GetAddressAsync(cepDigitado);

			endereco = cepDados;

			if (cepDados.Cep != null) {
				txbBairro.Text = cepDados.Bairro;
				txbRua.Text = cepDados.Logradouro;
			} else {
				statusMsg.Text = "Erro ao consultar dados";
				statusMsg.ForeColor = Color.Red;
			}

			Task.Delay(2000).ContinueWith((task) => {
				ClearStatusMsg();
			});
		}
	}
}
