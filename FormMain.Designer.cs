namespace SysEstoque {
	partial class FormMain {
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
			label1 = new Label();
			dgvProdutos = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			Preco = new DataGridViewTextBoxColumn();
			Estoque = new DataGridViewTextBoxColumn();
			UnidadeMedida = new DataGridViewTextBoxColumn();
			Categoria = new DataGridViewTextBoxColumn();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(348, 26);
			label1.Name = "label1";
			label1.Size = new Size(117, 21);
			label1.TabIndex = 0;
			label1.Text = "Janela Principal";
			// 
			// dgvProdutos
			// 
			dgvProdutos.AllowUserToAddRows = false;
			dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, Estoque, UnidadeMedida, Categoria });
			dgvProdutos.Location = new Point(12, 103);
			dgvProdutos.Name = "dgvProdutos";
			dgvProdutos.ReadOnly = true;
			dgvProdutos.RowTemplate.Height = 25;
			dgvProdutos.Size = new Size(768, 147);
			dgvProdutos.TabIndex = 1;
			dgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
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
			// Preco
			// 
			Preco.DataPropertyName = "Preco";
			Preco.HeaderText = "Preço";
			Preco.Name = "Preco";
			Preco.ReadOnly = true;
			// 
			// Estoque
			// 
			Estoque.DataPropertyName = "Estoque";
			Estoque.HeaderText = "Estoque";
			Estoque.Name = "Estoque";
			Estoque.ReadOnly = true;
			// 
			// UnidadeMedida
			// 
			UnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
			UnidadeMedida.HeaderText = "Uni. de Medida";
			UnidadeMedida.Name = "UnidadeMedida";
			UnidadeMedida.ReadOnly = true;
			// 
			// Categoria
			// 
			Categoria.DataPropertyName = "Categoria.Nome";
			Categoria.HeaderText = "Categoria";
			Categoria.Name = "Categoria";
			Categoria.ReadOnly = true;
			// 
			// button1
			// 
			button1.Location = new Point(705, 74);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Add prod";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(dgvProdutos);
			Controls.Add(label1);
			Name = "FormMain";
			Text = "FormMain";
			FormClosed += FormMain_FormClosed;
			((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dgvProdutos;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Nome;
		private DataGridViewTextBoxColumn Preco;
		private DataGridViewTextBoxColumn Estoque;
		private DataGridViewTextBoxColumn UnidadeMedida;
		private DataGridViewTextBoxColumn Categoria;
		private Button button1;
	}
}