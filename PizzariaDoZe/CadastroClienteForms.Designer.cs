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
            labelEmail = new Label();
            maskedTxtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            labelTelefone = new Label();
            panel1 = new Panel();
            maskedTxtCPF = new MaskedTextBox();
            labelCPF = new Label();
            labelId = new Label();
            txtFuncionarioID = new TextBox();
            labelNome = new Label();
            txtNome = new TextBox();
            labelCadastroCliente = new Label();
            enderecoUserControlForm1 = new EnderecoUserControlForm();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.GhostWhite;
            labelEmail.Location = new Point(27, 223);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(68, 28);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "E-Mail";
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtTelefone.Location = new Point(24, 184);
            maskedTxtTelefone.Margin = new Padding(2, 3, 2, 3);
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(250, 27);
            maskedTxtTelefone.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(39, 39, 41);
            txtEmail.Location = new Point(24, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 24;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.ForeColor = Color.GhostWhite;
            labelTelefone.Location = new Point(27, 156);
            labelTelefone.Margin = new Padding(2, 0, 2, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(84, 28);
            labelTelefone.TabIndex = 23;
            labelTelefone.Text = "Telefone";
            // 
            // panel1
            // 
            panel1.Controls.Add(maskedTxtCPF);
            panel1.Controls.Add(labelCPF);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(txtFuncionarioID);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(labelTelefone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(maskedTxtTelefone);
            panel1.Controls.Add(labelEmail);
            panel1.Location = new Point(9, 207);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 291);
            panel1.TabIndex = 9;
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtCPF.Location = new Point(103, 51);
            maskedTxtCPF.Margin = new Padding(2, 3, 2, 3);
            maskedTxtCPF.Name = "maskedTxtCPF";
            maskedTxtCPF.Size = new Size(173, 27);
            maskedTxtCPF.TabIndex = 44;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPF.ForeColor = Color.GhostWhite;
            labelCPF.Location = new Point(103, 23);
            labelCPF.Margin = new Padding(2, 0, 2, 0);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(45, 28);
            labelCPF.TabIndex = 48;
            labelCPF.Text = "CPF";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(27, 23);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 28);
            labelId.TabIndex = 47;
            labelId.Text = "Id";
            // 
            // txtFuncionarioID
            // 
            txtFuncionarioID.Enabled = false;
            txtFuncionarioID.ForeColor = Color.FromArgb(39, 39, 41);
            txtFuncionarioID.Location = new Point(29, 51);
            txtFuncionarioID.Name = "txtFuncionarioID";
            txtFuncionarioID.Size = new Size(69, 27);
            txtFuncionarioID.TabIndex = 43;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(31, 91);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(66, 28);
            labelNome.TabIndex = 45;
            labelNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.ForeColor = Color.FromArgb(39, 39, 41);
            txtNome.Location = new Point(27, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 27);
            txtNome.TabIndex = 46;
            // 
            // labelCadastroCliente
            // 
            labelCadastroCliente.AutoSize = true;
            labelCadastroCliente.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastroCliente.ForeColor = Color.GhostWhite;
            labelCadastroCliente.Location = new Point(105, 7);
            labelCadastroCliente.Margin = new Padding(2, 0, 2, 0);
            labelCadastroCliente.Name = "labelCadastroCliente";
            labelCadastroCliente.Size = new Size(388, 54);
            labelCadastroCliente.TabIndex = 10;
            labelCadastroCliente.Text = "Cadastro de Clientes";
            // 
            // enderecoUserControlForm1
            // 
            enderecoUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            enderecoUserControlForm1.Location = new Point(310, 61);
            enderecoUserControlForm1.Margin = new Padding(1);
            enderecoUserControlForm1.Name = "enderecoUserControlForm1";
            enderecoUserControlForm1.Size = new Size(286, 589);
            enderecoUserControlForm1.TabIndex = 33;
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(337, 656);
            saveCloseUserControlForm1.Margin = new Padding(3, 5, 3, 5);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(259, 57);
            saveCloseUserControlForm1.TabIndex = 34;
            // 
            // CadastroClienteForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(598, 713);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(enderecoUserControlForm1);
            Controls.Add(labelCadastroCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "CadastroClienteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroClienteForms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelEmail;
        private MaskedTextBox maskedTxtTelefone;
        private TextBox txtEmail;
        private Label labelTelefone;
        private Panel panel1;
        private MaskedTextBox maskedTxtCPF;
        private Label labelCPF;
        private Label labelId;
        private TextBox txtFuncionarioID;
        private Label labelNome;
        private TextBox txtNome;
        private Label labelCadastroCliente;
        private EnderecoUserControlForm enderecoUserControlForm1;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}