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
            textBoxEmail = new TextBox();
            labelTelefone = new Label();
            panel1 = new Panel();
            maskedTxtCPF = new MaskedTextBox();
            labelCPF = new Label();
            labelId = new Label();
            txtFuncionarioID = new TextBox();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCadastrarCliente = new Label();
            userControlEndereco = new EnderecoUserControlForm();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.GhostWhite;
            labelEmail.Location = new Point(34, 279);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(82, 32);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "E-Mail";
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtTelefone.Location = new Point(30, 230);
            maskedTxtTelefone.Margin = new Padding(2, 4, 2, 4);
            maskedTxtTelefone.Mask = "\\(00\\) 90000\\-0000";
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(312, 31);
            maskedTxtTelefone.TabIndex = 23;
            maskedTxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxEmail
            // 
            textBoxEmail.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxEmail.Location = new Point(30, 315);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(312, 31);
            textBoxEmail.TabIndex = 24;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.ForeColor = Color.GhostWhite;
            labelTelefone.Location = new Point(34, 195);
            labelTelefone.Margin = new Padding(2, 0, 2, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(106, 32);
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
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(labelTelefone);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(maskedTxtTelefone);
            panel1.Controls.Add(labelEmail);
            panel1.Location = new Point(11, 259);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 364);
            panel1.TabIndex = 9;
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtCPF.Location = new Point(129, 64);
            maskedTxtCPF.Margin = new Padding(2, 4, 2, 4);
            maskedTxtCPF.Mask = "000\\.000\\.000\\-00";
            maskedTxtCPF.Name = "maskedTxtCPF";
            maskedTxtCPF.Size = new Size(215, 31);
            maskedTxtCPF.TabIndex = 44;
            maskedTxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCPF.ForeColor = Color.GhostWhite;
            labelCPF.Location = new Point(129, 29);
            labelCPF.Margin = new Padding(2, 0, 2, 0);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(54, 32);
            labelCPF.TabIndex = 48;
            labelCPF.Text = "CPF";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(34, 29);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 32);
            labelId.TabIndex = 47;
            labelId.Text = "Id";
            // 
            // txtFuncionarioID
            // 
            txtFuncionarioID.Enabled = false;
            txtFuncionarioID.ForeColor = Color.FromArgb(39, 39, 41);
            txtFuncionarioID.Location = new Point(36, 64);
            txtFuncionarioID.Margin = new Padding(4);
            txtFuncionarioID.Name = "txtFuncionarioID";
            txtFuncionarioID.Size = new Size(85, 31);
            txtFuncionarioID.TabIndex = 43;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(39, 114);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(80, 32);
            labelNome.TabIndex = 45;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxNome.Location = new Point(30, 150);
            textBoxNome.Margin = new Padding(4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(312, 31);
            textBoxNome.TabIndex = 46;
            // 
            // labelCadastrarCliente
            // 
            labelCadastrarCliente.AutoSize = true;
            labelCadastrarCliente.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarCliente.ForeColor = Color.GhostWhite;
            labelCadastrarCliente.Location = new Point(131, 9);
            labelCadastrarCliente.Margin = new Padding(2, 0, 2, 0);
            labelCadastrarCliente.Name = "labelCadastrarCliente";
            labelCadastrarCliente.Size = new Size(461, 65);
            labelCadastrarCliente.TabIndex = 10;
            labelCadastrarCliente.Text = "Cadastro de Clientes";
            // 
            // userControlEndereco
            // 
            userControlEndereco.BackColor = Color.FromArgb(39, 39, 41);
            userControlEndereco.Location = new Point(388, 76);
            userControlEndereco.Margin = new Padding(1);
            userControlEndereco.Name = "userControlEndereco";
            userControlEndereco.Size = new Size(358, 800);
            userControlEndereco.TabIndex = 33;
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(422, 906);
            saveCloseUserControlForm1.Margin = new Padding(4, 6, 4, 6);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(324, 71);
            saveCloseUserControlForm1.TabIndex = 34;
            // 
            // CadastroClienteForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(753, 984);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(userControlEndereco);
            Controls.Add(labelCadastrarCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 4, 2, 4);
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
        private TextBox textBoxEmail;
        private Label labelTelefone;
        private Panel panel1;
        private MaskedTextBox maskedTxtCPF;
        private Label labelCPF;
        private Label labelId;
        private TextBox txtFuncionarioID;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCadastrarCliente;
        private EnderecoUserControlForm userControlEndereco;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}