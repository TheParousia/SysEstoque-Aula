namespace SysEstoque.Models {
	partial class FormEndereco {
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
			btnSalvar = new Button();
			txbId = new TextBox();
			dgvEnderecos = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			CEP = new DataGridViewTextBoxColumn();
			Bairro = new DataGridViewTextBoxColumn();
			Rua = new DataGridViewTextBoxColumn();
			Numero = new DataGridViewTextBoxColumn();
			label1 = new Label();
			txbCEP = new TextBox();
			label2 = new Label();
			txbRua = new TextBox();
			label3 = new Label();
			btnAtualizar = new Button();
			btnExcluir = new Button();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			statusMsg = new ToolStripStatusLabel();
			txbBairro = new TextBox();
			label4 = new Label();
			txbNumero = new TextBox();
			label5 = new Label();
			btnConsultar = new Button();
			lbStaturConsultaAPI = new Label();
			((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnSalvar
			// 
			btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSalvar.Location = new Point(538, 221);
			btnSalvar.Margin = new Padding(3, 2, 3, 2);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(82, 22);
			btnSalvar.TabIndex = 0;
			btnSalvar.Text = "Salvar";
			btnSalvar.UseVisualStyleBackColor = true;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// txbId
			// 
			txbId.Location = new Point(108, 46);
			txbId.Margin = new Padding(3, 2, 3, 2);
			txbId.Name = "txbId";
			txbId.ReadOnly = true;
			txbId.Size = new Size(75, 23);
			txbId.TabIndex = 1;
			txbId.TextChanged += textBox1_TextChanged;
			// 
			// dgvEnderecos
			// 
			dgvEnderecos.AllowUserToAddRows = false;
			dgvEnderecos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvEnderecos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { Id, CEP, Bairro, Rua, Numero });
			dgvEnderecos.Location = new Point(10, 260);
			dgvEnderecos.Margin = new Padding(3, 2, 3, 2);
			dgvEnderecos.MultiSelect = false;
			dgvEnderecos.Name = "dgvEnderecos";
			dgvEnderecos.ReadOnly = true;
			dgvEnderecos.RowHeadersWidth = 51;
			dgvEnderecos.RowTemplate.Height = 29;
			dgvEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvEnderecos.Size = new Size(633, 154);
			dgvEnderecos.TabIndex = 2;
			dgvEnderecos.UserDeletedRow += dgvCategorias_UserDeletedRow;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			// 
			// CEP
			// 
			CEP.DataPropertyName = "CEP";
			CEP.HeaderText = "CEP";
			CEP.MinimumWidth = 6;
			CEP.Name = "CEP";
			CEP.ReadOnly = true;
			// 
			// Bairro
			// 
			Bairro.DataPropertyName = "Bairro";
			Bairro.HeaderText = "Bairro";
			Bairro.Name = "Bairro";
			Bairro.ReadOnly = true;
			// 
			// Rua
			// 
			Rua.DataPropertyName = "Rua";
			Rua.HeaderText = "Rua";
			Rua.MinimumWidth = 6;
			Rua.Name = "Rua";
			Rua.ReadOnly = true;
			// 
			// Numero
			// 
			Numero.DataPropertyName = "Numero";
			Numero.HeaderText = "Número";
			Numero.Name = "Numero";
			Numero.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(24, 48);
			label1.Name = "label1";
			label1.Size = new Size(20, 15);
			label1.TabIndex = 3;
			label1.Text = "Id:";
			// 
			// txbCEP
			// 
			txbCEP.Location = new Point(258, 46);
			txbCEP.Margin = new Padding(3, 2, 3, 2);
			txbCEP.Name = "txbCEP";
			txbCEP.Size = new Size(144, 23);
			txbCEP.TabIndex = 1;
			txbCEP.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(209, 49);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 3;
			label2.Text = "CEP:";
			// 
			// txbRua
			// 
			txbRua.Location = new Point(108, 94);
			txbRua.Margin = new Padding(3, 2, 3, 2);
			txbRua.Name = "txbRua";
			txbRua.Size = new Size(215, 23);
			txbRua.TabIndex = 1;
			txbRua.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(24, 94);
			label3.Name = "label3";
			label3.Size = new Size(30, 15);
			label3.TabIndex = 3;
			label3.Text = "Rua:";
			// 
			// btnAtualizar
			// 
			btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAtualizar.Location = new Point(538, 430);
			btnAtualizar.Margin = new Padding(3, 2, 3, 2);
			btnAtualizar.Name = "btnAtualizar";
			btnAtualizar.Size = new Size(82, 22);
			btnAtualizar.TabIndex = 0;
			btnAtualizar.Text = "Atualizar";
			btnAtualizar.UseVisualStyleBackColor = true;
			btnAtualizar.Click += btnAtualizar_Click;
			// 
			// btnExcluir
			// 
			btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnExcluir.Location = new Point(404, 430);
			btnExcluir.Margin = new Padding(3, 2, 3, 2);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(82, 22);
			btnExcluir.TabIndex = 0;
			btnExcluir.Text = "Excluir";
			btnExcluir.UseVisualStyleBackColor = true;
			btnExcluir.Click += btnExcluir_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusMsg });
			statusStrip1.Location = new Point(0, 459);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(659, 22);
			statusStrip1.TabIndex = 4;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(62, 17);
			toolStripStatusLabel1.Text = "Mesagem:";
			// 
			// statusMsg
			// 
			statusMsg.AutoSize = false;
			statusMsg.Name = "statusMsg";
			statusMsg.Size = new Size(400, 17);
			// 
			// txbBairro
			// 
			txbBairro.Location = new Point(108, 133);
			txbBairro.Margin = new Padding(3, 2, 3, 2);
			txbBairro.Name = "txbBairro";
			txbBairro.Size = new Size(215, 23);
			txbBairro.TabIndex = 1;
			txbBairro.TextChanged += textBox1_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(24, 136);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 3;
			label4.Text = "Bairro:";
			// 
			// txbNumero
			// 
			txbNumero.Location = new Point(418, 91);
			txbNumero.Margin = new Padding(3, 2, 3, 2);
			txbNumero.Name = "txbNumero";
			txbNumero.Size = new Size(97, 23);
			txbNumero.TabIndex = 1;
			txbNumero.TextChanged += textBox1_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(334, 94);
			label5.Name = "label5";
			label5.Size = new Size(54, 15);
			label5.TabIndex = 3;
			label5.Text = "Número:";
			// 
			// btnConsultar
			// 
			btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnConsultar.Location = new Point(433, 47);
			btnConsultar.Margin = new Padding(3, 2, 3, 2);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(82, 22);
			btnConsultar.TabIndex = 0;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// lbStaturConsultaAPI
			// 
			lbStaturConsultaAPI.Location = new Point(521, 51);
			lbStaturConsultaAPI.Name = "lbStaturConsultaAPI";
			lbStaturConsultaAPI.Size = new Size(122, 18);
			lbStaturConsultaAPI.TabIndex = 3;
			// 
			// FormEndereco
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(659, 481);
			Controls.Add(statusStrip1);
			Controls.Add(lbStaturConsultaAPI);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvEnderecos);
			Controls.Add(txbNumero);
			Controls.Add(txbBairro);
			Controls.Add(txbRua);
			Controls.Add(txbCEP);
			Controls.Add(txbId);
			Controls.Add(btnExcluir);
			Controls.Add(btnAtualizar);
			Controls.Add(btnConsultar);
			Controls.Add(btnSalvar);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormEndereco";
			Text = "Endereços";
			((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSalvar;
		private TextBox txbId;
		private DataGridView dgvEnderecos;
		private Label label1;
		private TextBox txbCEP;
		private Label label2;
		private TextBox txbRua;
		private Label label3;
		private Button btnAtualizar;
		private Button btnExcluir;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel statusMsg;
		private TextBox txbBairro;
		private Label label4;
		private TextBox txbNumero;
		private Label label5;
		private Button btnConsultar;
		private Label lbStaturConsultaAPI;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn CEP;
		private DataGridViewTextBoxColumn Bairro;
		private DataGridViewTextBoxColumn Rua;
		private DataGridViewTextBoxColumn Numero;
	}
}