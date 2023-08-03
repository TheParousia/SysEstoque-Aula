namespace SysVendas
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            groupBox1 = new GroupBox();
            CboUF = new ComboBox();
            TxtEmail = new TextBox();
            label8 = new Label();
            TxtFone = new TextBox();
            label7 = new Label();
            label6 = new Label();
            TxtCidade = new TextBox();
            label5 = new Label();
            TxtBairro = new TextBox();
            label4 = new Label();
            TxtEndereco = new TextBox();
            label3 = new Label();
            TxtNome = new TextBox();
            label2 = new Label();
            TxtIDCliente = new TextBox();
            label1 = new Label();
            BtnSalvar = new Button();
            BtnIncluir = new Button();
            BtnExcluir = new Button();
            BtnAtualizar = new Button();
            DgvCliente = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CboUF);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtFone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtCidade);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtEndereco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtIDCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Cliente";
            // 
            // CboUF
            // 
            CboUF.FormattingEnabled = true;
            CboUF.Location = new Point(60, 138);
            CboUF.Name = "CboUF";
            CboUF.Size = new Size(88, 28);
            CboUF.TabIndex = 5;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(456, 138);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(311, 27);
            TxtEmail.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(395, 141);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 0;
            label8.Text = "E-mail:";
            // 
            // TxtFone
            // 
            TxtFone.Location = new Point(219, 138);
            TxtFone.Name = "TxtFone";
            TxtFone.Size = new Size(145, 27);
            TxtFone.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 141);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 0;
            label7.Text = "Fone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 141);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 0;
            label6.Text = "UF:";
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(851, 86);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(151, 27);
            TxtCidade.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(786, 89);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 0;
            label5.Text = "Cidade:";
            label5.Click += label5_Click;
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(637, 86);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(143, 27);
            TxtBairro.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 89);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Bairro:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(107, 86);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(466, 27);
            TxtEndereco.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 89);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Endereço:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(304, 37);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(698, 27);
            TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 40);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(60, 37);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(157, 27);
            TxtIDCliente.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(610, 456);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(94, 29);
            BtnSalvar.TabIndex = 8;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnIncluir
            // 
            BtnIncluir.Location = new Point(720, 456);
            BtnIncluir.Name = "BtnIncluir";
            BtnIncluir.Size = new Size(94, 29);
            BtnIncluir.TabIndex = 9;
            BtnIncluir.Text = "Incluir";
            BtnIncluir.UseVisualStyleBackColor = true;
            BtnIncluir.Click += BtnIncluir_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(820, 456);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(94, 29);
            BtnExcluir.TabIndex = 10;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Location = new Point(920, 456);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(94, 29);
            BtnAtualizar.TabIndex = 11;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // DgvCliente
            // 
            DgvCliente.AllowUserToResizeColumns = false;
            DgvCliente.AllowUserToResizeRows = false;
            DgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCliente.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvCliente.Location = new Point(12, 249);
            DgvCliente.MultiSelect = false;
            DgvCliente.Name = "DgvCliente";
            DgvCliente.RowHeadersWidth = 51;
            DgvCliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvCliente.RowTemplate.Height = 29;
            DgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCliente.Size = new Size(1008, 170);
            DgvCliente.TabIndex = 5;
            DgvCliente.MouseClick += DgvCliente_MouseClick;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 497);
            Controls.Add(DgvCliente);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnIncluir);
            Controls.Add(BtnSalvar);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCliente";
            Text = "Cadastro de Cliente";
            WindowState = FormWindowState.Maximized;
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtEmail;
        private Label label8;
        private TextBox TxtFone;
        private Label label7;
        private Label label6;
        private TextBox TxtCidade;
        private Label label5;
        private TextBox TxtBairro;
        private Label label4;
        private TextBox TxtEndereco;
        private Label label3;
        private TextBox TxtNome;
        private Label label2;
        private TextBox TxtIDCliente;
        private Label label1;
        private Button BtnSalvar;
        private Button BtnIncluir;
        private Button BtnExcluir;
        private Button BtnAtualizar;
        private DataGridView DgvCliente;
        private ComboBox CboUF;
    }
}