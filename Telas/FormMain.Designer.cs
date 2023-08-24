namespace SysEstoque {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgvProdutos = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            PrecoProduto = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            CategoriaProd = new DataGridViewTextBoxColumn();
            UnidadeMedida = new DataGridViewTextBoxColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnAltualizar = new DataGridViewButtonColumn();
            label2 = new Label();
            panel1 = new Panel();
            btnVerFornecedores = new Button();
            estoqueMaximo = new Label();
            estoqueMedio = new Label();
            estoqueMinimo = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textStatusMsg = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            barStNome = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            barStNivel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { IdProduto, NomeProduto, PrecoProduto, Estoque, CategoriaProd, UnidadeMedida, BtnExcluir, BtnAltualizar });
            dgvProdutos.Location = new Point(10, 81);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1171, 506);
            dgvProdutos.TabIndex = 3;
            dgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
            dgvProdutos.RowEnter += dgvProdutos_RowEnter;
            dgvProdutos.SelectionChanged += dgvProdutos_SelectionChanged;
            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;
            // 
            // IdProduto
            // 
            IdProduto.DataPropertyName = "Id";
            IdProduto.HeaderText = "Id";
            IdProduto.MinimumWidth = 6;
            IdProduto.Name = "IdProduto";
            IdProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "Nome";
            NomeProduto.HeaderText = "Nome";
            NomeProduto.MinimumWidth = 6;
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            // 
            // PrecoProduto
            // 
            PrecoProduto.DataPropertyName = "Preco";
            PrecoProduto.HeaderText = "Preço";
            PrecoProduto.MinimumWidth = 6;
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.DataPropertyName = "Estoque";
            Estoque.HeaderText = "Estoque";
            Estoque.MinimumWidth = 6;
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // CategoriaProd
            // 
            CategoriaProd.DataPropertyName = "Categoria.Nome";
            CategoriaProd.HeaderText = "Categoria";
            CategoriaProd.MinimumWidth = 6;
            CategoriaProd.Name = "CategoriaProd";
            CategoriaProd.ReadOnly = true;
            CategoriaProd.Resizable = DataGridViewTriState.True;
            // 
            // UnidadeMedida
            // 
            UnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
            UnidadeMedida.HeaderText = "Unid. Medida";
            UnidadeMedida.MinimumWidth = 6;
            UnidadeMedida.Name = "UnidadeMedida";
            UnidadeMedida.ReadOnly = true;
            UnidadeMedida.Resizable = DataGridViewTriState.True;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.ReadOnly = true;
            BtnExcluir.Resizable = DataGridViewTriState.True;
            BtnExcluir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BtnAltualizar
            // 
            BtnAltualizar.HeaderText = "Atualizar";
            BtnAltualizar.MinimumWidth = 6;
            BtnAltualizar.Name = "BtnAltualizar";
            BtnAltualizar.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(10, 27);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Produtos Cadastrados";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnVerFornecedores);
            panel1.Controls.Add(estoqueMaximo);
            panel1.Controls.Add(estoqueMedio);
            panel1.Controls.Add(estoqueMinimo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 595);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 169);
            panel1.TabIndex = 4;
            // 
            // btnVerFornecedores
            // 
            btnVerFornecedores.Location = new Point(26, 72);
            btnVerFornecedores.Margin = new Padding(3, 4, 3, 4);
            btnVerFornecedores.Name = "btnVerFornecedores";
            btnVerFornecedores.Size = new Size(147, 33);
            btnVerFornecedores.TabIndex = 1;
            btnVerFornecedores.Text = "Ver Fornecedores";
            btnVerFornecedores.UseVisualStyleBackColor = true;
            btnVerFornecedores.Click += btnVerFornecedores_Click;
            // 
            // estoqueMaximo
            // 
            estoqueMaximo.BackColor = SystemColors.ActiveCaption;
            estoqueMaximo.Location = new Point(569, 19);
            estoqueMaximo.Name = "estoqueMaximo";
            estoqueMaximo.Size = new Size(67, 25);
            estoqueMaximo.TabIndex = 0;
            estoqueMaximo.Text = "00";
            // 
            // estoqueMedio
            // 
            estoqueMedio.BackColor = SystemColors.ActiveCaption;
            estoqueMedio.Location = new Point(358, 17);
            estoqueMedio.Name = "estoqueMedio";
            estoqueMedio.Size = new Size(67, 25);
            estoqueMedio.TabIndex = 0;
            estoqueMedio.Text = "00";
            // 
            // estoqueMinimo
            // 
            estoqueMinimo.BackColor = SystemColors.ActiveCaption;
            estoqueMinimo.Location = new Point(141, 16);
            estoqueMinimo.Name = "estoqueMinimo";
            estoqueMinimo.Size = new Size(67, 25);
            estoqueMinimo.TabIndex = 0;
            estoqueMinimo.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 23);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 0;
            label5.Text = "Estoque Máximo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 21);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "Estoque Médio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Estoque Mínimo";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dgvProdutos);
            panel2.Location = new Point(12, 51);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 780);
            panel2.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, textStatusMsg, toolStripStatusLabel2, barStNome, toolStripStatusLabel4, barStNivel });
            statusStrip1.Location = new Point(0, 845);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1233, 30);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 24);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // textStatusMsg
            // 
            textStatusMsg.AutoSize = false;
            textStatusMsg.Name = "textStatusMsg";
            textStatusMsg.Size = new Size(500, 24);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(66, 24);
            toolStripStatusLabel2.Text = "Usuário:";
            // 
            // barStNome
            // 
            barStNome.AutoSize = false;
            barStNome.Name = "barStNome";
            barStNome.Size = new Size(250, 24);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(59, 24);
            toolStripStatusLabel4.Text = "Função:";
            // 
            // barStNivel
            // 
            barStNivel.AutoSize = false;
            barStNivel.Name = "barStNivel";
            barStNivel.Size = new Size(118, 24);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 875);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProdutos;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label estoqueMinimo;
        private Label estoqueMaximo;
        private Label estoqueMedio;
        private Label label5;
        private Label label3;
        private Button btnVerFornecedores;
        private Panel panel2;
        private StatusStrip statusStrip1;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn PrecoProduto;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn CategoriaProd;
        private DataGridViewTextBoxColumn UnidadeMedida;
        private DataGridViewButtonColumn BtnExcluir;
        private DataGridViewButtonColumn BtnAltualizar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel textStatusMsg;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel barStNome;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel barStNivel;
    }
}