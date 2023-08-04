namespace SysEstoque.Models {
	partial class FormAddProduto {
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
			button1 = new Button();
			label1 = new Label();
			txbNome = new TextBox();
			cbxCategorias = new ComboBox();
			label2 = new Label();
			txbPreco = new TextBox();
			label3 = new Label();
			label4 = new Label();
			cbxUnidadesMedida = new ComboBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(467, 312);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 59);
			label1.Name = "label1";
			label1.Size = new Size(40, 15);
			label1.TabIndex = 1;
			label1.Text = "Nome";
			// 
			// txbNome
			// 
			txbNome.Location = new Point(53, 92);
			txbNome.Name = "txbNome";
			txbNome.Size = new Size(164, 23);
			txbNome.TabIndex = 2;
			// 
			// cbxCategorias
			// 
			cbxCategorias.FormattingEnabled = true;
			cbxCategorias.Location = new Point(53, 187);
			cbxCategorias.Name = "cbxCategorias";
			cbxCategorias.Size = new Size(138, 23);
			cbxCategorias.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(276, 59);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 1;
			label2.Text = "Preço";
			// 
			// txbPreco
			// 
			txbPreco.Location = new Point(276, 92);
			txbPreco.Name = "txbPreco";
			txbPreco.Size = new Size(129, 23);
			txbPreco.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(53, 158);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 1;
			label3.Text = "Categoria:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(264, 158);
			label4.Name = "label4";
			label4.Size = new Size(37, 15);
			label4.TabIndex = 1;
			label4.Text = "Preço";
			// 
			// cbxUnidadesMedida
			// 
			cbxUnidadesMedida.FormattingEnabled = true;
			cbxUnidadesMedida.Location = new Point(276, 187);
			cbxUnidadesMedida.Name = "cbxUnidadesMedida";
			cbxUnidadesMedida.Size = new Size(129, 23);
			cbxUnidadesMedida.TabIndex = 3;
			// 
			// FormAddProduto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(cbxUnidadesMedida);
			Controls.Add(cbxCategorias);
			Controls.Add(label4);
			Controls.Add(txbPreco);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txbNome);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "FormAddProduto";
			Text = "FormAddProduto";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox txbNome;
		private ComboBox cbxCategorias;
		private Label label2;
		private TextBox txbPreco;
		private Label label3;
		private Label label4;
		private ComboBox cbxUnidadesMedida;
	}
}