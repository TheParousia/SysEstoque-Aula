﻿namespace SysEstoque
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogar = new Button();
            label1 = new Label();
            txbSenha = new TextBox();
            tbxLogin = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(655, 414);
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
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(604, 317);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(198, 27);
            txbSenha.TabIndex = 2;
            // 
            // tbxLogin
            // 
            tbxLogin.Location = new Point(604, 223);
            tbxLogin.Name = "tbxLogin";
            tbxLogin.Size = new Size(198, 27);
            tbxLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 185);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tbxLogin);
            Controls.Add(txbSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox tbxLogin;
        private Label label2;
    }
}