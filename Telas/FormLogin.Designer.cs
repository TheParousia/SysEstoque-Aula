namespace SysEstoque {
	partial class FormLogin {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnLogar = new Button();
			label1 = new Label();
			txbSenha = new TextBox();
			txbLogin = new TextBox();
			label2 = new Label();
			SuspendLayout();
			// 
			// btnLogar
			// 
			btnLogar.Location = new Point(573, 310);
			btnLogar.Margin = new Padding(3, 2, 3, 2);
			btnLogar.Name = "btnLogar";
			btnLogar.Size = new Size(82, 22);
			btnLogar.TabIndex = 0;
			btnLogar.Text = "Logar";
			btnLogar.UseVisualStyleBackColor = true;
			btnLogar.Click += btnLogar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(507, 210);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// txbSenha
			// 
			txbSenha.Location = new Point(528, 238);
			txbSenha.Margin = new Padding(3, 2, 3, 2);
			txbSenha.Name = "txbSenha";
			txbSenha.Size = new Size(174, 23);
			txbSenha.TabIndex = 2;
			// 
			// txbLogin
			// 
			txbLogin.Location = new Point(528, 167);
			txbLogin.Margin = new Padding(3, 2, 3, 2);
			txbLogin.Name = "txbLogin";
			txbLogin.Size = new Size(174, 23);
			txbLogin.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(507, 139);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 1;
			label2.Text = "label1";
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txbLogin);
			Controls.Add(txbSenha);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnLogar);
			Name = "FormLogin";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogar;
		private Label label1;
		private TextBox txbSenha;
		private TextBox txbLogin;
		private Label label2;
	}
}