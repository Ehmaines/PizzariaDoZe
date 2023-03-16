namespace PizzariaDoZe
{
    partial class PaginaPrincipalForm
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
            btnCadastroCliente = new Button();
            btnCadastroIngredientes = new Button();
            btnCadastroSabores = new Button();
            panelBotoesCadastros = new Panel();
            btnCadastroFuncionario = new Button();
            label2 = new Label();
            panelPaginaPrincipal = new Panel();
            label1 = new Label();
            label3 = new Label();
            panelTitulo = new Panel();
            panelPagina = new Panel();
            pageSetupDialog1 = new PageSetupDialog();
            panelBotoesCadastros.SuspendLayout();
            panelPaginaPrincipal.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelPagina.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Anchor = AnchorStyles.Top;
            btnCadastroCliente.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroCliente.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroCliente.Location = new Point(386, 51);
            btnCadastroCliente.Margin = new Padding(3, 2, 3, 2);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(175, 32);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastro Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnCadastroIngredientes
            // 
            btnCadastroIngredientes.Anchor = AnchorStyles.Top;
            btnCadastroIngredientes.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroIngredientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroIngredientes.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroIngredientes.Location = new Point(653, 51);
            btnCadastroIngredientes.Margin = new Padding(3, 2, 3, 2);
            btnCadastroIngredientes.Name = "btnCadastroIngredientes";
            btnCadastroIngredientes.Size = new Size(175, 32);
            btnCadastroIngredientes.TabIndex = 2;
            btnCadastroIngredientes.Text = "Cadastro Ingredientes";
            btnCadastroIngredientes.UseVisualStyleBackColor = false;
            btnCadastroIngredientes.Click += btnCadastroIngredientes_Click;
            // 
            // btnCadastroSabores
            // 
            btnCadastroSabores.Anchor = AnchorStyles.Top;
            btnCadastroSabores.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroSabores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroSabores.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroSabores.Location = new Point(932, 51);
            btnCadastroSabores.Margin = new Padding(3, 2, 3, 2);
            btnCadastroSabores.Name = "btnCadastroSabores";
            btnCadastroSabores.Size = new Size(175, 32);
            btnCadastroSabores.TabIndex = 3;
            btnCadastroSabores.Text = "Cadastro Sabores";
            btnCadastroSabores.UseVisualStyleBackColor = false;
            btnCadastroSabores.Click += btnCadastroSabores_Click;
            // 
            // panelBotoesCadastros
            // 
            panelBotoesCadastros.Controls.Add(btnCadastroFuncionario);
            panelBotoesCadastros.Controls.Add(label2);
            panelBotoesCadastros.Controls.Add(btnCadastroSabores);
            panelBotoesCadastros.Controls.Add(btnCadastroCliente);
            panelBotoesCadastros.Controls.Add(btnCadastroIngredientes);
            panelBotoesCadastros.Dock = DockStyle.Top;
            panelBotoesCadastros.Location = new Point(0, 0);
            panelBotoesCadastros.Margin = new Padding(3, 2, 3, 2);
            panelBotoesCadastros.Name = "panelBotoesCadastros";
            panelBotoesCadastros.Size = new Size(1334, 88);
            panelBotoesCadastros.TabIndex = 4;
            // 
            // btnCadastroFuncionario
            // 
            btnCadastroFuncionario.Anchor = AnchorStyles.Top;
            btnCadastroFuncionario.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroFuncionario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroFuncionario.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroFuncionario.Location = new Point(130, 51);
            btnCadastroFuncionario.Margin = new Padding(3, 2, 3, 2);
            btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            btnCadastroFuncionario.Size = new Size(175, 32);
            btnCadastroFuncionario.TabIndex = 7;
            btnCadastroFuncionario.Text = "Cadastro Funcionário";
            btnCadastroFuncionario.UseVisualStyleBackColor = false;
            btnCadastroFuncionario.Click += btnCadastroFuncionario_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(579, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 6;
            label2.Text = "Cadastros";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelPaginaPrincipal
            // 
            panelPaginaPrincipal.Controls.Add(label1);
            panelPaginaPrincipal.Dock = DockStyle.Top;
            panelPaginaPrincipal.Location = new Point(0, 88);
            panelPaginaPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPaginaPrincipal.Name = "panelPaginaPrincipal";
            panelPaginaPrincipal.Size = new Size(1334, 457);
            panelPaginaPrincipal.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(522, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 4;
            label1.Text = "Página Principal";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(531, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(216, 45);
            label3.TabIndex = 5;
            label3.Text = "Pizzaria do Zé";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(label3);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1334, 78);
            panelTitulo.TabIndex = 6;
            // 
            // panelPagina
            // 
            panelPagina.Controls.Add(panelPaginaPrincipal);
            panelPagina.Controls.Add(panelBotoesCadastros);
            panelPagina.Dock = DockStyle.Fill;
            panelPagina.Location = new Point(0, 78);
            panelPagina.Margin = new Padding(2);
            panelPagina.Name = "panelPagina";
            panelPagina.Size = new Size(1334, 547);
            panelPagina.TabIndex = 7;
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(1334, 625);
            Controls.Add(panelPagina);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Principal";
            WindowState = FormWindowState.Maximized;
            panelBotoesCadastros.ResumeLayout(false);
            panelBotoesCadastros.PerformLayout();
            panelPaginaPrincipal.ResumeLayout(false);
            panelPaginaPrincipal.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelPagina.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCadastroCliente;
        private Button btnCadastroIngredientes;
        private Button btnCadastroSabores;
        private Panel panelBotoesCadastros;
        private Panel panelPaginaPrincipal;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCadastroFuncionario;
        private Panel panelTitulo;
        private Panel panelPagina;
        private PageSetupDialog pageSetupDialog1;
    }
}