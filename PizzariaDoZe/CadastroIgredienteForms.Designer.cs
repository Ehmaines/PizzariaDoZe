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
            labelCadastroIngrediente = new Label();
            labelNome = new Label();
            txtNomeIngrediente = new TextBox();
            labelId = new Label();
            txtIngredienteId = new TextBox();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            SuspendLayout();
            // 
            // labelCadastroIngrediente
            // 
            labelCadastroIngrediente.AutoSize = true;
            labelCadastroIngrediente.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastroIngrediente.ForeColor = Color.GhostWhite;
            labelCadastroIngrediente.Location = new Point(63, 7);
            labelCadastroIngrediente.Margin = new Padding(2, 0, 2, 0);
            labelCadastroIngrediente.Name = "labelCadastroIngrediente";
            labelCadastroIngrediente.Size = new Size(470, 54);
            labelCadastroIngrediente.TabIndex = 6;
            labelCadastroIngrediente.Text = "Cadastro de Ingredientes";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.GhostWhite;
            labelNome.Location = new Point(59, 129);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(66, 28);
            labelNome.TabIndex = 30;
            labelNome.Text = "Nome";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.BackColor = Color.GhostWhite;
            txtNomeIngrediente.Location = new Point(56, 157);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(463, 27);
            txtNomeIngrediente.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(59, 72);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 28);
            labelId.TabIndex = 33;
            labelId.Text = "Id";
            // 
            // txtIngredienteId
            // 
            txtIngredienteId.BackColor = Color.GhostWhite;
            txtIngredienteId.Enabled = false;
            txtIngredienteId.Location = new Point(56, 103);
            txtIngredienteId.Name = "txtIngredienteId";
            txtIngredienteId.Size = new Size(90, 27);
            txtIngredienteId.TabIndex = 1;
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(274, 195);
            saveCloseUserControlForm1.Margin = new Padding(3, 5, 3, 5);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(263, 48);
            saveCloseUserControlForm1.TabIndex = 34;
            // 
            // CadastroIngredienteForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(557, 248);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelId);
            Controls.Add(txtIngredienteId);
            Controls.Add(labelNome);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(labelCadastroIngrediente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "CadastroIngredienteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Ingrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCadastroIngrediente;
        private Label labelNome;
        private TextBox txtNomeIngrediente;
        private Label labelId;
        private TextBox txtIngredienteId;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}