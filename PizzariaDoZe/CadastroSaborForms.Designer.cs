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
            labelCadastroSabores = new Label();
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
            labelId.Location = new Point(11, 10);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 28);
            labelId.TabIndex = 35;
            labelId.Text = "Id";
            // 
            // txtSaborId
            // 
            txtSaborId.BackColor = Color.GhostWhite;
            txtSaborId.Enabled = false;
            txtSaborId.Location = new Point(11, 38);
            txtSaborId.Margin = new Padding(3, 2, 3, 2);
            txtSaborId.Name = "txtSaborId";
            txtSaborId.Size = new Size(90, 27);
            txtSaborId.TabIndex = 34;
            // 
            // labelCadastroSabores
            // 
            labelCadastroSabores.AutoSize = true;
            labelCadastroSabores.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastroSabores.ForeColor = Color.GhostWhite;
            labelCadastroSabores.Location = new Point(75, 6);
            labelCadastroSabores.Margin = new Padding(2, 0, 2, 0);
            labelCadastroSabores.Name = "labelCadastroSabores";
            labelCadastroSabores.Size = new Size(387, 54);
            labelCadastroSabores.TabIndex = 36;
            labelCadastroSabores.Text = "Cadastro de Sabores";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(11, 78);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(66, 28);
            labelNome.TabIndex = 38;
            labelNome.Text = "Nome";
            // 
            // txtNomeSabor
            // 
            txtNomeSabor.BackColor = Color.GhostWhite;
            txtNomeSabor.Location = new Point(8, 106);
            txtNomeSabor.Margin = new Padding(3, 2, 3, 2);
            txtNomeSabor.Name = "txtNomeSabor";
            txtNomeSabor.Size = new Size(238, 27);
            txtNomeSabor.TabIndex = 37;
            // 
            // labalCategoria
            // 
            labalCategoria.AutoSize = true;
            labalCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labalCategoria.ForeColor = Color.GhostWhite;
            labalCategoria.Location = new Point(8, 142);
            labalCategoria.Margin = new Padding(2, 0, 2, 0);
            labalCategoria.Name = "labalCategoria";
            labalCategoria.Size = new Size(97, 28);
            labalCategoria.TabIndex = 39;
            labalCategoria.Text = "Categoria";
            // 
            // comboBoxCategoriaSabor
            // 
            comboBoxCategoriaSabor.BackColor = Color.GhostWhite;
            comboBoxCategoriaSabor.FormattingEnabled = true;
            comboBoxCategoriaSabor.Items.AddRange(new object[] { "tradicional", "especial" });
            comboBoxCategoriaSabor.Location = new Point(8, 170);
            comboBoxCategoriaSabor.Margin = new Padding(2, 2, 2, 2);
            comboBoxCategoriaSabor.Name = "comboBoxCategoriaSabor";
            comboBoxCategoriaSabor.Size = new Size(238, 28);
            comboBoxCategoriaSabor.TabIndex = 40;
            // 
            // comboBoxTipoSabor
            // 
            comboBoxTipoSabor.BackColor = Color.GhostWhite;
            comboBoxTipoSabor.FormattingEnabled = true;
            comboBoxTipoSabor.Items.AddRange(new object[] { "salgada", "doce" });
            comboBoxTipoSabor.Location = new Point(7, 246);
            comboBoxTipoSabor.Margin = new Padding(2, 2, 2, 2);
            comboBoxTipoSabor.Name = "comboBoxTipoSabor";
            comboBoxTipoSabor.Size = new Size(238, 28);
            comboBoxTipoSabor.TabIndex = 42;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.GhostWhite;
            labelTipo.Location = new Point(7, 218);
            labelTipo.Margin = new Padding(2, 0, 2, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(51, 28);
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
            panel1.Location = new Point(9, 78);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 534);
            panel1.TabIndex = 44;
            // 
            // labelImagem
            // 
            labelImagem.AutoSize = true;
            labelImagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelImagem.ForeColor = Color.GhostWhite;
            labelImagem.Location = new Point(11, 294);
            labelImagem.Margin = new Padding(2, 0, 2, 0);
            labelImagem.Name = "labelImagem";
            labelImagem.Size = new Size(83, 28);
            labelImagem.TabIndex = 43;
            labelImagem.Text = "Imagem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 322);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 204);
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
            checkedListBox1.Location = new Point(327, 110);
            checkedListBox1.Margin = new Padding(2, 2, 2, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(171, 466);
            checkedListBox1.TabIndex = 45;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientes.ForeColor = Color.GhostWhite;
            labelIngredientes.Location = new Point(327, 78);
            labelIngredientes.Margin = new Padding(2, 0, 2, 0);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(120, 28);
            labelIngredientes.TabIndex = 46;
            labelIngredientes.Text = "Ingredientes";
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(249, 620);
            saveCloseUserControlForm1.Margin = new Padding(5, 6, 5, 6);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(259, 58);
            saveCloseUserControlForm1.TabIndex = 48;
            // 
            // CadastroSaborForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(507, 682);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelIngredientes);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            Controls.Add(labelCadastroSabores);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(525, 729);
            MinimumSize = new Size(525, 729);
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
        private Label labelCadastroSabores;
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