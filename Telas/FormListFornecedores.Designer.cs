namespace SysEstoque {
	partial class FormListFornecedores {
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
			dgvFornecedoresNSelected = new DataGridView();
			CNPJ = new DataGridViewTextBoxColumn();
			RazaoSocial = new DataGridViewTextBoxColumn();
			NomeFantasia = new DataGridViewTextBoxColumn();
			label1 = new Label();
			Salvar = new Button();
			dgvFornecedoresSelected = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			NomeFatasia = new DataGridViewTextBoxColumn();
			btnAddFornecedor = new Button();
			btnRemovFornecedor = new Button();
			((System.ComponentModel.ISupportInitialize)dgvFornecedoresNSelected).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvFornecedoresSelected).BeginInit();
			SuspendLayout();
			// 
			// dgvFornecedoresNSelected
			// 
			dgvFornecedoresNSelected.AllowUserToAddRows = false;
			dgvFornecedoresNSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvFornecedoresNSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvFornecedoresNSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFornecedoresNSelected.Columns.AddRange(new DataGridViewColumn[] { CNPJ, RazaoSocial, NomeFantasia });
			dgvFornecedoresNSelected.Location = new Point(12, 71);
			dgvFornecedoresNSelected.MultiSelect = false;
			dgvFornecedoresNSelected.Name = "dgvFornecedoresNSelected";
			dgvFornecedoresNSelected.ReadOnly = true;
			dgvFornecedoresNSelected.RowTemplate.Height = 25;
			dgvFornecedoresNSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvFornecedoresNSelected.Size = new Size(475, 420);
			dgvFornecedoresNSelected.TabIndex = 0;
			// 
			// CNPJ
			// 
			CNPJ.DataPropertyName = "CNPJ";
			CNPJ.HeaderText = "CNPJ";
			CNPJ.Name = "CNPJ";
			CNPJ.ReadOnly = true;
			// 
			// RazaoSocial
			// 
			RazaoSocial.DataPropertyName = "RazaoSocial";
			RazaoSocial.HeaderText = "Razão Social";
			RazaoSocial.Name = "RazaoSocial";
			RazaoSocial.ReadOnly = true;
			// 
			// NomeFantasia
			// 
			NomeFantasia.DataPropertyName = "NomeFantasia";
			NomeFantasia.HeaderText = "Nome Fantasia";
			NomeFantasia.Name = "NomeFantasia";
			NomeFantasia.ReadOnly = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 24);
			label1.Name = "label1";
			label1.Size = new Size(130, 28);
			label1.TabIndex = 1;
			label1.Text = "Fornecedores";
			// 
			// Salvar
			// 
			Salvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Salvar.DialogResult = DialogResult.OK;
			Salvar.Location = new Point(1009, 545);
			Salvar.Name = "Salvar";
			Salvar.Size = new Size(75, 23);
			Salvar.TabIndex = 2;
			Salvar.Text = "Salvar";
			Salvar.UseVisualStyleBackColor = true;
			Salvar.Click += button1_Click;
			// 
			// dgvFornecedoresSelected
			// 
			dgvFornecedoresSelected.AllowUserToAddRows = false;
			dgvFornecedoresSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvFornecedoresSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvFornecedoresSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFornecedoresSelected.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, NomeFatasia });
			dgvFornecedoresSelected.Location = new Point(608, 71);
			dgvFornecedoresSelected.MultiSelect = false;
			dgvFornecedoresSelected.Name = "dgvFornecedoresSelected";
			dgvFornecedoresSelected.ReadOnly = true;
			dgvFornecedoresSelected.RowTemplate.Height = 25;
			dgvFornecedoresSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvFornecedoresSelected.Size = new Size(476, 420);
			dgvFornecedoresSelected.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.DataPropertyName = "CNPJ";
			dataGridViewTextBoxColumn1.HeaderText = "CNPJ";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "RazaoSocial";
			dataGridViewTextBoxColumn2.HeaderText = "Razão Social";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// NomeFatasia
			// 
			NomeFatasia.DataPropertyName = "NomeFantasia";
			NomeFatasia.HeaderText = "Nome Fantasia";
			NomeFatasia.Name = "NomeFatasia";
			NomeFatasia.ReadOnly = true;
			// 
			// btnAddFornecedor
			// 
			btnAddFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnAddFornecedor.Location = new Point(505, 178);
			btnAddFornecedor.Name = "btnAddFornecedor";
			btnAddFornecedor.Size = new Size(84, 26);
			btnAddFornecedor.TabIndex = 2;
			btnAddFornecedor.Text = "▶️ Adicionar";
			btnAddFornecedor.UseVisualStyleBackColor = true;
			btnAddFornecedor.Click += btnAddFornecedor_Click;
			// 
			// btnRemovFornecedor
			// 
			btnRemovFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnRemovFornecedor.Location = new Point(505, 278);
			btnRemovFornecedor.Name = "btnRemovFornecedor";
			btnRemovFornecedor.Size = new Size(84, 23);
			btnRemovFornecedor.TabIndex = 2;
			btnRemovFornecedor.Text = "◀️ Remover";
			btnRemovFornecedor.UseVisualStyleBackColor = true;
			btnRemovFornecedor.Click += btnRemovFornecedor_Click;
			// 
			// FormListFornecedores
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1093, 580);
			Controls.Add(dgvFornecedoresSelected);
			Controls.Add(btnRemovFornecedor);
			Controls.Add(btnAddFornecedor);
			Controls.Add(Salvar);
			Controls.Add(label1);
			Controls.Add(dgvFornecedoresNSelected);
			Name = "FormListFornecedores";
			Text = "FormListFornecedores";
			Load += FormListFornecedores_Load;
			((System.ComponentModel.ISupportInitialize)dgvFornecedoresNSelected).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvFornecedoresSelected).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvFornecedoresNSelected;
		private Label label1;
		private Button Salvar;
		private DataGridViewTextBoxColumn CNPJ;
		private DataGridViewTextBoxColumn RazaoSocial;
		private DataGridViewTextBoxColumn NomeFantasia;
		private DataGridView dgvFornecedoresSelected;
		private Button btnAddFornecedor;
		private Button btnRemovFornecedor;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn NomeFatasia;
	}
}