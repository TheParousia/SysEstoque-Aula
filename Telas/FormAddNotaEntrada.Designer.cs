namespace SysEstoque.Telas {
	partial class FormAddNotaEntrada {
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
			components = new System.ComponentModel.Container();
			regNota = new Button();
			label1 = new Label();
			dgvItenNotaEntrada = new DataGridView();
			itemNotaEntradaBindingSource = new BindingSource(components);
			groupBox1 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			textBox3 = new TextBox();
			button2 = new Button();
			textBox2 = new TextBox();
			txbCNPJ = new TextBox();
			label2 = new Label();
			groupBox2 = new GroupBox();
			tdpDataEntrada = new DateTimePicker();
			label6 = new Label();
			label9 = new Label();
			label7 = new Label();
			label8 = new Label();
			txbSerie = new TextBox();
			txbNumeroNota = new TextBox();
			txbValorTotal = new TextBox();
			IdProduto = new DataGridViewTextBoxColumn();
			Nome = new DataGridViewTextBoxColumn();
			Id = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvItenNotaEntrada).BeginInit();
			((System.ComponentModel.ISupportInitialize)itemNotaEntradaBindingSource).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// regNota
			// 
			regNota.Location = new Point(644, 624);
			regNota.Name = "regNota";
			regNota.Size = new Size(144, 23);
			regNota.TabIndex = 0;
			regNota.Text = "Registrar Nota";
			regNota.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 317);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 1;
			label1.Text = "Produtos";
			// 
			// dgvItenNotaEntrada
			// 
			dgvItenNotaEntrada.AllowUserToAddRows = false;
			dgvItenNotaEntrada.AllowUserToDeleteRows = false;
			dgvItenNotaEntrada.AutoGenerateColumns = false;
			dgvItenNotaEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvItenNotaEntrada.DataSource = itemNotaEntradaBindingSource;
			dgvItenNotaEntrada.Location = new Point(12, 347);
			dgvItenNotaEntrada.Name = "dgvItenNotaEntrada";
			dgvItenNotaEntrada.ReadOnly = true;
			dgvItenNotaEntrada.RowTemplate.Height = 25;
			dgvItenNotaEntrada.Size = new Size(776, 243);
			dgvItenNotaEntrada.TabIndex = 2;
			dgvItenNotaEntrada.CellFormatting += dgvItenNotaEntrada_CellFormatting;
			// 
			// itemNotaEntradaBindingSource
			// 
			itemNotaEntradaBindingSource.DataSource = typeof(Models.ItemNotaEntrada);
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textBox3);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(txbCNPJ);
			groupBox1.Location = new Point(12, 154);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(776, 139);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Fornecedor";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(17, 73);
			label5.Name = "label5";
			label5.Size = new Size(75, 15);
			label5.TabIndex = 4;
			label5.Text = "Razão Social:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(231, 33);
			label4.Name = "label4";
			label4.Size = new Size(89, 15);
			label4.TabIndex = 4;
			label4.Text = "Nome Fantasia:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(18, 33);
			label3.Name = "label3";
			label3.Size = new Size(37, 15);
			label3.TabIndex = 4;
			label3.Text = "CNPJ:";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(112, 70);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(398, 23);
			textBox3.TabIndex = 0;
			// 
			// button2
			// 
			button2.Location = new Point(615, 100);
			button2.Name = "button2";
			button2.Size = new Size(144, 23);
			button2.TabIndex = 0;
			button2.Text = "Selecionar Fornecedor";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(326, 30);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(398, 23);
			textBox2.TabIndex = 0;
			// 
			// txbCNPJ
			// 
			txbCNPJ.Location = new Point(61, 30);
			txbCNPJ.Name = "txbCNPJ";
			txbCNPJ.Size = new Size(131, 23);
			txbCNPJ.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(286, 24);
			label2.Name = "label2";
			label2.Size = new Size(146, 15);
			label2.TabIndex = 4;
			label2.Text = "Adicionar Nota de Entrada";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(tdpDataEntrada);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(txbSerie);
			groupBox2.Controls.Add(txbNumeroNota);
			groupBox2.Controls.Add(txbValorTotal);
			groupBox2.Location = new Point(18, 42);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(776, 106);
			groupBox2.TabIndex = 5;
			groupBox2.TabStop = false;
			groupBox2.Text = "Nota de Entada";
			// 
			// tdpDataEntrada
			// 
			tdpDataEntrada.Location = new Point(127, 69);
			tdpDataEntrada.Name = "tdpDataEntrada";
			tdpDataEntrada.Size = new Size(200, 23);
			tdpDataEntrada.TabIndex = 5;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(528, 25);
			label6.Name = "label6";
			label6.Size = new Size(64, 15);
			label6.TabIndex = 4;
			label6.Text = "Valor Total:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(292, 27);
			label9.Name = "label9";
			label9.Size = new Size(35, 15);
			label9.TabIndex = 4;
			label9.Text = "Série:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(22, 27);
			label7.Name = "label7";
			label7.Size = new Size(99, 15);
			label7.TabIndex = 4;
			label7.Text = "Número da Nota:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(28, 75);
			label8.Name = "label8";
			label8.Size = new Size(93, 15);
			label8.TabIndex = 4;
			label8.Text = "Data de Entrada:";
			// 
			// txbSerie
			// 
			txbSerie.Location = new Point(367, 24);
			txbSerie.Name = "txbSerie";
			txbSerie.Size = new Size(118, 23);
			txbSerie.TabIndex = 0;
			// 
			// txbNumeroNota
			// 
			txbNumeroNota.Location = new Point(127, 27);
			txbNumeroNota.Name = "txbNumeroNota";
			txbNumeroNota.Size = new Size(118, 23);
			txbNumeroNota.TabIndex = 0;
			// 
			// txbValorTotal
			// 
			txbValorTotal.Enabled = false;
			txbValorTotal.Location = new Point(609, 21);
			txbValorTotal.Name = "txbValorTotal";
			txbValorTotal.Size = new Size(146, 23);
			txbValorTotal.TabIndex = 0;
			// 
			// IdProduto
			// 
			IdProduto.HeaderText = "Id";
			IdProduto.Name = "IdProduto";
			IdProduto.ReadOnly = true;
			// 
			// Nome
			// 
			Nome.HeaderText = "Nome";
			Nome.Name = "Nome";
			Nome.ReadOnly = true;
			// 
			// Id
			// 
			Id.HeaderText = "Id";
			Id.Name = "Id";
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
			dataGridViewTextBoxColumn1.HeaderText = "Nome";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Id";
			dataGridViewTextBoxColumn2.HeaderText = "Id";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// FormAddNotaEntrada
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 659);
			Controls.Add(groupBox2);
			Controls.Add(label2);
			Controls.Add(groupBox1);
			Controls.Add(dgvItenNotaEntrada);
			Controls.Add(regNota);
			Controls.Add(label1);
			Name = "FormAddNotaEntrada";
			Text = "FormAddNotaEntrada";
			((System.ComponentModel.ISupportInitialize)dgvItenNotaEntrada).EndInit();
			((System.ComponentModel.ISupportInitialize)itemNotaEntradaBindingSource).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button regNota;
		private Label label1;
		private DataGridView dgvItenNotaEntrada;
		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox txbCNPJ;
		private Label label2;
		private GroupBox groupBox2;
		private DateTimePicker tdpDataEntrada;
		private Label label6;
		private Label label9;
		private Label label7;
		private Label label8;
		private TextBox txbSerie;
		private TextBox txbNumeroNota;
		private TextBox txbValorTotal;
		private DataGridViewTextBoxColumn IdProduto;
		private DataGridViewTextBoxColumn Nome;
		private Button button2;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private BindingSource itemNotaEntradaBindingSource;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}