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

namespace SysEstoque.Models {
    public partial class FormAddProduto : Form {
        BindingSource bindingSourceProdutos = new BindingSource();
        ICollection<Produto> listaProdutos = new List<Produto>();
        Produto produto = new Produto();

        public FormAddProduto() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {

                cbxCategorias.DataSource = db.Categorias.ToList();
                cbxCategorias.DisplayMember = "Nome";
                cbxCategorias.ValueMember = "Id";
                cbxCategorias.SelectedIndex = -1;

                cbxUnidadesMedida.DataSource = db.UnidadesMedida.ToList();
                cbxUnidadesMedida.DisplayMember = "Nome";
                cbxUnidadesMedida.ValueMember = "Id";
                cbxUnidadesMedida.SelectedIndex = -1;

                //listaProdutos

                bindingSourceProdutos.DataSource = db.Produtos.ToList();
                dgvProdutos.DataSource = bindingSourceProdutos;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            produto.Id = null;
            produto.Nome = txbNome.Text.ToString();
            produto.Estoque = 0;
            produto.Preco = Convert.ToDouble(txbPreco.Text);
            produto.CategoriaId = (int)cbxCategorias.SelectedValue;
            produto.UnidadeMedidaId = (int)cbxUnidadesMedida.SelectedValue;

            using (var db = new EstoqueContext()) {
                db.Produtos.Add(produto);
                db.SaveChanges();

                bindingSourceProdutos.DataSource = db.Produtos.ToList();
            }
        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
           if ((dgvProdutos.Rows[e.RowIndex].DataBoundItem != null) && (dgvProdutos.Columns[e.ColumnIndex].DataPropertyName.Contains("."))) {
                e.Value = BindProperty.resolve(dgvProdutos.Rows[e.RowIndex].DataBoundItem, dgvProdutos.Columns[e.ColumnIndex].DataPropertyName);
           }
        }
    }
}
