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
            enderecoUserControlForm1 = new EnderecoUserControlForm();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.GhostWhite;
            label13.Location = new Point(24, 167);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 21);
            label13.TabIndex = 24;
            label13.Text = "E-Mail";
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtTelefone.Location = new Point(21, 138);
            maskedTxtTelefone.Margin = new Padding(2);
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(219, 23);
            maskedTxtTelefone.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(39, 39, 41);
            txtEmail.Location = new Point(21, 189);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.GhostWhite;
            label12.Location = new Point(24, 117);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 21);
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
            panel1.Location = new Point(8, 155);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 218);
            panel1.TabIndex = 9;
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.ForeColor = Color.FromArgb(39, 39, 41);
            maskedTxtCPF.Location = new Point(90, 38);
            maskedTxtCPF.Margin = new Padding(2);
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
            // txtFuncionarioID
            // 
            txtFuncionarioID.Enabled = false;
            txtFuncionarioID.ForeColor = Color.FromArgb(39, 39, 41);
            txtFuncionarioID.Location = new Point(25, 38);
            txtFuncionarioID.Margin = new Padding(3, 2, 3, 2);
            txtFuncionarioID.Name = "txtFuncionarioID";
            txtFuncionarioID.Size = new Size(61, 23);
            txtFuncionarioID.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(27, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 45;
            label2.Text = "Nome";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(92, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(313, 45);
            label4.TabIndex = 10;
            label4.Text = "Cadastro de Clientes";
            // 
            // enderecoUserControlForm1
            // 
            enderecoUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            enderecoUserControlForm1.Location = new Point(271, 46);
            enderecoUserControlForm1.Margin = new Padding(1);
            enderecoUserControlForm1.Name = "enderecoUserControlForm1";
            enderecoUserControlForm1.Size = new Size(250, 442);
            enderecoUserControlForm1.TabIndex = 33;
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(295, 492);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(227, 43);
            saveCloseUserControlForm1.TabIndex = 34;
            // 
            // CadastroClienteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(523, 535);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(enderecoUserControlForm1);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
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
        private EnderecoUserControlForm enderecoUserControlForm1;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}