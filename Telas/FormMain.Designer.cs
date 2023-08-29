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
			menuStrip1 = new MenuStrip();
			produtosToolStripMenuItem = new ToolStripMenuItem();
			adicionarProdutoToolStripMenuItem = new ToolStripMenuItem();
			administrarCategoriasToolStripMenuItem = new ToolStripMenuItem();
			administrarUnidadeDeMedidaToolStripMenuItem = new ToolStripMenuItem();
			fornecedoresToolStripMenuItem = new ToolStripMenuItem();
			administrarFonecedoresToolStripMenuItem = new ToolStripMenuItem();
			notaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
			inserirNotaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			statusStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
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
			dgvProdutos.Location = new Point(9, 61);
			dgvProdutos.MultiSelect = false;
			dgvProdutos.Name = "dgvProdutos";
			dgvProdutos.ReadOnly = true;
			dgvProdutos.RowHeadersWidth = 51;
			dgvProdutos.RowTemplate.Height = 25;
			dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutos.Size = new Size(1025, 380);
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
			label2.Location = new Point(9, 20);
			label2.Name = "label2";
			label2.Size = new Size(123, 15);
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
			panel1.Location = new Point(3, 446);
			panel1.Name = "panel1";
			panel1.Size = new Size(1031, 127);
			panel1.TabIndex = 4;
			// 
			// btnVerFornecedores
			// 
			btnVerFornecedores.Location = new Point(23, 54);
			btnVerFornecedores.Name = "btnVerFornecedores";
			btnVerFornecedores.Size = new Size(129, 25);
			btnVerFornecedores.TabIndex = 1;
			btnVerFornecedores.Text = "Ver Fornecedores";
			btnVerFornecedores.UseVisualStyleBackColor = true;
			btnVerFornecedores.Click += btnVerFornecedores_Click;
			// 
			// estoqueMaximo
			// 
			estoqueMaximo.BackColor = SystemColors.ActiveCaption;
			estoqueMaximo.Location = new Point(498, 14);
			estoqueMaximo.Name = "estoqueMaximo";
			estoqueMaximo.Size = new Size(59, 19);
			estoqueMaximo.TabIndex = 0;
			estoqueMaximo.Text = "00";
			// 
			// estoqueMedio
			// 
			estoqueMedio.BackColor = SystemColors.ActiveCaption;
			estoqueMedio.Location = new Point(313, 13);
			estoqueMedio.Name = "estoqueMedio";
			estoqueMedio.Size = new Size(59, 19);
			estoqueMedio.TabIndex = 0;
			estoqueMedio.Text = "00";
			// 
			// estoqueMinimo
			// 
			estoqueMinimo.BackColor = SystemColors.ActiveCaption;
			estoqueMinimo.Location = new Point(123, 12);
			estoqueMinimo.Name = "estoqueMinimo";
			estoqueMinimo.Size = new Size(59, 19);
			estoqueMinimo.TabIndex = 0;
			estoqueMinimo.Text = "00";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(398, 17);
			label5.Name = "label5";
			label5.Size = new Size(96, 15);
			label5.TabIndex = 0;
			label5.Text = "Estoque Máximo";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(213, 16);
			label3.Name = "label3";
			label3.Size = new Size(86, 15);
			label3.TabIndex = 0;
			label3.Text = "Estoque Médio";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 15);
			label1.Name = "label1";
			label1.Size = new Size(94, 15);
			label1.TabIndex = 0;
			label1.Text = "Estoque Mínimo";
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel2.Controls.Add(label2);
			panel2.Controls.Add(panel1);
			panel2.Controls.Add(dgvProdutos);
			panel2.Location = new Point(10, 38);
			panel2.Name = "panel2";
			panel2.Size = new Size(1045, 585);
			panel2.TabIndex = 5;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, textStatusMsg, toolStripStatusLabel2, barStNome, toolStripStatusLabel4, barStNivel });
			statusStrip1.Location = new Point(0, 532);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1079, 30);
			statusStrip1.TabIndex = 7;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(42, 25);
			toolStripStatusLabel1.Text = "Status:";
			// 
			// textStatusMsg
			// 
			textStatusMsg.AutoSize = false;
			textStatusMsg.Name = "textStatusMsg";
			textStatusMsg.Size = new Size(500, 25);
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(54, 25);
			toolStripStatusLabel2.Text = "Usuário:";
			// 
			// barStNome
			// 
			barStNome.AutoSize = false;
			barStNome.Name = "barStNome";
			barStNome.Size = new Size(250, 25);
			// 
			// toolStripStatusLabel4
			// 
			toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			toolStripStatusLabel4.Size = new Size(49, 25);
			toolStripStatusLabel4.Text = "Função:";
			// 
			// barStNivel
			// 
			barStNivel.AutoSize = false;
			barStNivel.Name = "barStNivel";
			barStNivel.Size = new Size(118, 25);
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, fornecedoresToolStripMenuItem, notaDeEntradaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1079, 24);
			menuStrip1.TabIndex = 8;
			menuStrip1.Text = "menuStrip1";
			// 
			// produtosToolStripMenuItem
			// 
			produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProdutoToolStripMenuItem, administrarCategoriasToolStripMenuItem, administrarUnidadeDeMedidaToolStripMenuItem });
			produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
			produtosToolStripMenuItem.Size = new Size(67, 20);
			produtosToolStripMenuItem.Text = "Produtos";
			// 
			// adicionarProdutoToolStripMenuItem
			// 
			adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
			adicionarProdutoToolStripMenuItem.Size = new Size(241, 22);
			adicionarProdutoToolStripMenuItem.Text = "Adicionar produto";
			adicionarProdutoToolStripMenuItem.Click += criaNovoProdutoToolStripMenuItem_Click;
			// 
			// administrarCategoriasToolStripMenuItem
			// 
			administrarCategoriasToolStripMenuItem.Name = "administrarCategoriasToolStripMenuItem";
			administrarCategoriasToolStripMenuItem.Size = new Size(241, 22);
			administrarCategoriasToolStripMenuItem.Text = "Administrar categorias";
			// 
			// administrarUnidadeDeMedidaToolStripMenuItem
			// 
			administrarUnidadeDeMedidaToolStripMenuItem.Name = "administrarUnidadeDeMedidaToolStripMenuItem";
			administrarUnidadeDeMedidaToolStripMenuItem.Size = new Size(241, 22);
			administrarUnidadeDeMedidaToolStripMenuItem.Text = "Administrar unidade de medida";
			// 
			// fornecedoresToolStripMenuItem
			// 
			fornecedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarFonecedoresToolStripMenuItem });
			fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
			fornecedoresToolStripMenuItem.Size = new Size(90, 20);
			fornecedoresToolStripMenuItem.Text = "Fornecedores";
			// 
			// administrarFonecedoresToolStripMenuItem
			// 
			administrarFonecedoresToolStripMenuItem.Name = "administrarFonecedoresToolStripMenuItem";
			administrarFonecedoresToolStripMenuItem.Size = new Size(206, 22);
			administrarFonecedoresToolStripMenuItem.Text = "Administrar Fonecedores";
			administrarFonecedoresToolStripMenuItem.Click += administrarForncedoresToolStripMenuItem_Click;
			// 
			// notaDeEntradaToolStripMenuItem
			// 
			notaDeEntradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirNotaDeEntradaToolStripMenuItem });
			notaDeEntradaToolStripMenuItem.Name = "notaDeEntradaToolStripMenuItem";
			notaDeEntradaToolStripMenuItem.Size = new Size(104, 20);
			notaDeEntradaToolStripMenuItem.Text = "Nota de Entrada";
			// 
			// inserirNotaDeEntradaToolStripMenuItem
			// 
			inserirNotaDeEntradaToolStripMenuItem.Name = "inserirNotaDeEntradaToolStripMenuItem";
			inserirNotaDeEntradaToolStripMenuItem.Size = new Size(192, 22);
			inserirNotaDeEntradaToolStripMenuItem.Text = "Inserir nota de entrada";
			inserirNotaDeEntradaToolStripMenuItem.Click += inserirNotaDeEntradaToolStripMenuItem_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1079, 562);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			Controls.Add(panel2);
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Load += FormMain_Load;
			((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
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
		private MenuStrip menuStrip1;
		private ToolStripMenuItem produtosToolStripMenuItem;
		private ToolStripMenuItem adicionarProdutoToolStripMenuItem;
		private ToolStripMenuItem administrarCategoriasToolStripMenuItem;
		private ToolStripMenuItem administrarUnidadeDeMedidaToolStripMenuItem;
		private ToolStripMenuItem fornecedoresToolStripMenuItem;
		private ToolStripMenuItem administrarFonecedoresToolStripMenuItem;
		private ToolStripMenuItem notaDeEntradaToolStripMenuItem;
		private ToolStripMenuItem inserirNotaDeEntradaToolStripMenuItem;
	}
}