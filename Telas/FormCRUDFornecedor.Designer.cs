namespace SysEstoque {
	partial class FormCRUDFornecedor {
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
			btnConsultarCNPJ = new Button();
			label1 = new Label();
			label0 = new Label();
			txbNomeFantazia = new TextBox();
			label3 = new Label();
			txbRazaoSocial = new TextBox();
			label4 = new Label();
			txbCnaePrincipal = new TextBox();
			label5 = new Label();
			txbEmail = new TextBox();
			groupBox1 = new GroupBox();
			txbCEP = new MaskedTextBox();
			statusConsultaCEP = new Label();
			label6 = new Label();
			label8 = new Label();
			label9 = new Label();
			label7 = new Label();
			txbBairro = new TextBox();
			txbNumero = new TextBox();
			txbRua = new TextBox();
			btnConsultaCEP = new Button();
			label2 = new Label();
			txbTelefone = new TextBox();
			label10 = new Label();
			lblStatusConsultaCNPJ = new Label();
			txbCNPJ = new MaskedTextBox();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			statusMsg = new ToolStripStatusLabel();
			btnRegistrar = new Button();
			groupBox1.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnConsultarCNPJ
			// 
			btnConsultarCNPJ.Location = new Point(222, 51);
			btnConsultarCNPJ.Name = "btnConsultarCNPJ";
			btnConsultarCNPJ.Size = new Size(75, 23);
			btnConsultarCNPJ.TabIndex = 0;
			btnConsultarCNPJ.Text = "Consultar";
			btnConsultarCNPJ.UseVisualStyleBackColor = true;
			btnConsultarCNPJ.Click += btnConsultarCNPJ_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 55);
			label1.Name = "label1";
			label1.Size = new Size(37, 15);
			label1.TabIndex = 1;
			label1.Text = "CNPJ:";
			// 
			// label0
			// 
			label0.AutoSize = true;
			label0.Location = new Point(27, 96);
			label0.Name = "label0";
			label0.Size = new Size(89, 15);
			label0.TabIndex = 1;
			label0.Text = "Nome Fantazia:";
			// 
			// txbNomeFantazia
			// 
			txbNomeFantazia.Location = new Point(123, 93);
			txbNomeFantazia.Name = "txbNomeFantazia";
			txbNomeFantazia.Size = new Size(494, 23);
			txbNomeFantazia.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(27, 134);
			label3.Name = "label3";
			label3.Size = new Size(75, 15);
			label3.TabIndex = 1;
			label3.Text = "Razão Social:";
			// 
			// txbRazaoSocial
			// 
			txbRazaoSocial.Location = new Point(123, 131);
			txbRazaoSocial.Name = "txbRazaoSocial";
			txbRazaoSocial.Size = new Size(494, 23);
			txbRazaoSocial.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(27, 180);
			label4.Name = "label4";
			label4.Size = new Size(90, 15);
			label4.TabIndex = 1;
			label4.Text = "CNAE Principal:";
			// 
			// txbCnaePrincipal
			// 
			txbCnaePrincipal.Location = new Point(123, 177);
			txbCnaePrincipal.Name = "txbCnaePrincipal";
			txbCnaePrincipal.Size = new Size(493, 23);
			txbCnaePrincipal.TabIndex = 2;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(27, 221);
			label5.Name = "label5";
			label5.Size = new Size(44, 15);
			label5.TabIndex = 1;
			label5.Text = "E-mail:";
			// 
			// txbEmail
			// 
			txbEmail.Location = new Point(123, 221);
			txbEmail.Name = "txbEmail";
			txbEmail.Size = new Size(204, 23);
			txbEmail.TabIndex = 2;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txbCEP);
			groupBox1.Controls.Add(statusConsultaCEP);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(txbBairro);
			groupBox1.Controls.Add(txbNumero);
			groupBox1.Controls.Add(txbRua);
			groupBox1.Controls.Add(btnConsultaCEP);
			groupBox1.Location = new Point(27, 264);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(851, 164);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Endereço";
			// 
			// txbCEP
			// 
			txbCEP.Location = new Point(82, 39);
			txbCEP.Mask = "99999-999";
			txbCEP.Name = "txbCEP";
			txbCEP.Size = new Size(100, 23);
			txbCEP.TabIndex = 3;
			// 
			// statusConsultaCEP
			// 
			statusConsultaCEP.Location = new Point(302, 42);
			statusConsultaCEP.Name = "statusConsultaCEP";
			statusConsultaCEP.Size = new Size(146, 20);
			statusConsultaCEP.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(20, 42);
			label6.Name = "label6";
			label6.Size = new Size(31, 15);
			label6.TabIndex = 1;
			label6.Text = "CEP:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(20, 127);
			label8.Name = "label8";
			label8.Size = new Size(41, 15);
			label8.TabIndex = 1;
			label8.Text = "Bairro:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(455, 91);
			label9.Name = "label9";
			label9.Size = new Size(54, 15);
			label9.TabIndex = 1;
			label9.Text = "Número:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(20, 88);
			label7.Name = "label7";
			label7.Size = new Size(30, 15);
			label7.TabIndex = 1;
			label7.Text = "Rua:";
			// 
			// txbBairro
			// 
			txbBairro.Location = new Point(82, 124);
			txbBairro.Name = "txbBairro";
			txbBairro.Size = new Size(348, 23);
			txbBairro.TabIndex = 2;
			// 
			// txbNumero
			// 
			txbNumero.Location = new Point(517, 88);
			txbNumero.Name = "txbNumero";
			txbNumero.Size = new Size(100, 23);
			txbNumero.TabIndex = 2;
			// 
			// txbRua
			// 
			txbRua.Location = new Point(82, 85);
			txbRua.Name = "txbRua";
			txbRua.Size = new Size(348, 23);
			txbRua.TabIndex = 2;
			// 
			// btnConsultaCEP
			// 
			btnConsultaCEP.Location = new Point(205, 38);
			btnConsultaCEP.Name = "btnConsultaCEP";
			btnConsultaCEP.Size = new Size(75, 23);
			btnConsultaCEP.TabIndex = 0;
			btnConsultaCEP.Text = "Consultar";
			btnConsultaCEP.UseVisualStyleBackColor = true;
			btnConsultaCEP.Click += btnConsultaCEP_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(403, 224);
			label2.Name = "label2";
			label2.Size = new Size(54, 15);
			label2.TabIndex = 1;
			label2.Text = "Telefone:";
			// 
			// txbTelefone
			// 
			txbTelefone.Location = new Point(463, 221);
			txbTelefone.Name = "txbTelefone";
			txbTelefone.Size = new Size(153, 23);
			txbTelefone.TabIndex = 2;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(348, 9);
			label10.Name = "label10";
			label10.Size = new Size(237, 25);
			label10.TabIndex = 1;
			label10.Text = "Cadastrar Novo Fonecedor";
			// 
			// lblStatusConsultaCNPJ
			// 
			lblStatusConsultaCNPJ.Location = new Point(329, 55);
			lblStatusConsultaCNPJ.Name = "lblStatusConsultaCNPJ";
			lblStatusConsultaCNPJ.Size = new Size(207, 19);
			lblStatusConsultaCNPJ.TabIndex = 1;
			// 
			// txbCNPJ
			// 
			txbCNPJ.Location = new Point(70, 51);
			txbCNPJ.Mask = "99\\.999\\.999/9999-99";
			txbCNPJ.Name = "txbCNPJ";
			txbCNPJ.Size = new Size(116, 23);
			txbCNPJ.TabIndex = 4;
			txbCNPJ.TextAlign = HorizontalAlignment.Center;
			txbCNPJ.TextMaskFormat = MaskFormat.IncludePrompt;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusMsg });
			statusStrip1.Location = new Point(0, 463);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(886, 22);
			statusStrip1.TabIndex = 5;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(69, 17);
			toolStripStatusLabel1.Text = "Mensagem:";
			// 
			// statusMsg
			// 
			statusMsg.AutoSize = false;
			statusMsg.Name = "statusMsg";
			statusMsg.Size = new Size(400, 17);
			// 
			// btnRegistrar
			// 
			btnRegistrar.Location = new Point(799, 434);
			btnRegistrar.Name = "btnRegistrar";
			btnRegistrar.Size = new Size(75, 23);
			btnRegistrar.TabIndex = 6;
			btnRegistrar.Text = "Registrar";
			btnRegistrar.UseVisualStyleBackColor = true;
			btnRegistrar.Click += btnRegistrar_Click;
			// 
			// FormCRUDFornecedor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(886, 485);
			Controls.Add(btnRegistrar);
			Controls.Add(statusStrip1);
			Controls.Add(txbCNPJ);
			Controls.Add(groupBox1);
			Controls.Add(txbTelefone);
			Controls.Add(label2);
			Controls.Add(txbEmail);
			Controls.Add(label5);
			Controls.Add(txbCnaePrincipal);
			Controls.Add(label4);
			Controls.Add(txbRazaoSocial);
			Controls.Add(label3);
			Controls.Add(txbNomeFantazia);
			Controls.Add(label0);
			Controls.Add(label10);
			Controls.Add(lblStatusConsultaCNPJ);
			Controls.Add(label1);
			Controls.Add(btnConsultarCNPJ);
			Name = "FormCRUDFornecedor";
			Text = "FormCRUDFornecedor";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnConsultarCNPJ;
		private Label label1;
		private Label label0;
		private TextBox txbNomeFantazia;
		private Label label3;
		private TextBox txbRazaoSocial;
		private Label label4;
		private TextBox txbCnaePrincipal;
		private Label label5;
		private TextBox txbEmail;
		private GroupBox groupBox1;
		private Label label6;
		private Label label8;
		private Label label9;
		private Label label7;
		private TextBox txbBairro;
		private TextBox txbNumero;
		private TextBox txbRua;
		private Button btnConsultaCEP;
		private Label label2;
		private TextBox txbTelefone;
		private Label label10;
		private Label lblStatusConsultaCNPJ;
		private MaskedTextBox txbCNPJ;
		private MaskedTextBox txbCEP;
		private Label statusConsultaCEP;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel statusMsg;
		private Button btnRegistrar;
	}
}