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
            PanelBotoesCadastros = new Panel();
            label2 = new Label();
            panelPaginaPrincipal = new Panel();
            label1 = new Label();
            label3 = new Label();
            PanelBotoesCadastros.SuspendLayout();
            panelPaginaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroCliente.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroCliente.Location = new Point(363, 87);
            btnCadastroCliente.Margin = new Padding(4, 3, 4, 3);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(250, 53);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastro Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnCadastroIngredientes
            // 
            btnCadastroIngredientes.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroIngredientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroIngredientes.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroIngredientes.Location = new Point(657, 85);
            btnCadastroIngredientes.Margin = new Padding(4, 3, 4, 3);
            btnCadastroIngredientes.Name = "btnCadastroIngredientes";
            btnCadastroIngredientes.Size = new Size(250, 53);
            btnCadastroIngredientes.TabIndex = 2;
            btnCadastroIngredientes.Text = "Cadastro Ingredientes";
            btnCadastroIngredientes.UseVisualStyleBackColor = false;
            btnCadastroIngredientes.Click += btnCadastroIngredientes_Click;
            // 
            // btnCadastroSabores
            // 
            btnCadastroSabores.BackColor = Color.FromArgb(114, 138, 244);
            btnCadastroSabores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroSabores.ForeColor = Color.FromArgb(39, 39, 41);
            btnCadastroSabores.Location = new Point(946, 87);
            btnCadastroSabores.Margin = new Padding(4, 3, 4, 3);
            btnCadastroSabores.Name = "btnCadastroSabores";
            btnCadastroSabores.Size = new Size(250, 53);
            btnCadastroSabores.TabIndex = 3;
            btnCadastroSabores.Text = "Cadastro Sabores";
            btnCadastroSabores.UseVisualStyleBackColor = false;
            btnCadastroSabores.Click += btnCadastroSabores_Click;
            // 
            // PanelBotoesCadastros
            // 
            PanelBotoesCadastros.BorderStyle = BorderStyle.FixedSingle;
            PanelBotoesCadastros.Controls.Add(label2);
            PanelBotoesCadastros.Controls.Add(btnCadastroSabores);
            PanelBotoesCadastros.Controls.Add(btnCadastroCliente);
            PanelBotoesCadastros.Controls.Add(btnCadastroIngredientes);
            PanelBotoesCadastros.Location = new Point(26, 135);
            PanelBotoesCadastros.Margin = new Padding(4, 3, 4, 3);
            PanelBotoesCadastros.Name = "PanelBotoesCadastros";
            PanelBotoesCadastros.Size = new Size(1282, 177);
            PanelBotoesCadastros.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(554, 22);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 6;
            label2.Text = "Cadastros";
            // 
            // panelPaginaPrincipal
            // 
            panelPaginaPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPaginaPrincipal.Controls.Add(label1);
            panelPaginaPrincipal.Location = new Point(26, 383);
            panelPaginaPrincipal.Margin = new Padding(4, 3, 4, 3);
            panelPaginaPrincipal.Name = "panelPaginaPrincipal";
            panelPaginaPrincipal.Size = new Size(1282, 325);
            panelPaginaPrincipal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(453, 15);
            label1.Name = "label1";
            label1.Size = new Size(362, 65);
            label1.TabIndex = 4;
            label1.Text = "Página Principal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(494, 8);
            label3.Name = "label3";
            label3.Size = new Size(322, 65);
            label3.TabIndex = 5;
            label3.Text = "Pizzaria do Zé";
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(1317, 758);
            Controls.Add(label3);
            Controls.Add(panelPaginaPrincipal);
            Controls.Add(PanelBotoesCadastros);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1339, 814);
            MinimumSize = new Size(1339, 814);
            Name = "PaginaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Principal";
            WindowState = FormWindowState.Maximized;
            PanelBotoesCadastros.ResumeLayout(false);
            PanelBotoesCadastros.PerformLayout();
            panelPaginaPrincipal.ResumeLayout(false);
            panelPaginaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastroCliente;
        private Button btnCadastroIngredientes;
        private Button btnCadastroSabores;
        private Panel PanelBotoesCadastros;
        private Panel panelPaginaPrincipal;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}