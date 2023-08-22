using SysEstoque.Models;

namespace SysEstoque {
    public partial class FormListaFornecedores : Form {
        public FormListaFornecedores() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {
                BindingSource dgFornecdores = new BindingSource();
                dgFornecdores.DataSource = db.Fornecedor.ToList();

                dgvFornecedores.DataSource = dgFornecdores;
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            if (dgvFornecedores.SelectedRows.Count > 0) {
                FormCRUDNotaEntrada.fornecedor = dgvFornecedores.SelectedRows[0].DataBoundItem as Fornecedor;
            }
        }
    }
}
