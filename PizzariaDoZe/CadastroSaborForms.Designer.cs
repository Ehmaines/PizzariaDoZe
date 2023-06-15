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
            labelTipo = new Label();
            panel1 = new Panel();
            listBoxCategoria = new ListBox();
            listBoxTipo = new ListBox();
            labelImagem = new Label();
            pictureBoxImagem = new PictureBox();
            checkedListBoxIngredientes = new CheckedListBox();
            labelIngredientes = new Label();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(10, 7);
            labelId.Margin = new Padding(1, 0, 1, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(23, 21);
            labelId.TabIndex = 35;
            labelId.Text = "Id";
            // 
            // txtSaborId
            // 
            txtSaborId.BackColor = Color.GhostWhite;
            txtSaborId.Enabled = false;
            txtSaborId.Location = new Point(10, 29);
            txtSaborId.Margin = new Padding(3, 1, 3, 1);
            txtSaborId.Name = "txtSaborId";
            txtSaborId.Size = new Size(80, 23);
            txtSaborId.TabIndex = 34;
            // 
            // labelCadastrarSabor
            // 
            labelCadastrarSabor.AutoSize = true;
            labelCadastrarSabor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarSabor.ForeColor = Color.GhostWhite;
            labelCadastrarSabor.Location = new Point(66, 5);
            labelCadastrarSabor.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarSabor.Name = "labelCadastrarSabor";
            labelCadastrarSabor.Size = new Size(313, 45);
            labelCadastrarSabor.TabIndex = 36;
            labelCadastrarSabor.Text = "Cadastro de Sabores";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(6, 57);
            labelNome.Margin = new Padding(1, 0, 1, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 21);
            labelNome.TabIndex = 38;
            labelNome.Text = "Nome";
            // 
            // txtNomeSabor
            // 
            txtNomeSabor.BackColor = Color.GhostWhite;
            txtNomeSabor.Location = new Point(7, 79);
            txtNomeSabor.Margin = new Padding(3, 1, 3, 1);
            txtNomeSabor.Name = "txtNomeSabor";
            txtNomeSabor.Size = new Size(278, 23);
            txtNomeSabor.TabIndex = 37;
            // 
            // labalCategoria
            // 
            labalCategoria.AutoSize = true;
            labalCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labalCategoria.ForeColor = Color.GhostWhite;
            labalCategoria.Location = new Point(165, 122);
            labalCategoria.Margin = new Padding(1, 0, 1, 0);
            labalCategoria.Name = "labalCategoria";
            labalCategoria.Size = new Size(77, 21);
            labalCategoria.TabIndex = 39;
            labalCategoria.Text = "Categoria";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.GhostWhite;
            labelTipo.Location = new Point(10, 122);
            labelTipo.Margin = new Padding(1, 0, 1, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(40, 21);
            labelTipo.TabIndex = 41;
            labelTipo.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxCategoria);
            panel1.Controls.Add(listBoxTipo);
            panel1.Controls.Add(labelImagem);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(pictureBoxImagem);
            panel1.Controls.Add(txtSaborId);
            panel1.Controls.Add(txtNomeSabor);
            panel1.Controls.Add(labelTipo);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labalCategoria);
            panel1.Location = new Point(8, 59);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 441);
            panel1.TabIndex = 44;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(165, 146);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(120, 94);
            listBoxCategoria.TabIndex = 47;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(10, 146);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 46;
            // 
            // labelImagem
            // 
            labelImagem.AutoSize = true;
            labelImagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelImagem.ForeColor = Color.GhostWhite;
            labelImagem.Location = new Point(10, 256);
            labelImagem.Margin = new Padding(1, 0, 1, 0);
            labelImagem.Name = "labelImagem";
            labelImagem.Size = new Size(67, 21);
            labelImagem.TabIndex = 43;
            labelImagem.Text = "Imagem";
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = (Image)resources.GetObject("pictureBoxImagem.Image");
            pictureBoxImagem.Location = new Point(10, 278);
            pictureBoxImagem.Margin = new Padding(1);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(225, 153);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 45;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.BackColor = Color.GhostWhite;
            checkedListBoxIngredientes.ForeColor = Color.FromArgb(39, 39, 41);
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Items.AddRange(new object[] { "Queijo", "Frango", "Catupiry", "Cebola", "Tomate", "Bacon", "Cheddar" });
            checkedListBoxIngredientes.Location = new Point(346, 81);
            checkedListBoxIngredientes.Margin = new Padding(1);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(150, 328);
            checkedListBoxIngredientes.TabIndex = 45;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientes.ForeColor = Color.GhostWhite;
            labelIngredientes.Location = new Point(376, 59);
            labelIngredientes.Margin = new Padding(1, 0, 1, 0);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(96, 21);
            labelIngredientes.TabIndex = 46;
            labelIngredientes.Text = "Ingredientes";
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(269, 458);
            saveCloseUserControlForm1.Margin = new Padding(4, 5, 4, 5);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(227, 43);
            saveCloseUserControlForm1.TabIndex = 48;
            // 
            // CadastroSaborForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(506, 515);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelIngredientes);
            Controls.Add(checkedListBoxIngredientes);
            Controls.Add(panel1);
            Controls.Add(labelCadastrarSabor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(1);
            MinimumSize = new Size(460, 554);
            Name = "CadastroSaborForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Sabor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
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
        private Label labelTipo;
        private Panel panel1;
        private Label labelImagem;
        private PictureBox pictureBoxImagem;
        private CheckedListBox checkedListBoxIngredientes;
        private Label labelIngredientes;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
        private ListBox listBoxCategoria;
        private ListBox listBoxTipo;
    }
}