using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque.Models {
	public partial class FormCategoria : Form {
		ICollection<Categoria> listaCategorias = new List<Categoria>();
		BindingSource bindingSourceCategorias = new BindingSource();

		Categoria categoria = new Categoria();

		public FormCategoria() {
			InitializeComponent();

			using (var db = new EstoqueContext()) {
				listaCategorias = db.Categorias.ToList();

				bindingSourceCategorias.DataSource = listaCategorias;

				dgvCategorias.DataSource = bindingSourceCategorias;
			}
		}

		/*
			string erroMsg = "Esses campos deve ser preenchidos: ";
				erroMsg += "nome ";
				erroMsg += "descricao";
			if (!formValidado) {
				statusMsg.Text = erroMsg;
			}
		*/






		private async Task<bool> SetDefaultState() {
			bool result = true;
			try {
				await Task.Delay(3000);

				statusMsg.Text = "";
				txbNome.BackColor = Color.White;
				txbDescricao.BackColor = Color.White;

			} catch (Exception erro) {
				MessageBox.Show(erro.Message);
				result = false;
			}

			return result;
		}
		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			if (dgvCategorias.SelectedRows.Count > 0) {
				categoria = dgvCategorias.SelectedRows[0].DataBoundItem as Categoria;

				bindingSourceCategorias.Remove(categoria);

				try {
					using (var db = new EstoqueContext()) {
						db.Categorias.Remove(categoria);
						db.SaveChanges();
					}

					bindingSourceCategorias.Remove(categoria);

				} catch(Microsoft.EntityFrameworkCore.DbUpdateException ex) {
					statusMsg.Text = "Você deve selecionar uma linha para exclui-la";
					statusMsg.ForeColor = Color.Red;

                    SetDefaultState();
                }
			} else {
				statusMsg.Text = "Você deve selecionar uma linha para exclui-la";
				statusMsg.ForeColor = Color.Red;

                SetDefaultState();
            }
		}

		private void btnAtualizar_Click(object sender, EventArgs e) {
			if (dgvCategorias.SelectedRows.Count > 0) {
				categoria = dgvCategorias.SelectedRows[0].DataBoundItem as Categoria;

				txbId.Text = categoria.Id.ToString();
				txbNome.Text = categoria.Nome;
				txbDescricao.Text = categoria.Descricao;
			}
		}

        private bool ValidarCampo() {
            bool formValidado = true;

            if (txbNome.Text == "") {
                formValidado = false;

                txbNome.BackColor = Color.Red;
            }

            if (txbDescricao.Text == "") {
                formValidado = false;

                txbDescricao.BackColor = Color.Red;
            }

            //SetDefaultState();

            return formValidado;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
			
			if( !ValidarCampo() ){
				return;
			}

			if (txbId.Text != "") {
				categoria.Id = Convert.ToInt32(txbId.Text);
				categoria.Nome = txbNome.Text;
				categoria.Descricao = txbDescricao.Text;

				using (var db = new EstoqueContext()) {
					db.Categorias.Update(categoria);
					db.SaveChanges();

					listaCategorias = db.Categorias.ToList();

					dgvCategorias.Refresh();
				}

				txbId.Text = "";
				txbNome.Text = "";
				txbDescricao.Text = "";
			} else {
				categoria.Id = 0;
				categoria.Nome = txbNome.Text;
				categoria.Descricao = txbDescricao.Text;

				using (var db = new EstoqueContext()) {

					db.Categorias.Add(categoria);
					db.SaveChanges();

					bindingSourceCategorias.DataSource = db.Categorias.ToList();

					dgvCategorias.Refresh();
				}
			}
		}

		private void dgvCategorias_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {

		}
	}
}
