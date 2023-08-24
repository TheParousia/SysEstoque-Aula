namespace SysEstoque {
	partial class FormCRUDNotaEntrada {
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			button1 = new Button();
			dgvProdutoDaNota = new DataGridView();
			txbRazaoSocial = new TextBox();
			label1 = new Label();
			txbNumeroNota = new TextBox();
			txbSerieNE = new TextBox();
			label2 = new Label();
			groupBox1 = new GroupBox();
			label5 = new Label();
			label6 = new Label();
			label4 = new Label();
			label3 = new Label();
			txbCNPJ = new TextBox();
			txbCNAEPrincipal = new TextBox();
			txbNomeFantasia = new TextBox();
			btnAddNE = new Button();
			groupBox2 = new GroupBox();
			btnInserirProduto = new Button();
			label7 = new Label();
			btnTest = new Button();
			Id = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			lblValorTotal = new Label();
			label9 = new Label();
			IdProduto = new DataGridViewTextBoxColumn();
			NomeProduto = new DataGridViewTextBoxColumn();
			NomeUnidadeMedida = new DataGridViewTextBoxColumn();
			Preco = new DataGridViewTextBoxColumn();
			QuntidadeItem = new DataGridViewTextBoxColumn();
			SubTotal = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvProdutoDaNota).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(586, 84);
			button1.Name = "button1";
			button1.Size = new Size(167, 23);
			button1.TabIndex = 0;
			button1.Text = "Selecionar Fornecedor";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dgvProdutoDaNota
			// 
			dgvProdutoDaNota.AllowUserToAddRows = false;
			dgvProdutoDaNota.AllowUserToDeleteRows = false;
			dgvProdutoDaNota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProdutoDaNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdutoDaNota.Columns.AddRange(new DataGridViewColumn[] { IdProduto, NomeProduto, NomeUnidadeMedida, Preco, QuntidadeItem, SubTotal });
			dgvProdutoDaNota.Location = new Point(6, 50);
			dgvProdutoDaNota.MultiSelect = false;
			dgvProdutoDaNota.Name = "dgvProdutoDaNota";
			dgvProdutoDaNota.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutoDaNota.Size = new Size(764, 162);
			dgvProdutoDaNota.TabIndex = 1;
			dgvProdutoDaNota.DataSourceChanged += dgvProdutoDaNota_DataSourceChanged;
			dgvProdutoDaNota.CellContentClick += dgvProdutoDaNota_CellContentClick;
			dgvProdutoDaNota.CellEndEdit += dgvProdutoDaNota_CellEndEdit;
			dgvProdutoDaNota.CellFormatting += dgvProdutoDaNota_CellFormatting;
			dgvProdutoDaNota.CellValueChanged += dgvProdutoDaNota_CellValueChanged;
			// 
			// txbRazaoSocial
			// 
			txbRazaoSocial.Location = new Point(294, 27);
			txbRazaoSocial.Name = "txbRazaoSocial";
			txbRazaoSocial.ReadOnly = true;
			txbRazaoSocial.Size = new Size(174, 23);
			txbRazaoSocial.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(306, 9);
			label1.Name = "label1";
			label1.Size = new Size(215, 25);
			label1.TabIndex = 3;
			label1.Text = "Registrar Nota de Entrada";
			// 
			// txbNumeroNota
			// 
			txbNumeroNota.Location = new Point(90, 68);
			txbNumeroNota.Name = "txbNumeroNota";
			txbNumeroNota.Size = new Size(100, 23);
			txbNumeroNota.TabIndex = 2;
			// 
			// txbSerieNE
			// 
			txbSerieNE.Location = new Point(266, 68);
			txbSerieNE.Name = "txbSerieNE";
			txbSerieNE.Size = new Size(100, 23);
			txbSerieNE.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 71);
			label2.Name = "label2";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 3;
			label2.Text = "Numeração:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txbCNPJ);
			groupBox1.Controls.Add(txbCNAEPrincipal);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(txbNomeFantasia);
			groupBox1.Controls.Add(txbRazaoSocial);
			groupBox1.Location = new Point(12, 118);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(776, 128);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Fornecedor";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(491, 30);
			label5.Name = "label5";
			label5.Size = new Size(89, 15);
			label5.TabIndex = 3;
			label5.Text = "Nome Fantasia:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(16, 72);
			label6.Name = "label6";
			label6.Size = new Size(90, 15);
			label6.TabIndex = 3;
			label6.Text = "CNAE Principal:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(201, 30);
			label4.Name = "label4";
			label4.Size = new Size(75, 15);
			label4.TabIndex = 3;
			label4.Text = "Razão Social:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 30);
			label3.Name = "label3";
			label3.Size = new Size(37, 15);
			label3.TabIndex = 3;
			label3.Text = "CNPJ:";
			// 
			// txbCNPJ
			// 
			txbCNPJ.Location = new Point(59, 27);
			txbCNPJ.Name = "txbCNPJ";
			txbCNPJ.ReadOnly = true;
			txbCNPJ.Size = new Size(119, 23);
			txbCNPJ.TabIndex = 2;
			// 
			// txbCNAEPrincipal
			// 
			txbCNAEPrincipal.Location = new Point(112, 69);
			txbCNAEPrincipal.Name = "txbCNAEPrincipal";
			txbCNAEPrincipal.ReadOnly = true;
			txbCNAEPrincipal.Size = new Size(222, 23);
			txbCNAEPrincipal.TabIndex = 2;
			// 
			// txbNomeFantasia
			// 
			txbNomeFantasia.Location = new Point(586, 30);
			txbNomeFantasia.Name = "txbNomeFantasia";
			txbNomeFantasia.ReadOnly = true;
			txbNomeFantasia.Size = new Size(184, 23);
			txbNomeFantasia.TabIndex = 2;
			// 
			// btnAddNE
			// 
			btnAddNE.Location = new Point(634, 525);
			btnAddNE.Name = "btnAddNE";
			btnAddNE.Size = new Size(131, 23);
			btnAddNE.TabIndex = 0;
			btnAddNE.Text = "Inserir Nota";
			btnAddNE.UseVisualStyleBackColor = true;
			btnAddNE.Click += btnAddNE_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dgvProdutoDaNota);
			groupBox2.Controls.Add(btnInserirProduto);
			groupBox2.Location = new Point(12, 274);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(776, 228);
			groupBox2.TabIndex = 5;
			groupBox2.TabStop = false;
			groupBox2.Text = "Produtos";
			// 
			// btnInserirProduto
			// 
			btnInserirProduto.Location = new Point(586, 21);
			btnInserirProduto.Name = "btnInserirProduto";
			btnInserirProduto.Size = new Size(167, 23);
			btnInserirProduto.TabIndex = 0;
			btnInserirProduto.Text = "Add. Produto";
			btnInserirProduto.UseVisualStyleBackColor = true;
			btnInserirProduto.Click += btnAddProdutos_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(213, 71);
			label7.Name = "label7";
			label7.Size = new Size(35, 15);
			label7.TabIndex = 3;
			label7.Text = "Série:";
			// 
			// btnTest
			// 
			btnTest.Location = new Point(461, 525);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(131, 23);
			btnTest.TabIndex = 0;
			btnTest.Text = "btnTest";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "IdProduto";
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Width = 240;
			// 
			// Nome
			// 
			Nome.DataPropertyName = "Nome";
			Nome.HeaderText = "Nome";
			Nome.Name = "Nome";
			Nome.ReadOnly = true;
			Nome.Width = 241;
			// 
			// lblValorTotal
			// 
			lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblValorTotal.Location = new Point(648, 59);
			lblValorTotal.Name = "lblValorTotal";
			lblValorTotal.Size = new Size(134, 32);
			lblValorTotal.TabIndex = 3;
			lblValorTotal.Text = "R$";
			lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(578, 59);
			label9.Name = "label9";
			label9.Size = new Size(64, 15);
			label9.TabIndex = 3;
			label9.Text = "Valor Total:";
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
			// NomeUnidadeMedida
			// 
			NomeUnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
			NomeUnidadeMedida.HeaderText = "Unid. Medida";
			NomeUnidadeMedida.Name = "NomeUnidadeMedida";
			NomeUnidadeMedida.ReadOnly = true;
			// 
			// Preco
			// 
			Preco.DataPropertyName = "Preco";
			Preco.HeaderText = "Val. R$";
			Preco.Name = "Preco";
			Preco.ReadOnly = true;
			// 
			// QuntidadeItem
			// 
			QuntidadeItem.DataPropertyName = "Quantidade";
			dataGridViewCellStyle1.NullValue = "0";
			QuntidadeItem.DefaultCellStyle = dataGridViewCellStyle1;
			QuntidadeItem.HeaderText = "Qtd";
			QuntidadeItem.Name = "QuntidadeItem";
			// 
			// SubTotal
			// 
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = "0";
			SubTotal.DefaultCellStyle = dataGridViewCellStyle2;
			SubTotal.HeaderText = "Sub. Total";
			SubTotal.Name = "SubTotal";
			SubTotal.ReadOnly = true;
			SubTotal.ToolTipText = "Valor total da compra dessa mercadoria especifica";
			// 
			// FormCRUDNotaEntrada
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 560);
			Controls.Add(groupBox2);
			Controls.Add(btnTest);
			Controls.Add(btnAddNE);
			Controls.Add(groupBox1);
			Controls.Add(label9);
			Controls.Add(lblValorTotal);
			Controls.Add(label7);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txbSerieNE);
			Controls.Add(txbNumeroNota);
			Name = "FormCRUDNotaEntrada";
			Text = "FormCRUDNotaEntrada";
			((System.ComponentModel.ISupportInitialize)dgvProdutoDaNota).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private DataGridView dgvProdutoDaNota;
		private TextBox txbRazaoSocial;
		private Label label1;
		private TextBox txbNumeroNota;
		private TextBox txbSerieNE;
		private Label label2;
		private GroupBox groupBox1;
		private Label label5;
		private Label label6;
		private Label label4;
		private Label label3;
		private TextBox txbCNPJ;
		private TextBox txbCNAEPrincipal;
		private TextBox txbNomeFantasia;
		private Button btnAddNE;
		private GroupBox groupBox2;
		private Label label7;
		private Button btnInserirProduto;
		private Button btnTest;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Nome;
		private Label lblValorTotal;
		private Label label9;
		private DataGridViewTextBoxColumn IdProduto;
		private DataGridViewTextBoxColumn NomeProduto;
		private DataGridViewTextBoxColumn NomeUnidadeMedida;
		private DataGridViewTextBoxColumn Preco;
		private DataGridViewTextBoxColumn QuntidadeItem;
		private DataGridViewTextBoxColumn SubTotal;
	}
}