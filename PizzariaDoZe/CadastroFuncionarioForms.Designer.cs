﻿namespace PizzariaDoZe
{
    partial class CadastroFuncionarioForms
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
            enderecoUserControlForm1 = new EnderecoUserControlForm();
            label2 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            textBox1 = new TextBox();
            dateTimeValidadeCarteira = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txtCarteiraMotorista = new TextBox();
            radioBtnGrupoEntregador = new RadioButton();
            radioBtnGrupoAtendente = new RadioButton();
            radioBtnGrupoAdministrador = new RadioButton();
            maskedTxtVerificarSenha = new MaskedTextBox();
            label7 = new Label();
            maskedTxtSenha = new MaskedTextBox();
            label6 = new Label();
            label4 = new Label();
            txtMatricula = new TextBox();
            maskedTxtCPF = new MaskedTextBox();
            label5 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            label12 = new Label();
            txtEmail = new TextBox();
            maskedTxtTelefone = new MaskedTextBox();
            label13 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // enderecoUserControlForm1
            // 
            enderecoUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            enderecoUserControlForm1.Location = new Point(364, 100);
            enderecoUserControlForm1.Margin = new Padding(1, 1, 1, 1);
            enderecoUserControlForm1.Name = "enderecoUserControlForm1";
            enderecoUserControlForm1.Size = new Size(255, 452);
            enderecoUserControlForm1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(82, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(380, 45);
            label2.TabIndex = 7;
            label2.Text = "Cadastro de Funcionarios";
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dateTimeValidadeCarteira);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCarteiraMotorista);
            panel1.Controls.Add(radioBtnGrupoEntregador);
            panel1.Controls.Add(radioBtnGrupoAtendente);
            panel1.Controls.Add(radioBtnGrupoAdministrador);
            panel1.Controls.Add(maskedTxtVerificarSenha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(maskedTxtSenha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMatricula);
            panel1.Controls.Add(maskedTxtCPF);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(maskedTxtTelefone);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(22, 100);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 682);
            panel1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.GhostWhite;
            label10.Location = new Point(27, 412);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 21);
            label10.TabIndex = 62;
            label10.Text = "Observação";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(39, 39, 41);
            textBox1.Location = new Point(24, 434);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 129);
            textBox1.TabIndex = 63;
            // 
            // dateTimeValidadeCarteira
            // 
            dateTimeValidadeCarteira.Location = new Point(24, 378);
            dateTimeValidadeCarteira.Margin = new Padding(2, 2, 2, 2);
            dateTimeValidadeCarteira.Name = "dateTimeValidadeCarteira";
            dateTimeValidadeCarteira.Size = new Size(219, 23);
            dateTimeValidadeCarteira.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.GhostWhite;
            label9.Location = new Point(27, 357);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 60;
            label9.Text = "Validade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.GhostWhite;
            label8.Location = new Point(27, 304);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 21);
            label8.TabIndex = 58;
            label8.Text = "Carteira de Motorista";
            // 
            // txtCarteiraMotorista
            // 
            txtCarteiraMotorista.ForeColor = Color.FromArgb(39, 39, 41);
            txtCarteiraMotorista.Location = new Point(24, 326);
            txtCarteiraMotorista.Margin = new Padding(3, 2, 3, 2);
            txtCarteiraMotorista.Name = "txtCarteiraMotorista";
            txtCarteiraMotorista.Size = new Size(219, 23);
            txtCarteiraMotorista.TabIndex = 59;
            // 
            // radioBtnGrupoEntregador
            // 
            radioBtnGrupoEntregador.AutoSize = true;
            radioBtnGrupoEntregador.ForeColor = Color.GhostWhite;
            radioBtnGrupoEntregador.Location = new Point(200, 280);
            radioBtnGrupoEntregador.Margin = new Padding(2, 2, 2, 2);
            radioBtnGrupoEntregador.Name = "radioBtnGrupoEntregador";
            radioBtnGrupoEntregador.Size = new Size(83, 19);
            radioBtnGrupoEntregador.TabIndex = 57;
            radioBtnGrupoEntregador.TabStop = true;
            radioBtnGrupoEntregador.Text = "Entregador";
            radioBtnGrupoEntregador.UseVisualStyleBackColor = true;
            // 
            // radioBtnGrupoAtendente
            // 
            radioBtnGrupoAtendente.AutoSize = true;
            radioBtnGrupoAtendente.ForeColor = Color.GhostWhite;
            radioBtnGrupoAtendente.Location = new Point(112, 280);
            radioBtnGrupoAtendente.Margin = new Padding(2, 2, 2, 2);
            radioBtnGrupoAtendente.Name = "radioBtnGrupoAtendente";
            radioBtnGrupoAtendente.Size = new Size(80, 19);
            radioBtnGrupoAtendente.TabIndex = 56;
            radioBtnGrupoAtendente.TabStop = true;
            radioBtnGrupoAtendente.Text = "Atendente";
            radioBtnGrupoAtendente.UseVisualStyleBackColor = true;
            // 
            // radioBtnGrupoAdministrador
            // 
            radioBtnGrupoAdministrador.AutoSize = true;
            radioBtnGrupoAdministrador.ForeColor = Color.GhostWhite;
            radioBtnGrupoAdministrador.Location = new Point(2, 280);
            radioBtnGrupoAdministrador.Margin = new Padding(2, 2, 2, 2);
            radioBtnGrupoAdministrador.Name = "radioBtnGrupoAdministrador";
            radioBtnGrupoAdministrador.Size = new Size(101, 19);
            radioBtnGrupoAdministrador.TabIndex = 55;
            radioBtnGrupoAdministrador.TabStop = true;
            radioBtnGrupoAdministrador.Text = "Administrador";
            radioBtnGrupoAdministrador.UseVisualStyleBackColor = true;
            // 
            // maskedTxtVerificarSenha
            // 
            maskedTxtVerificarSenha.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtVerificarSenha.Location = new Point(24, 238);
            maskedTxtVerificarSenha.Margin = new Padding(2, 2, 2, 2);
            maskedTxtVerificarSenha.Name = "maskedTxtVerificarSenha";
            maskedTxtVerificarSenha.PasswordChar = '*';
            maskedTxtVerificarSenha.Size = new Size(219, 23);
            maskedTxtVerificarSenha.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.GhostWhite;
            label7.Location = new Point(24, 217);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 54;
            label7.Text = "Verificar Senha";
            // 
            // maskedTxtSenha
            // 
            maskedTxtSenha.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtSenha.Location = new Point(24, 188);
            maskedTxtSenha.Margin = new Padding(2, 2, 2, 2);
            maskedTxtSenha.Name = "maskedTxtSenha";
            maskedTxtSenha.PasswordChar = '*';
            maskedTxtSenha.Size = new Size(219, 23);
            maskedTxtSenha.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(24, 167);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 52;
            label6.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(27, 117);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 49;
            label4.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.ForeColor = Color.FromArgb(39, 39, 41);
            txtMatricula.Location = new Point(24, 139);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(219, 23);
            txtMatricula.TabIndex = 50;
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtCPF.Location = new Point(90, 38);
            maskedTxtCPF.Margin = new Padding(2, 2, 2, 2);
            maskedTxtCPF.Name = "maskedTxtCPF";
            maskedTxtCPF.Size = new Size(152, 23);
            maskedTxtCPF.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(90, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 48;
            label5.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(24, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 47;
            label3.Text = "Id";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.ForeColor = Color.FromArgb(39, 39, 41);
            txtID.Location = new Point(25, 38);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(27, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 45;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.ForeColor = Color.FromArgb(39, 39, 41);
            txtNome.Location = new Point(24, 89);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.GhostWhite;
            label12.Location = new Point(24, 578);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 21);
            label12.TabIndex = 23;
            label12.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(39, 39, 41);
            txtEmail.Location = new Point(24, 650);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 24;
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtTelefone.Location = new Point(24, 599);
            maskedTxtTelefone.Margin = new Padding(2, 2, 2, 2);
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(219, 23);
            maskedTxtTelefone.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.GhostWhite;
            label13.Location = new Point(24, 629);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 21);
            label13.TabIndex = 24;
            label13.Text = "E-Mail";
            // 
            // CadastroFuncionarioForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(627, 789);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(enderecoUserControlForm1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CadastroFuncionarioForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroFuncionarioForms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private EnderecoUserControlForm enderecoUserControlForm1;
        private Label label2;
        private Panel panel1;
        private MaskedTextBox maskedTxtCPF;
        private Label label5;
        private Label label3;
        private TextBox txtID;
        private Label label1;
        private TextBox txtNome;
        private Label label12;
        private TextBox txtEmail;
        private MaskedTextBox maskedTxtTelefone;
        private Label label13;
        private MaskedTextBox maskedTxtVerificarSenha;
        private Label label7;
        private MaskedTextBox maskedTxtSenha;
        private Label label6;
        private Label label4;
        private TextBox txtMatricula;
        private Label label8;
        private TextBox txtCarteiraMotorista;
        private RadioButton radioBtnGrupoEntregador;
        private RadioButton radioBtnGrupoAtendente;
        private RadioButton radioBtnGrupoAdministrador;
        private Label label10;
        private TextBox textBox1;
        private DateTimePicker dateTimeValidadeCarteira;
        private Label label9;
    }
}