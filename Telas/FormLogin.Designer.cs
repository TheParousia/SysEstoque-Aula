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
            notifyIcon1 = new NotifyIcon(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusMsgDBConnected = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(655, 413);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(94, 29);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 280);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Senha";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(603, 317);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(198, 27);
            txbSenha.TabIndex = 2;
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(603, 223);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(198, 27);
            txbLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 185);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusMsgDBConnected });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(121, 20);
            toolStripStatusLabel1.Text = "Banco de Dados:";
            // 
            // statusMsgDBConnected
            // 
            statusMsgDBConnected.AutoSize = false;
            statusMsgDBConnected.Name = "statusMsgDBConnected";
            statusMsgDBConnected.Size = new Size(300, 20);
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(statusStrip1);
            Controls.Add(txbLogin);
            Controls.Add(txbSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label label1;
        private TextBox txbSenha;
        private TextBox txbLogin;
        private Label label2;
        private NotifyIcon notifyIcon1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusMsgDBConnected;
    }
}