using Microsoft.EntityFrameworkCore;
using SysEstoque.Models;
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
	public partial class FormAddNotaEntrada : Form {
		List<ItemNotaEntrada> listaItensNotaEntrada = new List<ItemNotaEntrada>();

		BindingSource bindingSource = new BindingSource();

		public FormAddNotaEntrada() {
			InitializeComponent();

			using (var db = new EstoqueContext()) {
				listaItensNotaEntrada = db.ItemNotaEntrada
											.Include(n => n.Produto)
											.ToList();

				bindingSource.DataSource = listaItensNotaEntrada;
				dgvItenNotaEntrada.DataSource = bindingSource;


			}
		}

		private void dgvItenNotaEntrada_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if (
				(dgvItenNotaEntrada.Rows[e.RowIndex].DataBoundItem != null) &&
				(dgvItenNotaEntrada.Columns[e.ColumnIndex].DataPropertyName.Contains("."))

			   ) {

				e.Value = BindProperty.resolve(
							dgvItenNotaEntrada.Rows[e.RowIndex].DataBoundItem,
							dgvItenNotaEntrada.Columns[e.ColumnIndex].DataPropertyName
						);
			}
		}
	}
}
