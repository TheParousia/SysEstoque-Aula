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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
			btnAdicionarProduto = new Button();
			panel1 = new Panel();
			btnVerFornecedores = new Button();
			estoqueMaximo = new Label();
			estoqueMedio = new Label();
			estoqueMinimo = new Label();
			label5 = new Label();
			label3 = new Label();
			label1 = new Label();
			panel2 = new Panel();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			panel3 = new Panel();
			tabPage2 = new TabPage();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			textStatusMsg = new ToolStripStatusLabel();
			toolStripSplitButton1 = new ToolStripSplitButton();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			barStNome = new ToolStripStatusLabel();
			toolStripStatusLabel4 = new ToolStripStatusLabel();
			barStNivel = new ToolStripStatusLabel();
			menuStrip1 = new MenuStrip();
			produtoToolStripMenuItem = new ToolStripMenuItem();
			criaNovoProdutoToolStripMenuItem = new ToolStripMenuItem();
			categoriasToolStripMenuItem = new ToolStripMenuItem();
			unidadesDeMedidaToolStripMenuItem = new ToolStripMenuItem();
			fornecedoresToolStripMenuItem = new ToolStripMenuItem();
			administrarForncedoresToolStripMenuItem = new ToolStripMenuItem();
			notasDeEntradaToolStripMenuItem = new ToolStripMenuItem();
			notasDeSaidaToolStripMenuItem = new ToolStripMenuItem();
			ajudaToolStripMenuItem = new ToolStripMenuItem();
			manualDoUsuárioToolStripMenuItem = new ToolStripMenuItem();
			sobreOSistemaToolStripMenuItem = new ToolStripMenuItem();
			contatoComOsDesenvolvedoresToolStripMenuItem = new ToolStripMenuItem();
			inserirNotaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panel3.SuspendLayout();
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
			dgvProdutos.RowTemplate.Height = 25;
			dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutos.Size = new Size(1025, 287);
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
			IdProduto.Name = "IdProduto";
			IdProduto.ReadOnly = true;
			// 
			// NomeProduto
			// 
			NomeProduto.DataPropertyName = "Nome";
			NomeProduto.HeaderText = "Nome";
			NomeProduto.Name = "NomeProduto";
			NomeProduto.ReadOnly = true;
			// 
			// PrecoProduto
			// 
			PrecoProduto.DataPropertyName = "Preco";
			PrecoProduto.HeaderText = "Preço";
			PrecoProduto.Name = "PrecoProduto";
			PrecoProduto.ReadOnly = true;
			// 
			// Estoque
			// 
			Estoque.DataPropertyName = "Estoque";
			Estoque.HeaderText = "Estoque";
			Estoque.Name = "Estoque";
			Estoque.ReadOnly = true;
			// 
			// CategoriaProd
			// 
			CategoriaProd.DataPropertyName = "Categoria.Nome";
			CategoriaProd.HeaderText = "Categoria";
			CategoriaProd.Name = "CategoriaProd";
			CategoriaProd.ReadOnly = true;
			CategoriaProd.Resizable = DataGridViewTriState.True;
			// 
			// UnidadeMedida
			// 
			UnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
			UnidadeMedida.HeaderText = "Unid. Medida";
			UnidadeMedida.Name = "UnidadeMedida";
			UnidadeMedida.ReadOnly = true;
			UnidadeMedida.Resizable = DataGridViewTriState.True;
			// 
			// BtnExcluir
			// 
			BtnExcluir.HeaderText = "Excluir";
			BtnExcluir.Name = "BtnExcluir";
			BtnExcluir.ReadOnly = true;
			BtnExcluir.Resizable = DataGridViewTriState.True;
			BtnExcluir.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// BtnAltualizar
			// 
			BtnAltualizar.HeaderText = "Atualizar";
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
			// btnAdicionarProduto
			// 
			btnAdicionarProduto.Font = new Font("Segoe UI", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdicionarProduto.Location = new Point(9, 15);
			btnAdicionarProduto.Name = "btnAdicionarProduto";
			btnAdicionarProduto.Size = new Size(92, 79);
			btnAdicionarProduto.TabIndex = 0;
			btnAdicionarProduto.Text = "➕ Adicionar Novo Produto";
			btnAdicionarProduto.UseVisualStyleBackColor = true;
			btnAdicionarProduto.Click += btnAdicionarProduto_Click;
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
			panel1.Location = new Point(9, 347);
			panel1.Name = "panel1";
			panel1.Size = new Size(1025, 127);
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
			panel2.Location = new Point(6, 175);
			panel2.Name = "panel2";
			panel2.Size = new Size(1045, 488);
			panel2.TabIndex = 5;
			// 
			// tabControl1
			// 
			tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(12, 27);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1067, 697);
			tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(panel3);
			tabPage1.Controls.Add(panel2);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1059, 669);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Produtos";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel3.Controls.Add(btnAdicionarProduto);
			panel3.Location = new Point(11, 17);
			panel3.Name = "panel3";
			panel3.Size = new Size(1045, 137);
			panel3.TabIndex = 6;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1059, 669);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Notas de Entrada";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, textStatusMsg, toolStripSplitButton1, toolStripStatusLabel2, barStNome, toolStripStatusLabel4, barStNivel });
			statusStrip1.Location = new Point(0, 725);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1079, 24);
			statusStrip1.TabIndex = 7;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(42, 19);
			toolStripStatusLabel1.Text = "Status:";
			// 
			// textStatusMsg
			// 
			textStatusMsg.AutoSize = false;
			textStatusMsg.Name = "textStatusMsg";
			textStatusMsg.Size = new Size(500, 19);
			// 
			// toolStripSplitButton1
			// 
			toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
			toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
			toolStripSplitButton1.Name = "toolStripSplitButton1";
			toolStripSplitButton1.Size = new Size(32, 22);
			toolStripSplitButton1.Text = "toolStripSplitButton1";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(54, 19);
			toolStripStatusLabel2.Text = "Usuário:";
			// 
			// barStNome
			// 
			barStNome.AutoSize = false;
			barStNome.Name = "barStNome";
			barStNome.Size = new Size(250, 19);
			// 
			// toolStripStatusLabel4
			// 
			toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			toolStripStatusLabel4.Size = new Size(49, 19);
			toolStripStatusLabel4.Text = "Função:";
			// 
			// barStNivel
			// 
			barStNivel.AutoSize = false;
			barStNivel.Name = "barStNivel";
			barStNivel.Size = new Size(118, 19);
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { produtoToolStripMenuItem, fornecedoresToolStripMenuItem, notasDeEntradaToolStripMenuItem, notasDeSaidaToolStripMenuItem, ajudaToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1079, 24);
			menuStrip1.TabIndex = 8;
			menuStrip1.Text = "menuStrip1";
			// 
			// produtoToolStripMenuItem
			// 
			produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criaNovoProdutoToolStripMenuItem, categoriasToolStripMenuItem, unidadesDeMedidaToolStripMenuItem });
			produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
			produtoToolStripMenuItem.Size = new Size(62, 20);
			produtoToolStripMenuItem.Text = "Produto";
			// 
			// criaNovoProdutoToolStripMenuItem
			// 
			criaNovoProdutoToolStripMenuItem.Name = "criaNovoProdutoToolStripMenuItem";
			criaNovoProdutoToolStripMenuItem.Size = new Size(182, 22);
			criaNovoProdutoToolStripMenuItem.Text = "Cria novo produto";
			criaNovoProdutoToolStripMenuItem.Click += criaNovoProdutoToolStripMenuItem_Click;
			// 
			// categoriasToolStripMenuItem
			// 
			categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
			categoriasToolStripMenuItem.Size = new Size(182, 22);
			categoriasToolStripMenuItem.Text = "Categorias";
			categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
			// 
			// unidadesDeMedidaToolStripMenuItem
			// 
			unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
			unidadesDeMedidaToolStripMenuItem.Size = new Size(182, 22);
			unidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
			unidadesDeMedidaToolStripMenuItem.Click += unidadesDeMedidaToolStripMenuItem_Click;
			// 
			// fornecedoresToolStripMenuItem
			// 
			fornecedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarForncedoresToolStripMenuItem });
			fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
			fornecedoresToolStripMenuItem.Size = new Size(90, 20);
			fornecedoresToolStripMenuItem.Text = "Fornecedores";
			// 
			// administrarForncedoresToolStripMenuItem
			// 
			administrarForncedoresToolStripMenuItem.Name = "administrarForncedoresToolStripMenuItem";
			administrarForncedoresToolStripMenuItem.Size = new Size(204, 22);
			administrarForncedoresToolStripMenuItem.Text = "Administrar Forncedores";
			administrarForncedoresToolStripMenuItem.Click += administrarForncedoresToolStripMenuItem_Click;
			// 
			// notasDeEntradaToolStripMenuItem
			// 
			notasDeEntradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirNotaDeEntradaToolStripMenuItem });
			notasDeEntradaToolStripMenuItem.Name = "notasDeEntradaToolStripMenuItem";
			notasDeEntradaToolStripMenuItem.Size = new Size(109, 20);
			notasDeEntradaToolStripMenuItem.Text = "Notas de Entrada";
			// 
			// notasDeSaidaToolStripMenuItem
			// 
			notasDeSaidaToolStripMenuItem.Name = "notasDeSaidaToolStripMenuItem";
			notasDeSaidaToolStripMenuItem.Size = new Size(97, 20);
			notasDeSaidaToolStripMenuItem.Text = "Notas de Saida";
			// 
			// ajudaToolStripMenuItem
			// 
			ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDoUsuárioToolStripMenuItem, sobreOSistemaToolStripMenuItem, contatoComOsDesenvolvedoresToolStripMenuItem });
			ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			ajudaToolStripMenuItem.Size = new Size(50, 20);
			ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// manualDoUsuárioToolStripMenuItem
			// 
			manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
			manualDoUsuárioToolStripMenuItem.Size = new Size(251, 22);
			manualDoUsuárioToolStripMenuItem.Text = "Manual do Usuário";
			// 
			// sobreOSistemaToolStripMenuItem
			// 
			sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
			sobreOSistemaToolStripMenuItem.Size = new Size(251, 22);
			sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
			// 
			// contatoComOsDesenvolvedoresToolStripMenuItem
			// 
			contatoComOsDesenvolvedoresToolStripMenuItem.Name = "contatoComOsDesenvolvedoresToolStripMenuItem";
			contatoComOsDesenvolvedoresToolStripMenuItem.Size = new Size(251, 22);
			contatoComOsDesenvolvedoresToolStripMenuItem.Text = "Contato com os Desenvolvedores";
			// 
			// inserirNotaDeEntradaToolStripMenuItem
			// 
			inserirNotaDeEntradaToolStripMenuItem.Name = "inserirNotaDeEntradaToolStripMenuItem";
			inserirNotaDeEntradaToolStripMenuItem.Size = new Size(194, 22);
			inserirNotaDeEntradaToolStripMenuItem.Text = "Inserir Nota de Entrada";
			inserirNotaDeEntradaToolStripMenuItem.Click += inserirNotaDeEntradaToolStripMenuItem_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1079, 749);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			Controls.Add(tabControl1);
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			panel3.ResumeLayout(false);
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
		private Button btnAdicionarProduto;
		private Panel panel1;
		private Label label1;
		private Label estoqueMinimo;
		private Label estoqueMaximo;
		private Label estoqueMedio;
		private Label label5;
		private Label label3;
		private Button btnVerFornecedores;
		private Panel panel2;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private StatusStrip statusStrip1;
		private Panel panel3;
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
		private MenuStrip menuStrip1;
		private ToolStripMenuItem produtoToolStripMenuItem;
		private ToolStripMenuItem criaNovoProdutoToolStripMenuItem;
		private ToolStripMenuItem categoriasToolStripMenuItem;
		private ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
		private ToolStripMenuItem fornecedoresToolStripMenuItem;
		private ToolStripMenuItem administrarForncedoresToolStripMenuItem;
		private ToolStripMenuItem notasDeEntradaToolStripMenuItem;
		private ToolStripMenuItem notasDeSaidaToolStripMenuItem;
		private ToolStripMenuItem ajudaToolStripMenuItem;
		private ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
		private ToolStripMenuItem sobreOSistemaToolStripMenuItem;
		private ToolStripMenuItem contatoComOsDesenvolvedoresToolStripMenuItem;
		private ToolStripSplitButton toolStripSplitButton1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel barStNome;
		private ToolStripStatusLabel toolStripStatusLabel4;
		private ToolStripStatusLabel barStNivel;
		private ToolStripMenuItem inserirNotaDeEntradaToolStripMenuItem;
	}
}