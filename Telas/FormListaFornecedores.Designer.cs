namespace SysEstoque {
	partial class FormListaFornecedores {
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
			dgvFornecedores = new DataGridView();
			label1 = new Label();
			button1 = new Button();
			CNPJ = new DataGridViewTextBoxColumn();
			RazaoSocial = new DataGridViewTextBoxColumn();
			NomeFantasia = new DataGridViewTextBoxColumn();
			CNAEPrincipal = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
			SuspendLayout();
			// 
			// dgvFornecedores
			// 
			dgvFornecedores.AllowUserToAddRows = false;
			dgvFornecedores.AllowUserToDeleteRows = false;
			dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFornecedores.Columns.AddRange(new DataGridViewColumn[] { CNPJ, RazaoSocial, NomeFantasia, CNAEPrincipal });
			dgvFornecedores.Location = new Point(12, 48);
			dgvFornecedores.MultiSelect = false;
			dgvFornecedores.Name = "dgvFornecedores";
			dgvFornecedores.ReadOnly = true;
			dgvFornecedores.RowTemplate.Height = 25;
			dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvFornecedores.Size = new Size(776, 310);
			dgvFornecedores.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 30);
			label1.Name = "label1";
			label1.Size = new Size(121, 15);
			label1.TabIndex = 1;
			label1.Text = "Listade Fornecedores:";
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(576, 397);
			button1.Name = "button1";
			button1.Size = new Size(191, 23);
			button1.TabIndex = 2;
			button1.Text = "Selecionar Forncedor:";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
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
			NomeFantasia.HeaderText = "Nome Fantazia";
			NomeFantasia.Name = "NomeFantasia";
			NomeFantasia.ReadOnly = true;
			// 
			// CNAEPrincipal
			// 
			CNAEPrincipal.DataPropertyName = "CNAEPrincipal";
			CNAEPrincipal.HeaderText = "CNAEPrincipal";
			CNAEPrincipal.Name = "CNAEPrincipal";
			CNAEPrincipal.ReadOnly = true;
			// 
			// FormListaFornecedores
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(dgvFornecedores);
			Name = "FormListaFornecedores";
			Text = "FormListaFornecedores";
			((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvFornecedores;
		private Label label1;
		private Button button1;
		private DataGridViewTextBoxColumn CNPJ;
		private DataGridViewTextBoxColumn RazaoSocial;
		private DataGridViewTextBoxColumn NomeFantasia;
		private DataGridViewTextBoxColumn CNAEPrincipal;
	}
}