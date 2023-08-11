namespace SysEstoque.Models {
    partial class FormAddProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            label1 = new Label();
            txbNome = new TextBox();
            cbxCategorias = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbxUnidadesMedida = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            UnidadeMedida = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txbPreco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(793, 556);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 79);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(117, 76);
            txbNome.Margin = new Padding(3, 4, 3, 4);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(187, 27);
            txbNome.TabIndex = 2;
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(147, 158);
            cbxCategorias.Margin = new Padding(3, 4, 3, 4);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(157, 28);
            cbxCategorias.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 161);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 166);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 1;
            label4.Text = "Unidade de Medida:";
            // 
            // cbxUnidadesMedida
            // 
            cbxUnidadesMedida.FormattingEnabled = true;
            cbxUnidadesMedida.Location = new Point(511, 161);
            cbxUnidadesMedida.Margin = new Padding(3, 4, 3, 4);
            cbxUnidadesMedida.Name = "cbxUnidadesMedida";
            cbxUnidadesMedida.Size = new Size(147, 28);
            cbxUnidadesMedida.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(793, 249);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 0;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(622, 556);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 0;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, Estoque, UnidadeMedida, Categoria });
            dgvProdutos.Location = new Point(12, 320);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.RowTemplate.Height = 29;
            dgvProdutos.Size = new Size(867, 183);
            dgvProdutos.TabIndex = 4;
            dgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // Preco
            // 
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "Preço";
            Preco.MinimumWidth = 6;
            Preco.Name = "Preco";
            Preco.Width = 125;
            // 
            // Estoque
            // 
            Estoque.DataPropertyName = "Estoque";
            Estoque.HeaderText = "Estoque";
            Estoque.MinimumWidth = 6;
            Estoque.Name = "Estoque";
            Estoque.Width = 125;
            // 
            // UnidadeMedida
            // 
            UnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
            UnidadeMedida.HeaderText = "UnidadeMedida";
            UnidadeMedida.MinimumWidth = 6;
            UnidadeMedida.Name = "UnidadeMedida";
            UnidadeMedida.Width = 125;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria.Nome";
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Preço:";
            // 
            // txbPreco
            // 
            txbPreco.Location = new Point(401, 76);
            txbPreco.Margin = new Padding(3, 4, 3, 4);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(147, 27);
            txbPreco.TabIndex = 2;
            // 
            // FormAddProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 600);
            Controls.Add(dgvProdutos);
            Controls.Add(cbxUnidadesMedida);
            Controls.Add(cbxCategorias);
            Controls.Add(label4);
            Controls.Add(txbPreco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbNome);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddProduto";
            Text = "FormAddProduto";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txbNome;
        private ComboBox cbxCategorias;
        private Label label2;
        private TextBox txbPreco;
        private Label label3;
        private Label label4;
        private ComboBox cbxUnidadesMedida;
        private Button button2;
        private Button button3;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn UnidadeMedida;
        private DataGridViewTextBoxColumn Categoria;
        private Label label5;
        private TextBox textBox1;
    }
}