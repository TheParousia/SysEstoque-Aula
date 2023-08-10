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
	public partial class FormAddProduto : Form {
		Produto produto = new Produto();

		public FormAddProduto() {
			InitializeComponent();

			using (var db = new EstoqueContext()) {
				
				cbxCategorias.DataSource =  db.Categorias.ToList();
				cbxCategorias.DisplayMember = "Nome";
				cbxCategorias.ValueMember = "Id";
				cbxCategorias.SelectedIndex = -1;

				cbxUnidadesMedida.DataSource = db.UnidadesMedida.ToList();
				cbxUnidadesMedida.DisplayMember = "Nome";
				cbxUnidadesMedida.ValueMember = "Id";
				cbxUnidadesMedida.SelectedIndex = -1;
			} 
		}

		private void button1_Click(object sender, EventArgs e) {
			produto.Nome = txbNome.Text;
			produto.Preco = Convert.ToDouble(txbPreco.Text);
			produto.CategoriaId = (int)cbxCategorias.SelectedValue;
			produto.UnidadeMedidaId = (int)cbxUnidadesMedida.SelectedValue;

			using (var db = new EstoqueContext()) {

				db.Produtos.Add(produto);

				db.SaveChanges();
				
				MessageBox.Show($"Num of products in local: {db.Produtos.Count()}");

				//db.Produtos.ToList().ForEach(x => MessageBox.Show(x.Nome));

			}
		}
	}
}
