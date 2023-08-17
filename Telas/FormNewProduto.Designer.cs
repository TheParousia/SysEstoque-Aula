namespace SysEstoque {
	partial class FormNewProduto {
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
			btnProdSalvar = new Button();
			tituloAcaoProduto = new Label();
			label2 = new Label();
			txbProdNome = new TextBox();
			label3 = new Label();
			txbProdPreco = new TextBox();
			label4 = new Label();
			txbProdEstoqueMin = new TextBox();
			groupBox1 = new GroupBox();
			txbProdEstoqueMax = new TextBox();
			txbProdEstoqueMed = new TextBox();
			label7 = new Label();
			cbxProdCategoria = new ComboBox();
			label5 = new Label();
			label6 = new Label();
			label8 = new Label();
			label9 = new Label();
			cbxProdUnidMedida = new ComboBox();
			btnConfigCategoria = new Button();
			btnConfigUnidadeMedida = new Button();
			dgvProdFornecedores = new DataGridView();
			CNPJ = new DataGridViewTextBoxColumn();
			NomeFantasia = new DataGridViewTextBoxColumn();
			RazaoSocial = new DataGridViewTextBoxColumn();
			CNAEPrincipal = new DataGridViewTextBoxColumn();
			Email = new DataGridViewTextBoxColumn();
			Telefone = new DataGridViewTextBoxColumn();
			btnAddFornecedor = new Button();
			pbxImagem = new PictureBox();
			openFileDialog = new OpenFileDialog();
			btnBuscarFoto = new Button();
			btnSalvarFoto = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProdFornecedores).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxImagem).BeginInit();
			SuspendLayout();
			// 
			// btnProdSalvar
			// 
			btnProdSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnProdSalvar.Location = new Point(713, 560);
			btnProdSalvar.Name = "btnProdSalvar";
			btnProdSalvar.Size = new Size(75, 23);
			btnProdSalvar.TabIndex = 9;
			btnProdSalvar.Text = "&Salvar";
			btnProdSalvar.UseVisualStyleBackColor = true;
			btnProdSalvar.Click += btnProdSalvar_Click;
			// 
			// tituloAcaoProduto
			// 
			tituloAcaoProduto.AutoSize = true;
			tituloAcaoProduto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			tituloAcaoProduto.Location = new Point(21, 19);
			tituloAcaoProduto.Name = "tituloAcaoProduto";
			tituloAcaoProduto.Size = new Size(227, 28);
			tituloAcaoProduto.TabIndex = 1;
			tituloAcaoProduto.Text = "Adicionar Novo Produto";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 101);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 1;
			label2.Text = "Nome:";
			// 
			// txbProdNome
			// 
			txbProdNome.CharacterCasing = CharacterCasing.Upper;
			txbProdNome.Location = new Point(88, 101);
			txbProdNome.Name = "txbProdNome";
			txbProdNome.Size = new Size(382, 23);
			txbProdNome.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 147);
			label3.Name = "label3";
			label3.Size = new Size(40, 15);
			label3.TabIndex = 1;
			label3.Text = "Preço:";
			label3.Click += label3_Click;
			// 
			// txbProdPreco
			// 
			txbProdPreco.BackColor = SystemColors.ControlLightLight;
			txbProdPreco.Location = new Point(105, 144);
			txbProdPreco.Name = "txbProdPreco";
			txbProdPreco.Size = new Size(80, 23);
			txbProdPreco.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(15, 43);
			label4.Name = "label4";
			label4.Size = new Size(97, 15);
			label4.TabIndex = 1;
			label4.Text = "Estoque Mínimo:";
			// 
			// txbProdEstoqueMin
			// 
			txbProdEstoqueMin.Location = new Point(118, 35);
			txbProdEstoqueMin.Name = "txbProdEstoqueMin";
			txbProdEstoqueMin.Size = new Size(109, 23);
			txbProdEstoqueMin.TabIndex = 5;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txbProdEstoqueMax);
			groupBox1.Controls.Add(txbProdEstoqueMed);
			groupBox1.Controls.Add(txbProdEstoqueMin);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label4);
			groupBox1.Location = new Point(21, 227);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(767, 101);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Informação de Estoque";
			// 
			// txbProdEstoqueMax
			// 
			txbProdEstoqueMax.Location = new Point(599, 35);
			txbProdEstoqueMax.Name = "txbProdEstoqueMax";
			txbProdEstoqueMax.Size = new Size(109, 23);
			txbProdEstoqueMax.TabIndex = 7;
			// 
			// txbProdEstoqueMed
			// 
			txbProdEstoqueMed.Location = new Point(353, 35);
			txbProdEstoqueMed.Name = "txbProdEstoqueMed";
			txbProdEstoqueMed.Size = new Size(109, 23);
			txbProdEstoqueMed.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(494, 43);
			label7.Name = "label7";
			label7.Size = new Size(99, 15);
			label7.TabIndex = 1;
			label7.Text = "Estoque Máximo:";
			// 
			// cbxProdCategoria
			// 
			cbxProdCategoria.FormattingEnabled = true;
			cbxProdCategoria.Location = new Point(88, 186);
			cbxProdCategoria.Name = "cbxProdCategoria";
			cbxProdCategoria.Size = new Size(160, 23);
			cbxProdCategoria.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(21, 192);
			label5.Name = "label5";
			label5.Size = new Size(61, 15);
			label5.TabIndex = 1;
			label5.Text = "Categoria:";
			label5.Click += label3_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(21, 350);
			label6.Name = "label6";
			label6.Size = new Size(81, 15);
			label6.TabIndex = 0;
			label6.Text = "Fornecedores:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(242, 150);
			label8.Name = "label8";
			label8.Size = new Size(113, 15);
			label8.TabIndex = 1;
			label8.Text = "Unidade de Medida:";
			label8.Click += label3_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(88, 147);
			label9.Name = "label9";
			label9.Size = new Size(20, 15);
			label9.TabIndex = 1;
			label9.Text = "R$";
			label9.Click += label3_Click;
			// 
			// cbxProdUnidMedida
			// 
			cbxProdUnidMedida.FormattingEnabled = true;
			cbxProdUnidMedida.Location = new Point(361, 147);
			cbxProdUnidMedida.Name = "cbxProdUnidMedida";
			cbxProdUnidMedida.Size = new Size(109, 23);
			cbxProdUnidMedida.TabIndex = 3;
			cbxProdUnidMedida.SelectedIndexChanged += cbxProdUnidMedida_SelectedIndexChanged;
			// 
			// btnConfigCategoria
			// 
			btnConfigCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnConfigCategoria.Location = new Point(264, 182);
			btnConfigCategoria.Name = "btnConfigCategoria";
			btnConfigCategoria.Size = new Size(36, 33);
			btnConfigCategoria.TabIndex = 0;
			btnConfigCategoria.Text = "🔧";
			btnConfigCategoria.UseVisualStyleBackColor = true;
			btnConfigCategoria.Click += btnConfigCategoria_Click;
			// 
			// btnConfigUnidadeMedida
			// 
			btnConfigUnidadeMedida.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnConfigUnidadeMedida.Location = new Point(476, 140);
			btnConfigUnidadeMedida.Name = "btnConfigUnidadeMedida";
			btnConfigUnidadeMedida.Size = new Size(36, 33);
			btnConfigUnidadeMedida.TabIndex = 0;
			btnConfigUnidadeMedida.Text = "🔧";
			btnConfigUnidadeMedida.UseVisualStyleBackColor = true;
			btnConfigUnidadeMedida.Click += btnConfigUnidadeMedida_Click;
			// 
			// dgvProdFornecedores
			// 
			dgvProdFornecedores.AllowUserToAddRows = false;
			dgvProdFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProdFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdFornecedores.Columns.AddRange(new DataGridViewColumn[] { CNPJ, NomeFantasia, RazaoSocial, CNAEPrincipal, Email, Telefone });
			dgvProdFornecedores.Location = new Point(21, 380);
			dgvProdFornecedores.Name = "dgvProdFornecedores";
			dgvProdFornecedores.ReadOnly = true;
			dgvProdFornecedores.RowTemplate.Height = 25;
			dgvProdFornecedores.Size = new Size(767, 160);
			dgvProdFornecedores.TabIndex = 0;
			// 
			// CNPJ
			// 
			CNPJ.DataPropertyName = "CNPJ";
			CNPJ.HeaderText = "CNPJ";
			CNPJ.Name = "CNPJ";
			CNPJ.ReadOnly = true;
			// 
			// NomeFantasia
			// 
			NomeFantasia.DataPropertyName = "NomeFantasia";
			NomeFantasia.HeaderText = "Nome Fantasia";
			NomeFantasia.Name = "NomeFantasia";
			NomeFantasia.ReadOnly = true;
			// 
			// RazaoSocial
			// 
			RazaoSocial.DataPropertyName = "RazaoSocial";
			RazaoSocial.HeaderText = "Razão Social";
			RazaoSocial.Name = "RazaoSocial";
			RazaoSocial.ReadOnly = true;
			// 
			// CNAEPrincipal
			// 
			CNAEPrincipal.DataPropertyName = "CNAEPrincipal";
			CNAEPrincipal.HeaderText = "CNAE";
			CNAEPrincipal.Name = "CNAEPrincipal";
			CNAEPrincipal.ReadOnly = true;
			// 
			// Email
			// 
			Email.DataPropertyName = "Email";
			Email.HeaderText = "E-mail";
			Email.Name = "Email";
			Email.ReadOnly = true;
			// 
			// Telefone
			// 
			Telefone.DataPropertyName = "Telefone";
			Telefone.HeaderText = "Telefone";
			Telefone.Name = "Telefone";
			Telefone.ReadOnly = true;
			// 
			// btnAddFornecedor
			// 
			btnAddFornecedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAddFornecedor.Location = new Point(641, 350);
			btnAddFornecedor.Name = "btnAddFornecedor";
			btnAddFornecedor.Size = new Size(147, 23);
			btnAddFornecedor.TabIndex = 8;
			btnAddFornecedor.Text = "Selecionar Fornecedor";
			btnAddFornecedor.UseVisualStyleBackColor = true;
			btnAddFornecedor.Click += btnAddFornecedor_Click;
			// 
			// pbxImagem
			// 
			pbxImagem.BorderStyle = BorderStyle.FixedSingle;
			pbxImagem.Location = new Point(567, 19);
			pbxImagem.Name = "pbxImagem";
			pbxImagem.Size = new Size(199, 154);
			pbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxImagem.TabIndex = 10;
			pbxImagem.TabStop = false;
			// 
			// openFileDialog
			// 
			openFileDialog.Filter = "JPG|*.jpg||PNG|*.png||BITMAP|*.bmp|GIF|*.gif";
			// 
			// btnBuscarFoto
			// 
			btnBuscarFoto.Location = new Point(567, 192);
			btnBuscarFoto.Name = "btnBuscarFoto";
			btnBuscarFoto.Size = new Size(75, 23);
			btnBuscarFoto.TabIndex = 11;
			btnBuscarFoto.Text = "Carregar";
			btnBuscarFoto.UseVisualStyleBackColor = true;
			btnBuscarFoto.Click += btnBuscarFoto_Click;
			// 
			// btnSalvarFoto
			// 
			btnSalvarFoto.Location = new Point(691, 192);
			btnSalvarFoto.Name = "btnSalvarFoto";
			btnSalvarFoto.Size = new Size(75, 23);
			btnSalvarFoto.TabIndex = 11;
			btnSalvarFoto.Text = "Salvar";
			btnSalvarFoto.UseVisualStyleBackColor = true;
			// 
			// FormNewProduto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 595);
			Controls.Add(btnSalvarFoto);
			Controls.Add(btnBuscarFoto);
			Controls.Add(pbxImagem);
			Controls.Add(dgvProdFornecedores);
			Controls.Add(groupBox1);
			Controls.Add(cbxProdUnidMedida);
			Controls.Add(cbxProdCategoria);
			Controls.Add(label6);
			Controls.Add(txbProdPreco);
			Controls.Add(label5);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(label3);
			Controls.Add(txbProdNome);
			Controls.Add(label2);
			Controls.Add(tituloAcaoProduto);
			Controls.Add(btnConfigUnidadeMedida);
			Controls.Add(btnConfigCategoria);
			Controls.Add(btnAddFornecedor);
			Controls.Add(btnProdSalvar);
			Name = "FormNewProduto";
			Text = "Adicionar Novo Produto";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvProdFornecedores).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxImagem).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnProdSalvar;
		private Label tituloAcaoProduto;
		private Label label2;
		private TextBox txbProdNome;
		private Label label3;
		private TextBox txbProdPreco;
		private Label label4;
		private TextBox txbProdEstoqueMin;
		private GroupBox groupBox1;
		private ComboBox cbxProdCategoria;
		private TextBox txbProdEstoqueMax;
		private TextBox txbProdEstoqueMed;
		private Label label7;
		private Label label5;
		private Label label6;
		private Label label8;
		private Label label9;
		private ComboBox cbxProdUnidMedida;
		private Button btnConfigCategoria;
		private Button btnConfigUnidadeMedida;
		private DataGridView dgvProdFornecedores;
		private DataGridViewTextBoxColumn CNPJ;
		private DataGridViewTextBoxColumn NomeFantasia;
		private DataGridViewTextBoxColumn RazaoSocial;
		private DataGridViewTextBoxColumn CNAEPrincipal;
		private DataGridViewTextBoxColumn Email;
		private DataGridViewTextBoxColumn Telefone;
		private Button btnAddFornecedor;
		private PictureBox pbxImagem;
		private OpenFileDialog openFileDialog;
		private Button btnBuscarFoto;
		private Button btnSalvarFoto;
	}
}