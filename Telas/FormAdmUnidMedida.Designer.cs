namespace SysEstoque {
	partial class FormAdmUnidMedida {
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
			btnSave = new Button();
			label1 = new Label();
			nomeUnidMedida = new TextBox();
			dgvUnidMedida = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			Descricao = new DataGridViewTextBoxColumn();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			descricaoUnidMedida = new TextBox();
			txbId = new Label();
			label5 = new Label();
			btnEditar = new Button();
			btnExcluir = new Button();
			btnLimparText = new Button();
			((System.ComponentModel.ISupportInitialize)dgvUnidMedida).BeginInit();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSave.Location = new Point(358, 162);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 3;
			btnSave.Text = "Salvar";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 124);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 1;
			label1.Text = "Sigla:";
			// 
			// nomeUnidMedida
			// 
			nomeUnidMedida.Location = new Point(87, 121);
			nomeUnidMedida.Name = "nomeUnidMedida";
			nomeUnidMedida.Size = new Size(102, 23);
			nomeUnidMedida.TabIndex = 1;
			// 
			// dgvUnidMedida
			// 
			dgvUnidMedida.AllowUserToAddRows = false;
			dgvUnidMedida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvUnidMedida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUnidMedida.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao });
			dgvUnidMedida.Location = new Point(5, 275);
			dgvUnidMedida.MultiSelect = false;
			dgvUnidMedida.Name = "dgvUnidMedida";
			dgvUnidMedida.ReadOnly = true;
			dgvUnidMedida.RowTemplate.Height = 25;
			dgvUnidMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUnidMedida.Size = new Size(428, 150);
			dgvUnidMedida.TabIndex = 5;
			dgvUnidMedida.CellClick += dgvUnidMedida_CellClick;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.FillWeight = 53.29949F;
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			// 
			// Nome
			// 
			Nome.DataPropertyName = "Nome";
			Nome.FillWeight = 123.35025F;
			Nome.HeaderText = "Nome";
			Nome.Name = "Nome";
			Nome.ReadOnly = true;
			// 
			// Descricao
			// 
			Descricao.DataPropertyName = "Descricao";
			Descricao.FillWeight = 123.35025F;
			Descricao.HeaderText = "Descrição";
			Descricao.Name = "Descricao";
			Descricao.ReadOnly = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(5, 244);
			label2.Name = "label2";
			label2.Size = new Size(113, 15);
			label2.TabIndex = 1;
			label2.Text = "Unidade de Medida:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 87);
			label3.Name = "label3";
			label3.Size = new Size(20, 15);
			label3.TabIndex = 1;
			label3.Text = "Id:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(16, 162);
			label4.Name = "label4";
			label4.Size = new Size(61, 15);
			label4.TabIndex = 1;
			label4.Text = "Descrição:";
			// 
			// descricaoUnidMedida
			// 
			descricaoUnidMedida.Location = new Point(87, 162);
			descricaoUnidMedida.Name = "descricaoUnidMedida";
			descricaoUnidMedida.Size = new Size(245, 23);
			descricaoUnidMedida.TabIndex = 2;
			// 
			// txbId
			// 
			txbId.BackColor = SystemColors.ActiveCaption;
			txbId.Enabled = false;
			txbId.Location = new Point(87, 85);
			txbId.Name = "txbId";
			txbId.Size = new Size(102, 18);
			txbId.TabIndex = 1;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(12, 2);
			label5.Name = "label5";
			label5.Size = new Size(421, 75);
			label5.TabIndex = 1;
			label5.Text = "Configurar Unidade de Medida";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnEditar
			// 
			btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEditar.Location = new Point(358, 443);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(75, 23);
			btnEditar.TabIndex = 6;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = true;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnExcluir
			// 
			btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnExcluir.Location = new Point(220, 443);
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Size = new Size(75, 23);
			btnExcluir.TabIndex = 7;
			btnExcluir.Text = "Excluir";
			btnExcluir.UseVisualStyleBackColor = true;
			btnExcluir.Click += btnExcluir_Click;
			// 
			// btnLimparText
			// 
			btnLimparText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnLimparText.Location = new Point(358, 204);
			btnLimparText.Name = "btnLimparText";
			btnLimparText.Size = new Size(75, 23);
			btnLimparText.TabIndex = 4;
			btnLimparText.Text = "Limpar";
			btnLimparText.UseVisualStyleBackColor = true;
			btnLimparText.Click += btnLimparText_Click;
			// 
			// FormAdmUnidMedida
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(445, 478);
			Controls.Add(dgvUnidMedida);
			Controls.Add(descricaoUnidMedida);
			Controls.Add(nomeUnidMedida);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(txbId);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(btnExcluir);
			Controls.Add(btnEditar);
			Controls.Add(btnLimparText);
			Controls.Add(btnSave);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "FormAdmUnidMedida";
			ShowIcon = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Configurar Unidades de Medida";
			FormClosed += FormAdmUnidMedida_FormClosed;
			Load += FormAdmUnidMedida_Load;
			((System.ComponentModel.ISupportInitialize)dgvUnidMedida).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSave;
		private Label label1;
		private TextBox nomeUnidMedida;
		private DataGridView dgvUnidMedida;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox descricaoUnidMedida;
		private Label txbId;
		private Label label5;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Nome;
		private DataGridViewTextBoxColumn Descricao;
		private Button btnEditar;
		private Button btnExcluir;
		private Button btnLimparText;
	}
}