using EstoqueComEF5.Utilitarios;
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
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();

			dgvProdutos.AutoGenerateColumns = false;

			using (var db = new EstoqueContext()) {
				dgvProdutos.DataSource = db.Produtos
												.Include(p => p.Categoria)
												.Include(p => p.UnidadeMedida)
												.ToList();
			}

		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}

		private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if ((dgvProdutos.Rows[e.RowIndex].DataBoundItem != null) && (dgvProdutos.Columns[e.ColumnIndex].DataPropertyName.Contains("."))) {

				e.Value = BindProperty.resolve(
							dgvProdutos.Rows[e.RowIndex].DataBoundItem,
							dgvProdutos.Columns[e.ColumnIndex].DataPropertyName
						);
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			FormAddProduto formAddProduto = new FormAddProduto();
			formAddProduto.ShowDialog();
			
			using (var db = new EstoqueContext()) {
				dgvProdutos.DataSource = db.Produtos
												.Include(p => p.Categoria)
												.Include(p => p.UnidadeMedida)
												.ToList();
			}
		}
	}
}
