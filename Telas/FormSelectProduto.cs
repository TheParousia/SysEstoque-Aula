using Microsoft.EntityFrameworkCore;
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
	public partial class FormSelectProduto : Form {
		BindingSource produtosDisponiveis = new BindingSource();
		//BindingSource produtosSelecionados = new BindingSource();
		BindingSource produtosSelecionados = FormCRUDNotaEntrada.sourceProdutos;

		public FormSelectProduto(BindingSource? bindingSourceProdutos = null) {
			InitializeComponent();

			dgvProdutosSelecionados.AutoGenerateColumns = false;
			dgvProdutosDisponiveis.AutoGenerateColumns = false;

			//Linkagem
			dgvProdutosSelecionados.DataSource = produtosSelecionados;
			dgvProdutosDisponiveis.DataSource = produtosDisponiveis;

			//Inserção de dados
			using (var db = new EstoqueContext()) {
				produtosDisponiveis.DataSource = db.Produtos
														.Include(x => x.UnidadeMedida)
														.ToList();
			}

            for (int i = 0;i < produtosSelecionados.Count;i++) {
				for (int j = 0; j < produtosDisponiveis.Count; j++) {
					Produto pS = produtosSelecionados[i] as Produto;
					Produto pD = produtosDisponiveis[j] as Produto;

					if (pS.Id == pD.Id) {
						//MessageBox.Show($"{(produtosDisponiveis[j] as Produto).Nome} repetido");

						produtosDisponiveis.Remove(produtosDisponiveis[j]);
						break;
					}
				}
            }

			//Inserção de dados
			if (bindingSourceProdutos != null) {
				//produtosSelecionados = bindingSourceProdutos;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			if (dgvProdutosDisponiveis.SelectedRows.Count > 0) {
				Produto produtosEmTransacao = dgvProdutosDisponiveis.SelectedRows[0].DataBoundItem as Produto;

				produtosSelecionados.Add(produtosEmTransacao);
				produtosDisponiveis.Remove(produtosEmTransacao);
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			if (dgvProdutosSelecionados.SelectedRows.Count > 0) {
				Produto produtosEmTransacao = dgvProdutosSelecionados.SelectedRows[0].DataBoundItem as Produto;

				produtosDisponiveis.Add(produtosEmTransacao);
				produtosSelecionados.Remove(produtosEmTransacao);
			}
		}

		private void button3_Click(object sender, EventArgs e) {
		}
	}
}
