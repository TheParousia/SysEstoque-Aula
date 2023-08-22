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
			components = new System.ComponentModel.Container();
			btnLogar = new Button();
			label1 = new Label();
			txbSenha = new TextBox();
			txbLogin = new TextBox();
			label2 = new Label();
			btnPlay = new Button();
			notifyIcon1 = new NotifyIcon(components);
			upDuration = new TrackBar();
			upFrequency = new TrackBar();
			label3 = new Label();
			label4 = new Label();
			cboBeepType = new ComboBox();
			((System.ComponentModel.ISupportInitialize)upDuration).BeginInit();
			((System.ComponentModel.ISupportInitialize)upFrequency).BeginInit();
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
			label1.Size = new Size(39, 15);
			label1.TabIndex = 1;
			label1.Text = "Senha";
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
			label2.Size = new Size(37, 15);
			label2.TabIndex = 1;
			label2.Text = "Login";
			// 
			// btnPlay
			// 
			btnPlay.Location = new Point(74, 224);
			btnPlay.Margin = new Padding(3, 2, 3, 2);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(82, 22);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Tocar";
			btnPlay.UseVisualStyleBackColor = true;
			btnPlay.Click += btnPlay_Click;
			// 
			// notifyIcon1
			// 
			notifyIcon1.Text = "notifyIcon1";
			notifyIcon1.Visible = true;
			// 
			// upDuration
			// 
			upDuration.Location = new Point(74, 157);
			upDuration.Maximum = 1000;
			upDuration.Minimum = 100;
			upDuration.Name = "upDuration";
			upDuration.Size = new Size(104, 45);
			upDuration.TabIndex = 4;
			upDuration.Value = 100;
			// 
			// upFrequency
			// 
			upFrequency.Location = new Point(74, 77);
			upFrequency.Maximum = 1046;
			upFrequency.Minimum = 523;
			upFrequency.Name = "upFrequency";
			upFrequency.Size = new Size(302, 45);
			upFrequency.TabIndex = 4;
			upFrequency.TickFrequency = 523;
			upFrequency.Value = 523;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(74, 40);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 1;
			label3.Text = "Frequencia";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(74, 125);
			label4.Name = "label4";
			label4.Size = new Size(51, 15);
			label4.TabIndex = 1;
			label4.Text = "Duração";
			// 
			// cboBeepType
			// 
			cboBeepType.FormattingEnabled = true;
			cboBeepType.Items.AddRange(new object[] { "Ok", "SimpleBeep", "IconAsterisk", "IconExclamation", "IconQuestion", "IconHand" });
			cboBeepType.Location = new Point(250, 138);
			cboBeepType.Name = "cboBeepType";
			cboBeepType.Size = new Size(152, 23);
			cboBeepType.TabIndex = 5;
			cboBeepType.SelectedValueChanged += cmdMessageBeep_Click;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(cboBeepType);
			Controls.Add(upFrequency);
			Controls.Add(upDuration);
			Controls.Add(txbLogin);
			Controls.Add(label4);
			Controls.Add(txbSenha);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnPlay);
			Controls.Add(label1);
			Controls.Add(btnLogar);
			Name = "FormLogin";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)upDuration).EndInit();
			((System.ComponentModel.ISupportInitialize)upFrequency).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogar;
		private Label label1;
		private TextBox txbSenha;
		private TextBox txbLogin;
		private Label label2;
		private Button btnPlay;
		private NotifyIcon notifyIcon1;
		private TrackBar upDuration;
		private Label label3;
		private Label label4;
		internal TrackBar upFrequency;
		private ComboBox cboBeepType;
	}
}