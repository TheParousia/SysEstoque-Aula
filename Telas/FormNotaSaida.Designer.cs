namespace SysEstoque.Telas {
	partial class FormNotaSaida {
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			dgvProdutoDaNota = new DataGridView();
			IdProduto = new DataGridViewTextBoxColumn();
			NomeProduto = new DataGridViewTextBoxColumn();
			NomeUnidadeMedida = new DataGridViewTextBoxColumn();
			Preco = new DataGridViewTextBoxColumn();
			QuntidadeItem = new DataGridViewTextBoxColumn();
			SubTotal = new DataGridViewTextBoxColumn();
			label1 = new Label();
			btnRegistrarNS = new Button();
			label3 = new Label();
			lblValorTotal = new Label();
			groupBox1 = new GroupBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			btnSelecionarRespNS = new Button();
			txbSobrenome = new TextBox();
			txbEmail = new TextBox();
			txbEndereco = new TextBox();
			txbNome = new TextBox();
			button1 = new Button();
			groupBox2 = new GroupBox();
			txbTelefone = new TextBox();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvProdutoDaNota).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvProdutoDaNota
			// 
			dgvProdutoDaNota.AllowUserToAddRows = false;
			dgvProdutoDaNota.AllowUserToDeleteRows = false;
			dgvProdutoDaNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvProdutoDaNota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProdutoDaNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdutoDaNota.Columns.AddRange(new DataGridViewColumn[] { IdProduto, NomeProduto, NomeUnidadeMedida, Preco, QuntidadeItem, SubTotal });
			dgvProdutoDaNota.Location = new Point(6, 60);
			dgvProdutoDaNota.MultiSelect = false;
			dgvProdutoDaNota.Name = "dgvProdutoDaNota";
			dgvProdutoDaNota.RowHeadersWidth = 51;
			dgvProdutoDaNota.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutoDaNota.Size = new Size(1006, 183);
			dgvProdutoDaNota.TabIndex = 2;
			dgvProdutoDaNota.CellContentClick += dgvProdutoDaNota_CellContentClick;
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
			// NomeUnidadeMedida
			// 
			NomeUnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
			NomeUnidadeMedida.HeaderText = "Unid. Medida";
			NomeUnidadeMedida.MinimumWidth = 6;
			NomeUnidadeMedida.Name = "NomeUnidadeMedida";
			NomeUnidadeMedida.ReadOnly = true;
			// 
			// Preco
			// 
			Preco.DataPropertyName = "Preco";
			Preco.HeaderText = "Val. R$";
			Preco.MinimumWidth = 6;
			Preco.Name = "Preco";
			Preco.ReadOnly = true;
			// 
			// QuntidadeItem
			// 
			QuntidadeItem.DataPropertyName = "Quantidade";
			dataGridViewCellStyle3.NullValue = "0";
			QuntidadeItem.DefaultCellStyle = dataGridViewCellStyle3;
			QuntidadeItem.HeaderText = "Qtd";
			QuntidadeItem.MinimumWidth = 6;
			QuntidadeItem.Name = "QuntidadeItem";
			// 
			// SubTotal
			// 
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = "0";
			SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
			SubTotal.HeaderText = "Sub. Total";
			SubTotal.MinimumWidth = 6;
			SubTotal.Name = "SubTotal";
			SubTotal.ReadOnly = true;
			SubTotal.ToolTipText = "Valor total da compra dessa mercadoria especifica";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(434, 9);
			label1.Name = "label1";
			label1.Size = new Size(190, 21);
			label1.TabIndex = 3;
			label1.Text = "Registro de Nota de Saida";
			// 
			// btnRegistrarNS
			// 
			btnRegistrarNS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnRegistrarNS.DialogResult = DialogResult.OK;
			btnRegistrarNS.Location = new Point(966, 614);
			btnRegistrarNS.Name = "btnRegistrarNS";
			btnRegistrarNS.Size = new Size(75, 23);
			btnRegistrarNS.TabIndex = 5;
			btnRegistrarNS.Text = "Registrar";
			btnRegistrarNS.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(748, 62);
			label3.Name = "label3";
			label3.Size = new Size(64, 15);
			label3.TabIndex = 4;
			label3.Text = "Valor Total:";
			// 
			// lblValorTotal
			// 
			lblValorTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblValorTotal.ForeColor = SystemColors.ControlText;
			lblValorTotal.Location = new Point(823, 62);
			lblValorTotal.Name = "lblValorTotal";
			lblValorTotal.Size = new Size(182, 32);
			lblValorTotal.TabIndex = 4;
			lblValorTotal.Text = "R$";
			lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnSelecionarRespNS);
			groupBox1.Controls.Add(txbSobrenome);
			groupBox1.Controls.Add(txbTelefone);
			groupBox1.Controls.Add(txbEmail);
			groupBox1.Controls.Add(txbEndereco);
			groupBox1.Controls.Add(txbNome);
			groupBox1.Location = new Point(12, 108);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1029, 194);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			groupBox1.Text = "Responsável";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(374, 51);
			label6.Name = "label6";
			label6.Size = new Size(71, 15);
			label6.TabIndex = 4;
			label6.Text = "Sobrenome:";
			label6.Click += label6_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 92);
			label5.Name = "label5";
			label5.Size = new Size(42, 15);
			label5.TabIndex = 4;
			label5.Text = "Email: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(13, 137);
			label4.Name = "label4";
			label4.Size = new Size(59, 15);
			label4.TabIndex = 4;
			label4.Text = "Endereço:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 51);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 4;
			label2.Text = "Nome:";
			// 
			// btnSelecionarRespNS
			// 
			btnSelecionarRespNS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSelecionarRespNS.DialogResult = DialogResult.OK;
			btnSelecionarRespNS.Location = new Point(811, 22);
			btnSelecionarRespNS.Name = "btnSelecionarRespNS";
			btnSelecionarRespNS.Size = new Size(169, 23);
			btnSelecionarRespNS.TabIndex = 5;
			btnSelecionarRespNS.Text = "Selecionar Responsável";
			btnSelecionarRespNS.UseVisualStyleBackColor = true;
			// 
			// txbSobrenome
			// 
			txbSobrenome.Enabled = false;
			txbSobrenome.Location = new Point(451, 48);
			txbSobrenome.Name = "txbSobrenome";
			txbSobrenome.ReadOnly = true;
			txbSobrenome.Size = new Size(176, 23);
			txbSobrenome.TabIndex = 6;
			// 
			// txbEmail
			// 
			txbEmail.Enabled = false;
			txbEmail.Location = new Point(62, 89);
			txbEmail.Name = "txbEmail";
			txbEmail.ReadOnly = true;
			txbEmail.Size = new Size(183, 23);
			txbEmail.TabIndex = 6;
			// 
			// txbEndereco
			// 
			txbEndereco.Enabled = false;
			txbEndereco.Location = new Point(78, 134);
			txbEndereco.Name = "txbEndereco";
			txbEndereco.ReadOnly = true;
			txbEndereco.Size = new Size(549, 23);
			txbEndereco.TabIndex = 6;
			// 
			// txbNome
			// 
			txbNome.Enabled = false;
			txbNome.Location = new Point(62, 48);
			txbNome.Name = "txbNome";
			txbNome.ReadOnly = true;
			txbNome.Size = new Size(288, 23);
			txbNome.TabIndex = 6;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(843, 22);
			button1.Name = "button1";
			button1.Size = new Size(169, 23);
			button1.TabIndex = 5;
			button1.Text = "Selecionar Produto";
			button1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(dgvProdutoDaNota);
			groupBox2.Location = new Point(12, 322);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1029, 262);
			groupBox2.TabIndex = 8;
			groupBox2.TabStop = false;
			groupBox2.Text = "Itens da Nota de Saida";
			// 
			// txbTelefone
			// 
			txbTelefone.Enabled = false;
			txbTelefone.Location = new Point(332, 92);
			txbTelefone.Name = "txbTelefone";
			txbTelefone.ReadOnly = true;
			txbTelefone.Size = new Size(183, 23);
			txbTelefone.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(284, 95);
			label7.Name = "label7";
			label7.Size = new Size(42, 15);
			label7.TabIndex = 4;
			label7.Text = "Email: ";
			// 
			// FormNotaSaida
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1053, 649);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(lblValorTotal);
			Controls.Add(label3);
			Controls.Add(btnRegistrarNS);
			Controls.Add(label1);
			Name = "FormNotaSaida";
			Load += FormNotaSaida_Load;
			((System.ComponentModel.ISupportInitialize)dgvProdutoDaNota).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvProdutoDaNota;
		private DataGridViewTextBoxColumn IdProduto;
		private DataGridViewTextBoxColumn NomeProduto;
		private DataGridViewTextBoxColumn NomeUnidadeMedida;
		private DataGridViewTextBoxColumn Preco;
		private DataGridViewTextBoxColumn QuntidadeItem;
		private DataGridViewTextBoxColumn SubTotal;
		private Label label1;
		private Button btnRegistrarNS;
		private Label label3;
		private Label lblValorTotal;
		private GroupBox groupBox1;
		private Button btnSelecionarRespNS;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label2;
		private TextBox txbSobrenome;
		private TextBox txbEmail;
		private TextBox txbEndereco;
		private TextBox txbNome;
		private Button button1;
		private GroupBox groupBox2;
		private Label label7;
		private TextBox txbTelefone;
	}
}