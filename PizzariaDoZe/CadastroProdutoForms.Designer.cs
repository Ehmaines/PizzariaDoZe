namespace PizzariaDoZe
{
    partial class CadastroProdutoForms
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
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            labelId = new Label();
            txtIngredienteId = new TextBox();
            labelNome = new Label();
            txtNomeProduto = new TextBox();
            labelCadastrarProduto = new Label();
            labelValor = new Label();
            textBoxValor = new TextBox();
            listBoxTipo = new ListBox();
            labelTipo = new Label();
            labelMl = new Label();
            listBoxML = new ListBox();
            SuspendLayout();
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(178, 349);
            saveCloseUserControlForm1.Margin = new Padding(3, 4, 3, 4);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(230, 36);
            saveCloseUserControlForm1.TabIndex = 40;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(43, 53);
            labelId.Margin = new Padding(1, 0, 1, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(60, 21);
            labelId.TabIndex = 39;
            labelId.Text = "Código";
            // 
            // txtIngredienteId
            // 
            txtIngredienteId.BackColor = Color.GhostWhite;
            txtIngredienteId.Enabled = false;
            txtIngredienteId.Location = new Point(41, 77);
            txtIngredienteId.Margin = new Padding(3, 2, 3, 2);
            txtIngredienteId.Name = "txtIngredienteId";
            txtIngredienteId.Size = new Size(80, 23);
            txtIngredienteId.TabIndex = 36;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(43, 107);
            labelNome.Margin = new Padding(1, 0, 1, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 21);
            labelNome.TabIndex = 38;
            labelNome.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.GhostWhite;
            txtNomeProduto.Location = new Point(41, 128);
            txtNomeProduto.Margin = new Padding(3, 2, 3, 2);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(358, 23);
            txtNomeProduto.TabIndex = 35;
            // 
            // labelCadastrarProduto
            // 
            labelCadastrarProduto.AutoSize = true;
            labelCadastrarProduto.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarProduto.ForeColor = Color.GhostWhite;
            labelCadastrarProduto.Location = new Point(41, 7);
            labelCadastrarProduto.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarProduto.Name = "labelCadastrarProduto";
            labelCadastrarProduto.Size = new Size(329, 45);
            labelCadastrarProduto.TabIndex = 37;
            labelCadastrarProduto.Text = "Cadastro de Produtos";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.ForeColor = Color.GhostWhite;
            labelValor.Location = new Point(43, 163);
            labelValor.Margin = new Padding(1, 0, 1, 0);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(46, 21);
            labelValor.TabIndex = 42;
            labelValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.BackColor = Color.GhostWhite;
            textBoxValor.Location = new Point(41, 184);
            textBoxValor.Margin = new Padding(3, 2, 3, 2);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(358, 23);
            textBoxValor.TabIndex = 41;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Água", "Suco" });
            listBoxTipo.Location = new Point(43, 239);
            listBoxTipo.Margin = new Padding(3, 2, 3, 2);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(124, 94);
            listBoxTipo.TabIndex = 43;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.GhostWhite;
            labelTipo.Location = new Point(43, 216);
            labelTipo.Margin = new Padding(1, 0, 1, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(40, 21);
            labelTipo.TabIndex = 44;
            labelTipo.Text = "Tipo";
            // 
            // labelMl
            // 
            labelMl.AutoSize = true;
            labelMl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMl.ForeColor = Color.GhostWhite;
            labelMl.Location = new Point(195, 216);
            labelMl.Margin = new Padding(1, 0, 1, 0);
            labelMl.Name = "labelMl";
            labelMl.Size = new Size(32, 21);
            labelMl.TabIndex = 46;
            labelMl.Text = "ML";
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxML.Location = new Point(195, 239);
            listBoxML.Margin = new Padding(3, 2, 3, 2);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(124, 94);
            listBoxML.TabIndex = 45;
            // 
            // CadastroProdutoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(424, 398);
            Controls.Add(labelMl);
            Controls.Add(listBoxML);
            Controls.Add(labelTipo);
            Controls.Add(listBoxTipo);
            Controls.Add(labelValor);
            Controls.Add(textBoxValor);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelId);
            Controls.Add(txtIngredienteId);
            Controls.Add(labelNome);
            Controls.Add(txtNomeProduto);
            Controls.Add(labelCadastrarProduto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroProdutoForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProdutoForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveCloseUserControlForm saveCloseUserControlForm1;
        private Label labelId;
        private TextBox txtIngredienteId;
        private Label labelNome;
        private TextBox txtNomeProduto;
        private Label labelCadastrarProduto;
        private Label labelValor;
        private TextBox textBoxValor;
        private ListBox listBoxTipo;
        private Label labelTipo;
        private Label labelMl;
        private ListBox listBoxML;
    }
}