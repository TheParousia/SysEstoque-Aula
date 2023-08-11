namespace SysEstoque.Models {
	partial class FormCategoria {
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
			dgvCategorias = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			Descricao = new DataGridViewTextBoxColumn();
			label1 = new Label();
			txbNome = new TextBox();
			label2 = new Label();
			txbDescricao = new TextBox();
			label3 = new Label();
			btnAtualizar = new Button();
			btnExcluir = new Button();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			statusMsg = new ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnSalvar
			// 
			btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSalvar.Location = new Point(538, 159);
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
			// dgvCategorias
			// 
			dgvCategorias.AllowUserToAddRows = false;
			dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao });
			dgvCategorias.Location = new Point(10, 200);
			dgvCategorias.Margin = new Padding(3, 2, 3, 2);
			dgvCategorias.MultiSelect = false;
			dgvCategorias.Name = "dgvCategorias";
			dgvCategorias.ReadOnly = true;
			dgvCategorias.RowHeadersWidth = 51;
			dgvCategorias.RowTemplate.Height = 29;
			dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCategorias.Size = new Size(633, 153);
			dgvCategorias.TabIndex = 2;
			dgvCategorias.UserDeletedRow += dgvCategorias_UserDeletedRow;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			// 
			// Nome
			// 
			Nome.DataPropertyName = "Nome";
			Nome.HeaderText = "Nome";
			Nome.MinimumWidth = 6;
			Nome.Name = "Nome";
			Nome.ReadOnly = true;
			// 
			// Descricao
			// 
			Descricao.DataPropertyName = "Descricao";
			Descricao.HeaderText = "Descrição";
			Descricao.MinimumWidth = 6;
			Descricao.Name = "Descricao";
			Descricao.ReadOnly = true;
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
			// txbNome
			// 
			txbNome.Location = new Point(108, 82);
			txbNome.Margin = new Padding(3, 2, 3, 2);
			txbNome.Name = "txbNome";
			txbNome.Size = new Size(144, 23);
			txbNome.TabIndex = 1;
			txbNome.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(24, 82);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 3;
			label2.Text = "Nome:";
			// 
			// txbDescricao
			// 
			txbDescricao.Location = new Point(108, 112);
			txbDescricao.Margin = new Padding(3, 2, 3, 2);
			txbDescricao.Name = "txbDescricao";
			txbDescricao.Size = new Size(215, 23);
			txbDescricao.TabIndex = 1;
			txbDescricao.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(24, 114);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 3;
			label3.Text = "Descrição:";
			// 
			// btnAtualizar
			// 
			btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAtualizar.Location = new Point(538, 369);
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
			btnExcluir.Location = new Point(404, 369);
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
			statusStrip1.Location = new Point(0, 398);
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
			// FormCategoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(659, 420);
			Controls.Add(statusStrip1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvCategorias);
			Controls.Add(txbDescricao);
			Controls.Add(txbNome);
			Controls.Add(txbId);
			Controls.Add(btnExcluir);
			Controls.Add(btnAtualizar);
			Controls.Add(btnSalvar);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormCategoria";
			Text = "Categoria";
			((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSalvar;
		private TextBox txbId;
		private DataGridView dgvCategorias;
		private Label label1;
		private TextBox txbNome;
		private Label label2;
		private TextBox txbDescricao;
		private Label label3;
		private Button btnAtualizar;
		private Button btnExcluir;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Nome;
		private DataGridViewTextBoxColumn Descricao;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel statusMsg;
	}
}