namespace PizzariaDoZe
{
    partial class CadastroSaborForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSaborForms));
            labelId = new Label();
            txtSaborId = new TextBox();
            labelCadastrarSabor = new Label();
            labelNome = new Label();
            txtNomeSabor = new TextBox();
            labalCategoria = new Label();
            comboBoxCategoriaSabor = new ComboBox();
            comboBoxTipoSabor = new ComboBox();
            labelTipo = new Label();
            panel1 = new Panel();
            labelImagem = new Label();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            labelIngredientes = new Label();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(14, 12);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 32);
            labelId.TabIndex = 35;
            labelId.Text = "Id";
            // 
            // txtSaborId
            // 
            txtSaborId.BackColor = Color.GhostWhite;
            txtSaborId.Enabled = false;
            txtSaborId.Location = new Point(14, 48);
            txtSaborId.Margin = new Padding(4, 2, 4, 2);
            txtSaborId.Name = "txtSaborId";
            txtSaborId.Size = new Size(112, 31);
            txtSaborId.TabIndex = 34;
            // 
            // labelCadastrarSabor
            // 
            labelCadastrarSabor.AutoSize = true;
            labelCadastrarSabor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarSabor.ForeColor = Color.GhostWhite;
            labelCadastrarSabor.Location = new Point(94, 8);
            labelCadastrarSabor.Margin = new Padding(2, 0, 2, 0);
            labelCadastrarSabor.Name = "labelCadastrarSabor";
            labelCadastrarSabor.Size = new Size(462, 65);
            labelCadastrarSabor.TabIndex = 36;
            labelCadastrarSabor.Text = "Cadastro de Sabores";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(14, 98);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(80, 32);
            labelNome.TabIndex = 38;
            labelNome.Text = "Nome";
            // 
            // txtNomeSabor
            // 
            txtNomeSabor.BackColor = Color.GhostWhite;
            txtNomeSabor.Location = new Point(10, 132);
            txtNomeSabor.Margin = new Padding(4, 2, 4, 2);
            txtNomeSabor.Name = "txtNomeSabor";
            txtNomeSabor.Size = new Size(296, 31);
            txtNomeSabor.TabIndex = 37;
            // 
            // labalCategoria
            // 
            labalCategoria.AutoSize = true;
            labalCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labalCategoria.ForeColor = Color.GhostWhite;
            labalCategoria.Location = new Point(10, 178);
            labalCategoria.Margin = new Padding(2, 0, 2, 0);
            labalCategoria.Name = "labalCategoria";
            labalCategoria.Size = new Size(116, 32);
            labalCategoria.TabIndex = 39;
            labalCategoria.Text = "Categoria";
            // 
            // comboBoxCategoriaSabor
            // 
            comboBoxCategoriaSabor.BackColor = Color.GhostWhite;
            comboBoxCategoriaSabor.FormattingEnabled = true;
            comboBoxCategoriaSabor.Items.AddRange(new object[] { "tradicional", "especial" });
            comboBoxCategoriaSabor.Location = new Point(10, 212);
            comboBoxCategoriaSabor.Margin = new Padding(2);
            comboBoxCategoriaSabor.Name = "comboBoxCategoriaSabor";
            comboBoxCategoriaSabor.Size = new Size(296, 33);
            comboBoxCategoriaSabor.TabIndex = 40;
            // 
            // comboBoxTipoSabor
            // 
            comboBoxTipoSabor.BackColor = Color.GhostWhite;
            comboBoxTipoSabor.FormattingEnabled = true;
            comboBoxTipoSabor.Items.AddRange(new object[] { "salgada", "doce" });
            comboBoxTipoSabor.Location = new Point(9, 308);
            comboBoxTipoSabor.Margin = new Padding(2);
            comboBoxTipoSabor.Name = "comboBoxTipoSabor";
            comboBoxTipoSabor.Size = new Size(296, 33);
            comboBoxTipoSabor.TabIndex = 42;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.GhostWhite;
            labelTipo.Location = new Point(9, 272);
            labelTipo.Margin = new Padding(2, 0, 2, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(61, 32);
            labelTipo.TabIndex = 41;
            labelTipo.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelImagem);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSaborId);
            panel1.Controls.Add(comboBoxTipoSabor);
            panel1.Controls.Add(txtNomeSabor);
            panel1.Controls.Add(labelTipo);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(comboBoxCategoriaSabor);
            panel1.Controls.Add(labalCategoria);
            panel1.Location = new Point(11, 98);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 668);
            panel1.TabIndex = 44;
            // 
            // labelImagem
            // 
            labelImagem.AutoSize = true;
            labelImagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelImagem.ForeColor = Color.GhostWhite;
            labelImagem.Location = new Point(14, 368);
            labelImagem.Margin = new Padding(2, 0, 2, 0);
            labelImagem.Name = "labelImagem";
            labelImagem.Size = new Size(101, 32);
            labelImagem.TabIndex = 43;
            labelImagem.Text = "Imagem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 402);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.GhostWhite;
            checkedListBox1.ForeColor = Color.FromArgb(39, 39, 41);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Queijo", "Frango", "Catupiry", "Cebola", "Tomate", "Bacon", "Cheddar" });
            checkedListBox1.Location = new Point(409, 138);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(213, 564);
            checkedListBox1.TabIndex = 45;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientes.ForeColor = Color.GhostWhite;
            labelIngredientes.Location = new Point(409, 98);
            labelIngredientes.Margin = new Padding(2, 0, 2, 0);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(147, 32);
            labelIngredientes.TabIndex = 46;
            labelIngredientes.Text = "Ingredientes";
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(311, 775);
            saveCloseUserControlForm1.Margin = new Padding(6, 8, 6, 8);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(324, 72);
            saveCloseUserControlForm1.TabIndex = 48;
            // 
            // CadastroSaborForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(629, 841);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelIngredientes);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            Controls.Add(labelCadastrarSabor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MaximumSize = new Size(651, 897);
            MinimumSize = new Size(651, 897);
            Name = "CadastroSaborForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroSaborForms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private TextBox txtSaborId;
        private Label labelCadastrarSabor;
        private Label labelNome;
        private TextBox txtNomeSabor;
        private Label labalCategoria;
        private ComboBox comboBoxCategoriaSabor;
        private ComboBox comboBoxTipoSabor;
        private Label labelTipo;
        private Panel panel1;
        private Label labelImagem;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private Label labelIngredientes;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}