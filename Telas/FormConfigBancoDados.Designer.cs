namespace SysEstoque.Telas {
	partial class FormConfigBancoDados {
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
			txbServidor = new TextBox();
			btnSalvarConfig = new Button();
			label2 = new Label();
			txbDatabase = new TextBox();
			label3 = new Label();
			txbPort = new TextBox();
			label4 = new Label();
			txbUID = new TextBox();
			label5 = new Label();
			txbSenha = new TextBox();
			btnViewPwd = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(33, 53);
			label1.Name = "label1";
			label1.Size = new Size(122, 15);
			label1.TabIndex = 0;
			label1.Text = "Servidor(IP/Domínio):";
			// 
			// txbServidor
			// 
			txbServidor.Location = new Point(161, 50);
			txbServidor.Name = "txbServidor";
			txbServidor.Size = new Size(176, 23);
			txbServidor.TabIndex = 1;
			txbServidor.Text = "127.0.0.1";
			// 
			// btnSalvarConfig
			// 
			btnSalvarConfig.DialogResult = DialogResult.OK;
			btnSalvarConfig.Location = new Point(465, 264);
			btnSalvarConfig.Name = "btnSalvarConfig";
			btnSalvarConfig.Size = new Size(90, 46);
			btnSalvarConfig.TabIndex = 2;
			btnSalvarConfig.Text = "💾 Salvar Configuração";
			btnSalvarConfig.UseVisualStyleBackColor = true;
			btnSalvarConfig.Click += btnSalvarConfig_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 98);
			label2.Name = "label2";
			label2.Size = new Size(148, 15);
			label2.TabIndex = 0;
			label2.Text = "Nome do Banco de Dados:";
			// 
			// txbDatabase
			// 
			txbDatabase.Location = new Point(187, 95);
			txbDatabase.Name = "txbDatabase";
			txbDatabase.Size = new Size(176, 23);
			txbDatabase.TabIndex = 1;
			txbDatabase.Text = "estoque_test1";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(365, 53);
			label3.Name = "label3";
			label3.Size = new Size(83, 15);
			label3.TabIndex = 0;
			label3.Text = "Porta de Rede:";
			// 
			// txbPort
			// 
			txbPort.Location = new Point(454, 50);
			txbPort.Name = "txbPort";
			txbPort.Size = new Size(101, 23);
			txbPort.TabIndex = 1;
			txbPort.Text = "3306";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(33, 150);
			label4.Name = "label4";
			label4.Size = new Size(50, 15);
			label4.TabIndex = 0;
			label4.Text = "Usuário:";
			// 
			// txbUID
			// 
			txbUID.Location = new Point(98, 147);
			txbUID.Name = "txbUID";
			txbUID.Size = new Size(176, 23);
			txbUID.TabIndex = 1;
			txbUID.Text = "root";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(33, 191);
			label5.Name = "label5";
			label5.Size = new Size(42, 15);
			label5.TabIndex = 0;
			label5.Text = "Senha:";
			// 
			// txbSenha
			// 
			txbSenha.Location = new Point(98, 188);
			txbSenha.Name = "txbSenha";
			txbSenha.Size = new Size(176, 23);
			txbSenha.TabIndex = 1;
			txbSenha.Text = "#Root2022";
			// 
			// btnViewPwd
			// 
			btnViewPwd.Location = new Point(288, 188);
			btnViewPwd.Name = "btnViewPwd";
			btnViewPwd.Size = new Size(36, 23);
			btnViewPwd.TabIndex = 2;
			btnViewPwd.Text = "👁️";
			btnViewPwd.UseVisualStyleBackColor = true;
			btnViewPwd.Click += btnViewPwd_Click;
			// 
			// FormConfigBancoDados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(595, 323);
			Controls.Add(btnViewPwd);
			Controls.Add(btnSalvarConfig);
			Controls.Add(txbPort);
			Controls.Add(label3);
			Controls.Add(txbSenha);
			Controls.Add(label5);
			Controls.Add(txbUID);
			Controls.Add(label4);
			Controls.Add(txbDatabase);
			Controls.Add(label2);
			Controls.Add(txbServidor);
			Controls.Add(label1);
			Name = "FormConfigBancoDados";
			Text = "FormConfigBancoDados";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txbServidor;
		private Button btnSalvarConfig;
		private Label label2;
		private TextBox txbDatabase;
		private Label label3;
		private TextBox txbPort;
		private Label label4;
		private TextBox txbUID;
		private Label label5;
		private TextBox txbSenha;
		private Button btnViewPwd;
	}
}