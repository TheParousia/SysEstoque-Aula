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
	public partial class FormConfigBancoDados : Form {
		public FormConfigBancoDados() {
			InitializeComponent();
		}

		private void btnViewPwd_Click(object sender, EventArgs e) {
			var senderData = sender as Button;
			if (txbSenha.UseSystemPasswordChar) {
				senderData.Text = "😉";
				txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;
			} else {
				txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;
				senderData.Text = "😄";
			}
		}

		public bool ValidarDados() {
			bool formValidado = true;

			if (txbServidor.Text == "") {
				txbServidor.Focus();
				txbServidor.BackColor = Color.LightPink;

				formValidado = false;
			}

			if (txbPort.Text == "") {
				txbPort.Focus();
				txbPort.BackColor = Color.LightPink;

				formValidado = false;
			}


			if (txbUID.Text == "") {
				txbUID.Focus();
				txbUID.BackColor = Color.LightPink;

				formValidado = false;
			}

			if (txbSenha.Text == "") {
				txbSenha.Focus();
				txbSenha.BackColor = Color.LightPink;

				formValidado = false;
			}

			if (txbDatabase.Text == "") {
				txbDatabase.Focus();
				txbDatabase.BackColor = Color.LightPink;

				formValidado = false;
			}

			RestoreStyle();

			return formValidado;
		}

		private async Task<bool> RestoreStyle() {
			txbServidor.BackColor = Color.White;
			txbPort.BackColor = Color.White;
			txbUID.BackColor = Color.White;
			txbSenha.BackColor = Color.White;
			txbDatabase.BackColor = Color.White;

			return true;
		}

		private void btnSalvarConfig_Click(object sender, EventArgs e) {
			DBDataConection.Server = txbServidor.Text;
			DBDataConection.port = txbPort.Text;
			DBDataConection.uid = txbUID.Text;
			DBDataConection.password = txbSenha.Text;
			DBDataConection.database = txbDatabase.Text;

			AdminCredenciais.salve(DBDataConection.getString());
		}
	}
}
