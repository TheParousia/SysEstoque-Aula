namespace SysEstoque {
	partial class FormSelectProduto {
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
			dgvProdutosDisponiveis = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			Estoque = new DataGridViewTextBoxColumn();
			dgvProdutosSelecionados = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProdutosDisponiveis).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvProdutosSelecionados).BeginInit();
			SuspendLayout();
			// 
			// dgvProdutosDisponiveis
			// 
			dgvProdutosDisponiveis.AllowUserToAddRows = false;
			dgvProdutosDisponiveis.AllowUserToDeleteRows = false;
			dgvProdutosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProdutosDisponiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdutosDisponiveis.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Estoque });
			dgvProdutosDisponiveis.Location = new Point(12, 69);
			dgvProdutosDisponiveis.Name = "dgvProdutosDisponiveis";
			dgvProdutosDisponiveis.ReadOnly = true;
			dgvProdutosDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutosDisponiveis.Size = new Size(350, 290);
			dgvProdutosDisponiveis.TabIndex = 0;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			// 
			// Nome
			// 
			Nome.DataPropertyName = "Nome";
			Nome.HeaderText = "Nome";
			Nome.Name = "Nome";
			Nome.ReadOnly = true;
			// 
			// Estoque
			// 
			Estoque.DataPropertyName = "Estoque";
			Estoque.HeaderText = "Estoque";
			Estoque.Name = "Estoque";
			Estoque.ReadOnly = true;
			// 
			// dgvProdutosSelecionados
			// 
			dgvProdutosSelecionados.AllowUserToAddRows = false;
			dgvProdutosSelecionados.AllowUserToDeleteRows = false;
			dgvProdutosSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdutosSelecionados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
			dgvProdutosSelecionados.Location = new Point(438, 69);
			dgvProdutosSelecionados.MultiSelect = false;
			dgvProdutosSelecionados.Name = "dgvProdutosSelecionados";
			dgvProdutosSelecionados.ReadOnly = true;
			dgvProdutosSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdutosSelecionados.Size = new Size(350, 290);
			dgvProdutosSelecionados.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			dataGridViewTextBoxColumn1.HeaderText = "Id";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 102;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
			dataGridViewTextBoxColumn2.HeaderText = "Nome";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			dataGridViewTextBoxColumn2.Width = 103;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.DataPropertyName = "Estoque";
			dataGridViewTextBoxColumn3.HeaderText = "Estoque";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			dataGridViewTextBoxColumn3.Width = 102;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 36);
			label1.Name = "label1";
			label1.Size = new Size(101, 15);
			label1.TabIndex = 1;
			label1.Text = "Lista de Produtos:";
			// 
			// button1
			// 
			button1.Location = new Point(378, 131);
			button1.Name = "button1";
			button1.Size = new Size(34, 23);
			button1.TabIndex = 3;
			button1.Text = "▶️";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(378, 258);
			button2.Name = "button2";
			button2.Size = new Size(36, 23);
			button2.TabIndex = 3;
			button2.Text = "◀️";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.DialogResult = DialogResult.OK;
			button3.Location = new Point(677, 396);
			button3.Name = "button3";
			button3.Size = new Size(72, 23);
			button3.TabIndex = 3;
			button3.Text = "Salvar";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// FormSelectProduto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dgvProdutosSelecionados);
			Controls.Add(label1);
			Controls.Add(dgvProdutosDisponiveis);
			Name = "FormSelectProduto";
			Text = "FormSelectProduto";
			((System.ComponentModel.ISupportInitialize)dgvProdutosDisponiveis).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvProdutosSelecionados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dgvProdutosDisponiveis;
		private Label label1;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Nome;
		private DataGridViewTextBoxColumn Estoque;
		private DataGridView dgvProdutosSelecionados;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}