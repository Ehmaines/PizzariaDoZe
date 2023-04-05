namespace PizzariaDoZe
{
    partial class CadastroIngredienteForms
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
            labelCadastrarIngrediente = new Label();
            labelNome = new Label();
            txtNomeIngrediente = new TextBox();
            labelId = new Label();
            txtIngredienteId = new TextBox();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            SuspendLayout();
            // 
            // labelCadastrarIngrediente
            // 
            labelCadastrarIngrediente.AutoSize = true;
            labelCadastrarIngrediente.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarIngrediente.ForeColor = Color.GhostWhite;
            labelCadastrarIngrediente.Location = new Point(79, 9);
            labelCadastrarIngrediente.Margin = new Padding(2, 0, 2, 0);
            labelCadastrarIngrediente.Name = "labelCadastrarIngrediente";
            labelCadastrarIngrediente.Size = new Size(557, 65);
            labelCadastrarIngrediente.TabIndex = 6;
            labelCadastrarIngrediente.Text = "Cadastro de Ingredientes";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(74, 161);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(80, 32);
            labelNome.TabIndex = 30;
            labelNome.Text = "Nome";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.BackColor = Color.GhostWhite;
            txtNomeIngrediente.Location = new Point(70, 196);
            txtNomeIngrediente.Margin = new Padding(4, 4, 4, 4);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(578, 31);
            txtNomeIngrediente.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(74, 90);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 32);
            labelId.TabIndex = 33;
            labelId.Text = "Id";
            // 
            // txtIngredienteId
            // 
            txtIngredienteId.BackColor = Color.GhostWhite;
            txtIngredienteId.Enabled = false;
            txtIngredienteId.Location = new Point(70, 129);
            txtIngredienteId.Margin = new Padding(4, 4, 4, 4);
            txtIngredienteId.Name = "txtIngredienteId";
            txtIngredienteId.Size = new Size(112, 31);
            txtIngredienteId.TabIndex = 1;
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(342, 244);
            saveCloseUserControlForm1.Margin = new Padding(4, 6, 4, 6);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(329, 60);
            saveCloseUserControlForm1.TabIndex = 34;
            // 
            // CadastroIngredienteForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(696, 310);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelId);
            Controls.Add(txtIngredienteId);
            Controls.Add(labelNome);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(labelCadastrarIngrediente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 4, 2, 4);
            Name = "CadastroIngredienteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Ingrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCadastrarIngrediente;
        private Label labelNome;
        private TextBox txtNomeIngrediente;
        private Label labelId;
        private TextBox txtIngredienteId;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}