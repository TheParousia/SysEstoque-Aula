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

        ICollection<Categoria> listaCategorias = new List<Categoria>();
        BindingSource bindingSourceCategorias = new BindingSource();

        Categoria categoria = new Categoria();

        private bool EstaAtualizando = false;

        public FormCategoria() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {
                listaCategorias = db.Categorias.ToList();

                bindingSourceCategorias.DataSource = listaCategorias;

                dgvCategorias.DataSource = bindingSourceCategorias;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvCategorias.SelectedRows.Count > 0) {
                categoria = dgvCategorias.SelectedRows[0].DataBoundItem as Categoria;

                bindingSourceCategorias.Remove(categoria);

                using (var db = new EstoqueContext()) {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                }





                try {

                } catch (Microsoft.EntityFrameworkCore.DbUpdateException ex) {
                    statusMsg.Text = "Erro ao excluir o dado";
                    statusMsg.ForeColor = Color.Red;
                    bindingSourceCategorias.Remove(categoria);
                }


            } else {
                /*
                Task.Delay(2000).ContinueWith((task) => {
                    statusMsg.Text = "";
                    statusMsg.ForeColor = Color.Red;
                });
                */

                /*
                statusMsg.Text = "Você deve selecionar uma linha para exclui-la";
                statusMsg.ForeColor = Color.Red;

                Task.Delay(2000).ContinueWith((task) => {
                    statusMsg.Text = "";
                    statusMsg.ForeColor = Color.Red;
                });
                */
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (EstaAtualizando) {
                // Pegar o dado formulário e atualiza no banco de dados
                categoria.Id = Convert.ToInt32(txbId.Text);
                categoria.Nome = txbNome.Text;
                categoria.Descricao = txbDescricao.Text;

                using (var db = new EstoqueContext()) {
                    db.Categorias.Update(categoria);
                    db.SaveChanges();

                    listaCategorias = db.Categorias.ToList();
                    bindingSourceCategorias.DataSource = listaCategorias;
                    dgvCategorias.Refresh();
                }

                txbId.Text = categoria.Id.ToString();
                txbNome.Text = categoria.Nome;
                txbDescricao.Text = categoria.Descricao;

                EstaAtualizando = false;

            } else {
                // Pegar o dado formulário e vai inserir no banco de dados

                categoria.Id = null;
                categoria.Nome = txbNome.Text;
                categoria.Descricao = txbDescricao.Text;

                using (var db = new EstoqueContext()) {
                    db.Categorias.Add(categoria);
                    db.SaveChanges();

                    listaCategorias = db.Categorias.ToList();
                    bindingSourceCategorias.DataSource = listaCategorias;
                    dgvCategorias.DataSource = bindingSourceCategorias;
                    dgvCategorias.Refresh();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            if (dgvCategorias.SelectedRows.Count > 0) {
                categoria = dgvCategorias.SelectedRows[0].DataBoundItem as Categoria;

                txbId.Text = categoria.Id.ToString();
                txbNome.Text = categoria.Nome;
                txbDescricao.Text = categoria.Descricao;

                EstaAtualizando = true;
            }
        }



        private void dgvCategorias_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {

        }

        private void FormCategoria_Load(object sender, EventArgs e) {

        }
    }
}




/*
Task.Delay(5000).ContinueWith((task) => {
    statusMsg.Text = "";
    statusMsg.ForeColor = Color.Red;
});
*/