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
	public partial class FormListFornecedores : Form {
		private ICollection<Fornecedor> FornecedoresNSelected = new List<Fornecedor>();
		public ICollection<Fornecedor> FornecedoresSelected { get; set; }

		public FormListFornecedores(ICollection<Fornecedor>? refFornecedoresSelected) {
			InitializeComponent();

			dgvFornecedoresNSelected.AutoGenerateColumns = false;
			dgvFornecedoresSelected.AutoGenerateColumns = false;


			this.FornecedoresSelected = refFornecedoresSelected;

			using (var db = new EstoqueContext()) {

				this.FornecedoresNSelected = db.Fornecedor.ToList();
			}

			if (this.FornecedoresSelected != null) {

				BindingSource bndFornNS = new BindingSource();
				bndFornNS.DataSource = FornecedoresNSelected;
				dgvFornecedoresNSelected.DataSource = bndFornNS;

				//Remove todos os fornecedores que já foram selecionados
				foreach (var item in this.FornecedoresSelected) {
					bndFornNS.Remove(item);

					/*
					if (FornecedoresNSelected.Remove(item)) {
						MessageBox.Show($"{item.NomeFantasia} removed succesfully");
					} else {
						MessageBox.Show($"{item.NomeFantasia} not found");
					}
					*/
				}


			}

			BindingSource bndFornS = new BindingSource();
			bndFornS.DataSource = this.FornecedoresSelected;
			dgvFornecedoresSelected.DataSource = bndFornS;
		}

		private void FormListFornecedores_Load(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			FormNewProduto.ListaFornecedores = this.FornecedoresSelected;
		}

		private void btnAddFornecedor_Click(object sender, EventArgs e) {
			if (dgvFornecedoresNSelected.SelectedRows.Count > 0) {
				this.FornecedoresSelected.Add(dgvFornecedoresNSelected.SelectedRows[0].DataBoundItem as Fornecedor);

				//dgvFornecedoresSelected.Rows.Clear();

				BindingSource bndFornS = new BindingSource();
				bndFornS.DataSource = this.FornecedoresSelected;
				dgvFornecedoresSelected.DataSource = bndFornS;
				//dgvFornecedoresSelected.DataSource = this.FornecedoresSelected;

				dgvFornecedoresNSelected.Rows.Remove(dgvFornecedoresNSelected.SelectedRows[0]);

			}
		}

		private void btnRemovFornecedor_Click(object sender, EventArgs e) {
			if (dgvFornecedoresSelected.SelectedRows.Count > 0) {
				this.FornecedoresNSelected.Add(dgvFornecedoresSelected.SelectedRows[0].DataBoundItem as Fornecedor);

				//dgvFornecedoresSelected.Rows.Clear();

				BindingSource bndFornNS = new BindingSource();
				bndFornNS.DataSource = this.FornecedoresNSelected;
				dgvFornecedoresNSelected.DataSource = bndFornNS;
				//dgvFornecedoresSelected.DataSource = this.FornecedoresSelected;

				dgvFornecedoresSelected.Rows.Remove(dgvFornecedoresSelected.SelectedRows[0]);
			}
		}
	}
}
