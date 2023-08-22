using Microsoft.EntityFrameworkCore;
using SysEstoque.Models;
using SysEstoque.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque {
	public partial class FormCRUDNotaEntrada : Form {
		public static Fornecedor fornecedor { get; set; }

		public static ICollection<Produto> produtos { get; set; } = new List<Produto>();

		public static BindingSource? sourceProdutos { get; set; } = new BindingSource();

		private NotaEntrada notaEntrada { get; set; } = new NotaEntrada();

		public FormCRUDNotaEntrada() {
			InitializeComponent();

			dgvProdutoDaNota.AutoGenerateColumns = false;

			sourceProdutos.DataSource = produtos;

			dgvProdutoDaNota.DataSource = sourceProdutos;
		}

		private void button1_Click(object sender, EventArgs e) {
			FormListaFornecedores formListaFornecedores = new FormListaFornecedores();
			formListaFornecedores.ShowDialog();

			txbCNPJ.Text = FormCRUDNotaEntrada.fornecedor.CNPJ;
			txbNomeFantasia.Text = FormCRUDNotaEntrada.fornecedor.NomeFantasia;
			txbRazaoSocial.Text = FormCRUDNotaEntrada.fornecedor.RazaoSocial;
			txbCNAEPrincipal.Text = FormCRUDNotaEntrada.fornecedor.CNAEPrincipal;
		}

		private void btnAddProdutos_Click(object sender, EventArgs e) {
			FormSelectProduto formSelectProduto = new FormSelectProduto(sourceProdutos);
			formSelectProduto.ShowDialog();

			//MessageBox.Show($"Count of sourceProdutos: {sourceProdutos.Count}");
		}

		private void btnAddNE_Click(object sender, EventArgs e) {
			notaEntrada.ValorTotal = 0;
			notaEntrada.Numeracao = Convert.ToInt32(txbNumeroNota.Text) | 32;
			notaEntrada.Serie = Convert.ToInt32(txbSerieNE.Text) | 1;
			notaEntrada.DataEmicao = DateTime.Now;
			notaEntrada.FornecedorCNPJ = txbCNPJ.Text;

			for (int i = 0; i < dgvProdutoDaNota.Rows.Count; i++) {
				var p = new Produto();
				p = dgvProdutoDaNota.Rows[i].DataBoundItem as Produto;
				notaEntrada.ValorTotal += (float)(p.Preco * Convert.ToInt32(dgvProdutoDaNota.Rows[i].Cells[4].Value.ToString()));
			}

			using (var db = new EstoqueContext()) {
				try {
					notaEntrada.IdNotaEntrada = db.NotaEntrada.Max(x => x.IdNotaEntrada);
				} catch {
					notaEntrada.IdNotaEntrada = 1;
				}

				notaEntrada.IdNotaEntrada++;

				// Adiciona-se a nota ao banco de dados primeiramente
				db.NotaEntrada.Add(notaEntrada);

				db.SaveChanges();

				// Adiciona-se os itens da nota
				for (int i = 0; i < dgvProdutoDaNota.Rows.Count; i++) {
					var INE = new ItemNotaEntrada();
					INE.ProdutoId = (int)dgvProdutoDaNota.Rows[i].Cells[0].Value;
					INE.NotaEntradaId = notaEntrada.IdNotaEntrada;
					INE.Quantidade = Convert.ToInt32(dgvProdutoDaNota.Rows[i].Cells[4].Value.ToString()) | 1;

					db.ItemNotaEntrada.Add(INE);

					db.SaveChanges();

					INE = null;
				}
			}

			notaEntrada = new NotaEntrada();
		}

		private void btnTest_Click(object sender, EventArgs e) {
			for (int i = 0; i < dgvProdutoDaNota.Rows.Count; i++) {
				var produto = dgvProdutoDaNota.Rows[i].DataBoundItem as Produto;

				var qtd = dgvProdutoDaNota.Rows[i].Cells[4].Value;

				MessageBox.Show($"Produto: {produto.Nome}\nQtd: {qtd}");
			}
		}

		private void dgvProdutoDaNota_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void dgvProdutoDaNota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if (
				(dgvProdutoDaNota.Rows[e.RowIndex].DataBoundItem != null) &&
				(dgvProdutoDaNota.Columns[e.ColumnIndex].DataPropertyName.Contains("."))

			   ) {

				e.Value = BindProperty.resolve(
							dgvProdutoDaNota.Rows[e.RowIndex].DataBoundItem,
							dgvProdutoDaNota.Columns[e.ColumnIndex].DataPropertyName
						);
			}

		}

		private void dgvProdutoDaNota_CellValueChanged(object sender, DataGridViewCellEventArgs e) {

		}

		private void dgvProdutoDaNota_DataSourceChanged(object sender, EventArgs e) {

			foreach(DataGridViewRow row in dgvProdutoDaNota.Rows) {
				MessageBox.Show(row.Cells[4].Value.ToString());
				
				if (row.Cells[4].Value.ToString() == "") {
					row.DefaultCellStyle.ForeColor = Color.Yellow;
				} else {

				}
			}
		}
	}
}
