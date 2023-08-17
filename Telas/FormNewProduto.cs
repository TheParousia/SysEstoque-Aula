using SysEstoque.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysEstoque.Utils;

namespace SysEstoque {
	public partial class FormNewProduto : Form {
		private Produto produto = new();
		public static ICollection<Fornecedor> ListaFornecedores = new List<Fornecedor>();

		public FormNewProduto(Produto? lerProduto = null, string? ModoProduto = "Leitura de Produto") {
			InitializeComponent();
			dgvProdFornecedores.AutoGenerateColumns = false;

			using (var db = new EstoqueContext()) {
				cbxProdCategoria.DataSource = db.Categorias.ToList();
				cbxProdCategoria.DisplayMember = "Selecione";
				cbxProdCategoria.DisplayMember = "Nome";
				cbxProdCategoria.ValueMember = "Id";
				cbxProdCategoria.AccessibleDefaultActionDescription = "Descricao";
				cbxProdCategoria.SelectedIndex = -1;

				//var KeyValueUnidadeMedida = new BindingList<KeyValuePair<int, string>>();
				/*
				foreach (var UnidItem in db.UnidadesMedida.ToList()) {
					cbxProdUnidMedida.Items.Insert(UnidItem.Id, UnidItem.Nome);
				}
				*/

				cbxProdUnidMedida.DataSource = db.UnidadesMedida.ToList();
				cbxProdUnidMedida.DisplayMember = "Nome";
				cbxProdUnidMedida.ValueMember = "Id";
				cbxProdUnidMedida.SelectedIndex = -1;



			}

			if (lerProduto != null) {
				tituloAcaoProduto.Text = ModoProduto;

				txbProdNome.Text = lerProduto.Nome.ToString();
				txbProdPreco.Text = lerProduto.Preco.ToString();
				txbProdEstoqueMin.Text = lerProduto.EstoqueMinimo.ToString();
				txbProdEstoqueMed.Text = lerProduto.EstoqueMedio.ToString();
				txbProdEstoqueMax.Text = lerProduto.EstoqueMaximo.ToString();

				cbxProdUnidMedida.SelectedValue = lerProduto.UnidadeMedidaId;
				cbxProdCategoria.SelectedValue = lerProduto.CategoriaId;

				FormNewProduto.ListaFornecedores = lerProduto.Fornecedores;
			}

			BindingSource dt = new BindingSource();
			dt.DataSource = FormNewProduto.ListaFornecedores;
			dgvProdFornecedores.DataSource = dt;
		}

		private void label3_Click(object sender, EventArgs e) {
		}

		private void btnProdSalvar_Click(object sender, EventArgs e) {

			//Criação de um novo objeto do tipo produto
			produto.Nome = txbProdNome.Text.ToString();
			produto.Preco = Convert.ToDouble(txbProdPreco.Text);
			produto.EstoqueMinimo = (float)Convert.ToDouble(txbProdEstoqueMin.Text);
			produto.EstoqueMedio = (float)Convert.ToDouble(txbProdEstoqueMed.Text);
			produto.EstoqueMaximo = (float)Convert.ToDouble(txbProdEstoqueMax.Text);

			if (cbxProdUnidMedida.SelectedValue != null) {
				produto.UnidadeMedidaId = (int)cbxProdUnidMedida.SelectedValue;
			}

			if (cbxProdCategoria.SelectedValue != null) {
				produto.CategoriaId = (int)cbxProdCategoria.SelectedValue;
			}


			using (var db = new EstoqueContext()) {

				db.Produtos.Add(produto);
				db.SaveChanges();

				if (dgvProdFornecedores.Rows.Count > 0) {
					for (int i = 0; i < dgvProdFornecedores.Rows.Count; i++) {
						var fornecedorSelecionado = dgvProdFornecedores.Rows[i].DataBoundItem as Fornecedor;

						var Forncerdor = db.Fornecedor.FirstOrDefault(x => x.CNPJ == fornecedorSelecionado.CNPJ);

						Forncerdor.produtos.Add(produto);

						db.SaveChanges();
					}
				}
			}
		}


		private void cbxProdUnidMedida_SelectedIndexChanged(object sender, EventArgs e) {
			//var cbx = sender as ComboBox;
			//var selectedUnidMedida = cbxProdUnidMedida.SelectedValue as UnidadeMedida;

			//MessageBox.Show($"Int cbxProdUnidMedida:\n{cbxProdUnidMedida.SelectedIndex}");
			//MessageBox.Show($"obj cbxProdUnidMedida:\n{cbxProdUnidMedida.SelectedValue}");

		}

		private void btnConfigUnidadeMedida_Click(object sender, EventArgs e) {
			FormAdmUnidMedida formAdmUnidMedida = new FormAdmUnidMedida();
			formAdmUnidMedida.Owner = this;
			formAdmUnidMedida.ShowDialog();


			using (var db = new EstoqueContext()) {
				cbxProdUnidMedida.DataSource = db.UnidadesMedida.ToList();
				cbxProdUnidMedida.DisplayMember = "Nome";
				cbxProdUnidMedida.ValueMember = "Id";
				cbxProdUnidMedida.SelectedIndex = -1;
			}
		}

		private void btnAddFornecedor_Click(object sender, EventArgs e) {
			FormListFornecedores formListFornecedores = new FormListFornecedores(FormNewProduto.ListaFornecedores);
			formListFornecedores.ShowDialog();

			if (FormNewProduto.ListaFornecedores == null) {
				MessageBox.Show("dgvProdFornecedores.DataSource is null");
			}

			dgvProdFornecedores.DataSource = FormNewProduto.ListaFornecedores;
		}

		private void btnConfigCategoria_Click(object sender, EventArgs e) {
			FormCategoria formCategoria = new FormCategoria();
			formCategoria.Owner = this;
			formCategoria.ShowDialog();


			using (var db = new EstoqueContext()) {
				cbxProdCategoria.DataSource = db.Categorias.ToList();
				cbxProdCategoria.DisplayMember = "Nome";
				cbxProdCategoria.ValueMember = "Id";
				cbxProdCategoria.SelectedIndex = -1;
			}
		}

		private void btnBuscarFoto_Click(object sender, EventArgs e) {
			string origemCompleto = "";
			string img = "";
			string PastaDestino = Globais.HomeImgsProdutos;
			string destinoCompleto = "";

			DialogResult openFileDialogResult = openFileDialog.ShowDialog();
			if (openFileDialogResult == DialogResult.OK) {
				origemCompleto = openFileDialog.FileName;
				img = openFileDialog.SafeFileName;
				destinoCompleto = PastaDestino + img;

				if (File.Exists(destinoCompleto)) {
					if (
						MessageBox.Show(
							$"Um arquivo com o nome {img} já foi cadastrado deseja subistituir?",
							"Substituit?",
							MessageBoxButtons.YesNo) == DialogResult.No) {
						return;
					} else {
						File.Copy(origemCompleto, destinoCompleto, true);
						pbxImagem.ImageLocation = destinoCompleto;
					}
				} else {
					File.Copy(origemCompleto, destinoCompleto, true);
					pbxImagem.ImageLocation = destinoCompleto;
				}
			}
		}
	}
}
