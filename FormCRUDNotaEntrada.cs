using SysEstoque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			notaEntrada.ValorTotal = 100;
			notaEntrada.Numeracao = Convert.ToInt32(txbNumeroNota.Text);
			notaEntrada.Serie = Convert.ToInt32(txbSerieNE.Text);
			notaEntrada.DataEmicao = DateTime.Now;
			notaEntrada.FornecedorCNPJ = txbCNPJ.Text;


			using (var db = new EstoqueContext()) {
				try {
					notaEntrada.IdNotaEntrada = db.NotaEntrada.Max(x => x.IdNotaEntrada);
				} catch {
					notaEntrada.IdNotaEntrada = 1;
				}
				

				db.NotaEntrada.Add(notaEntrada);

				db.SaveChanges();	
				
				var fornecedorDB = db.Fornecedor.FirstOrDefault(x => x.CNPJ == txbCNPJ.Text);

				fornecedorDB.NFs.Add(notaEntrada);

				db.ItemNotaEntrada.Add(new ItemNotaEntrada {
					ProdutoId = (int)dgvProdutoDaNota.Rows[0].Cells[0].Value,
					NotaEntradaId = Convert.ToInt32(txbNumeroNota.Text),
					Quantidade = 12
				});

				db.SaveChanges();	
			}
		}

		private void btnTest_Click(object sender, EventArgs e) {
			for (int i = 0; i < dgvProdutoDaNota.Rows.Count; i++) {
				var produto = dgvProdutoDaNota.Rows[i].DataBoundItem as Produto;

				var qtd = dgvProdutoDaNota.Rows[i].Cells[2].Value;

				MessageBox.Show($"Produto: {produto.Nome}\nQtd: {qtd}");
			}
		}

		private void dgvProdutoDaNota_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}
