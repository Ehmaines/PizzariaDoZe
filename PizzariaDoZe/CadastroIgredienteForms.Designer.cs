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
            label2 = new Label();
            label15 = new Label();
            txtNomeIngrediente = new TextBox();
            btnSalvarIngrediente = new Button();
            label1 = new Label();
            txtIngredienteId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(55, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(378, 45);
            label2.TabIndex = 6;
            label2.Text = "Cadastro de Ingredientes";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.GhostWhite;
            label15.Location = new Point(52, 97);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(53, 21);
            label15.TabIndex = 30;
            label15.Text = "Nome";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.BackColor = Color.GhostWhite;
            txtNomeIngrediente.Location = new Point(49, 118);
            txtNomeIngrediente.Margin = new Padding(3, 2, 3, 2);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(406, 23);
            txtNomeIngrediente.TabIndex = 0;
            // 
            // btnSalvarIngrediente
            // 
            btnSalvarIngrediente.BackColor = Color.FromArgb(114, 138, 244);
            btnSalvarIngrediente.FlatAppearance.BorderColor = Color.GhostWhite;
            btnSalvarIngrediente.Location = new Point(352, 149);
            btnSalvarIngrediente.Margin = new Padding(2, 2, 2, 2);
            btnSalvarIngrediente.Name = "btnSalvarIngrediente";
            btnSalvarIngrediente.Size = new Size(102, 25);
            btnSalvarIngrediente.TabIndex = 31;
            btnSalvarIngrediente.Text = "Salvar";
            btnSalvarIngrediente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(52, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 33;
            label1.Text = "Código";
            // 
            // txtIngredienteId
            // 
            txtIngredienteId.BackColor = Color.GhostWhite;
            txtIngredienteId.Enabled = false;
            txtIngredienteId.Location = new Point(52, 76);
            txtIngredienteId.Margin = new Padding(3, 2, 3, 2);
            txtIngredienteId.Name = "txtIngredienteId";
            txtIngredienteId.Size = new Size(79, 23);
            txtIngredienteId.TabIndex = 1;
            // 
            // CadastroIngredienteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(487, 186);
            Controls.Add(label1);
            Controls.Add(txtIngredienteId);
            Controls.Add(btnSalvarIngrediente);
            Controls.Add(label15);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CadastroIngredienteForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Ingrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label15;
        private TextBox txtNomeIngrediente;
        private Button btnSalvarIngrediente;
        private Label label1;
        private TextBox txtIngredienteId;
    }
}