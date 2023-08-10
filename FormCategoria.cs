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
        ICollection<Categoria> listaCategoria = new List<Categoria>();
        BindingSource bindingSourceCategorias = new BindingSource();
        
        Categoria categoria = new Categoria();


        
        public FormCategoria() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {
                listaCategoria = db.Categorias.ToList();

                bindingSourceCategorias.DataSource = listaCategoria;

                dgvCategorias.DataSource = bindingSourceCategorias;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            if (dgvCategorias.SelectedRows.Count > 0) {

                categoria = dgvCategorias.SelectedRows[0].DataBoundItem as Categoria;

                //Remove a categoria do DataGridView
                bindingSourceCategorias.Remove(categoria);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext()) {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                }
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

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (txbId.Text != "") {
                categoria.Id = Convert.ToInt32(txbId.Text);
                categoria.Nome = txbNome.Text;
                categoria.Descricao = txbDescricao.Text;

                using (var db = new EstoqueContext()) {
                    db.Categorias.Update(categoria);
                    db.SaveChanges();

                    listaCategoria = db.Categorias.ToList();

                    dgvCategorias.Refresh();
                }

                txbId.Text = categoria.Id.ToString();
                txbNome.Text = categoria.Nome;
                txbDescricao.Text = categoria.Descricao;

            } else {
                
                categoria.Id = null;
                categoria.Nome = txbNome.Text;
                categoria.Descricao = txbDescricao.Text;

                using (var db = new EstoqueContext()) {
                    db.Categorias.Add(categoria);
                    db.SaveChanges();

                    listaCategoria = db.Categorias.ToList();

                    bindingSourceCategorias.DataSource = listaCategoria;

                    dgvCategorias.DataSource = bindingSourceCategorias;

                    dgvCategorias.Refresh();
                }


            }
        }

        private void txbDescricao_TextChanged(object sender, EventArgs e) {

        }
    }
}
