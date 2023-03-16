namespace PizzariaDoZe
{
    partial class CadastroClienteForms
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
            label13 = new Label();
            maskedTxtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            label12 = new Label();
            panel1 = new Panel();
            maskedTxtCPF = new MaskedTextBox();
            label5 = new Label();
            label3 = new Label();
            txtFuncionarioID = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            btnSalvarCliente = new Button();
            enderecoUserControlForm1 = new EnderecoUserControlForm();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.GhostWhite;
            label13.Location = new Point(34, 279);
            label13.Name = "label13";
            label13.Size = new Size(82, 32);
            label13.TabIndex = 24;
            label13.Text = "E-Mail";
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtTelefone.Location = new Point(30, 230);
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(311, 31);
            maskedTxtTelefone.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(39, 39, 41);
            txtEmail.Location = new Point(30, 315);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 31);
            txtEmail.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.GhostWhite;
            label12.Location = new Point(34, 195);
            label12.Name = "label12";
            label12.Size = new Size(106, 32);
            label12.TabIndex = 23;
            label12.Text = "Telefone";
            // 
            // panel1
            // 
            panel1.Controls.Add(maskedTxtCPF);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtFuncionarioID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(maskedTxtTelefone);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(12, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 363);
            panel1.TabIndex = 9;
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtCPF.Location = new Point(129, 64);
            maskedTxtCPF.Name = "maskedTxtCPF";
            maskedTxtCPF.Size = new Size(216, 31);
            maskedTxtCPF.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(129, 29);
            label5.Name = "label5";
            label5.Size = new Size(54, 32);
            label5.TabIndex = 48;
            label5.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(34, 28);
            label3.Name = "label3";
            label3.Size = new Size(34, 32);
            label3.TabIndex = 47;
            label3.Text = "Id";
            // 
            // txtFuncionarioID
            // 
            txtFuncionarioID.Enabled = false;
            txtFuncionarioID.ForeColor = Color.FromArgb(39, 39, 41);
            txtFuncionarioID.Location = new Point(36, 64);
            txtFuncionarioID.Margin = new Padding(4);
            txtFuncionarioID.Name = "txtFuncionarioID";
            txtFuncionarioID.Size = new Size(86, 31);
            txtFuncionarioID.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(38, 113);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 45;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.ForeColor = Color.FromArgb(39, 39, 41);
            txtNome.Location = new Point(34, 149);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 31);
            txtNome.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(132, 9);
            label4.Name = "label4";
            label4.Size = new Size(461, 65);
            label4.TabIndex = 10;
            label4.Text = "Cadastro de Clientes";
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.BackColor = Color.FromArgb(114, 138, 244);
            btnSalvarCliente.ForeColor = Color.FromArgb(39, 39, 41);
            btnSalvarCliente.Location = new Point(582, 838);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(146, 41);
            btnSalvarCliente.TabIndex = 32;
            btnSalvarCliente.Text = "Salvar";
            btnSalvarCliente.UseVisualStyleBackColor = false;
            // 
            // enderecoUserControlForm1
            // 
            enderecoUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            enderecoUserControlForm1.Location = new Point(387, 77);
            enderecoUserControlForm1.Name = "enderecoUserControlForm1";
            enderecoUserControlForm1.Size = new Size(357, 737);
            enderecoUserControlForm1.TabIndex = 33;
            // 
            // CadastroClienteForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(747, 891);
            Controls.Add(enderecoUserControlForm1);
            Controls.Add(btnSalvarCliente);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "CadastroClienteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroClienteForms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private MaskedTextBox maskedTxtTelefone;
        private TextBox txtEmail;
        private Label label12;
        private Panel panel1;
        private MaskedTextBox maskedTxtCPF;
        private Label label5;
        private Label label3;
        private TextBox txtFuncionarioID;
        private Label label2;
        private TextBox txtNome;
        private Label label4;
        private Button btnSalvarCliente;
        private EnderecoUserControlForm enderecoUserControlForm1;
    }
}