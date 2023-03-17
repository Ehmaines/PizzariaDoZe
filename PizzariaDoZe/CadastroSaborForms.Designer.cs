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
            label1 = new Label();
            txtSaborId = new TextBox();
            label2 = new Label();
            label15 = new Label();
            txtNomeSabor = new TextBox();
            labal16 = new Label();
            comboBoxCategoriaSabor = new ComboBox();
            comboBoxTipoSabor = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            saveCloseUserControlForm1 = new SaveCloseUserControlForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(10, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 35;
            label1.Text = "Código";
            // 
            // txtSaborId
            // 
            txtSaborId.BackColor = Color.GhostWhite;
            txtSaborId.Enabled = false;
            txtSaborId.Location = new Point(10, 29);
            txtSaborId.Margin = new Padding(3, 2, 3, 2);
            txtSaborId.Name = "txtSaborId";
            txtSaborId.Size = new Size(79, 23);
            txtSaborId.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(66, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 45);
            label2.TabIndex = 36;
            label2.Text = "Cadastro de Sabores";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.GhostWhite;
            label15.Location = new Point(10, 58);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(53, 21);
            label15.TabIndex = 38;
            label15.Text = "Nome";
            // 
            // txtNomeSabor
            // 
            txtNomeSabor.BackColor = Color.GhostWhite;
            txtNomeSabor.Location = new Point(7, 80);
            txtNomeSabor.Margin = new Padding(3, 2, 3, 2);
            txtNomeSabor.Name = "txtNomeSabor";
            txtNomeSabor.Size = new Size(209, 23);
            txtNomeSabor.TabIndex = 37;
            // 
            // labal16
            // 
            labal16.AutoSize = true;
            labal16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labal16.ForeColor = Color.GhostWhite;
            labal16.Location = new Point(7, 107);
            labal16.Margin = new Padding(2, 0, 2, 0);
            labal16.Name = "labal16";
            labal16.Size = new Size(77, 21);
            labal16.TabIndex = 39;
            labal16.Text = "Categoria";
            // 
            // comboBoxCategoriaSabor
            // 
            comboBoxCategoriaSabor.BackColor = Color.GhostWhite;
            comboBoxCategoriaSabor.FormattingEnabled = true;
            comboBoxCategoriaSabor.Items.AddRange(new object[] { "tradicional", "especial" });
            comboBoxCategoriaSabor.Location = new Point(7, 128);
            comboBoxCategoriaSabor.Margin = new Padding(2);
            comboBoxCategoriaSabor.Name = "comboBoxCategoriaSabor";
            comboBoxCategoriaSabor.Size = new Size(209, 23);
            comboBoxCategoriaSabor.TabIndex = 40;
            // 
            // comboBoxTipoSabor
            // 
            comboBoxTipoSabor.BackColor = Color.GhostWhite;
            comboBoxTipoSabor.FormattingEnabled = true;
            comboBoxTipoSabor.Items.AddRange(new object[] { "salgada", "doce" });
            comboBoxTipoSabor.Location = new Point(6, 185);
            comboBoxTipoSabor.Margin = new Padding(2);
            comboBoxTipoSabor.Name = "comboBoxTipoSabor";
            comboBoxTipoSabor.Size = new Size(209, 23);
            comboBoxTipoSabor.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(6, 164);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 41;
            label3.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSaborId);
            panel1.Controls.Add(comboBoxTipoSabor);
            panel1.Controls.Add(txtNomeSabor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(comboBoxCategoriaSabor);
            panel1.Controls.Add(labal16);
            panel1.Location = new Point(8, 59);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 401);
            panel1.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(10, 221);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 43;
            label4.Text = "Imagem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PizzaMock;
            pictureBox1.Location = new Point(7, 242);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 153);
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
            checkedListBox1.Location = new Point(286, 83);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 364);
            checkedListBox1.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(286, 59);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 46;
            label5.Text = "Ingredientes";
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(218, 465);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(227, 43);
            saveCloseUserControlForm1.TabIndex = 48;
            // 
            // CadastroSaborForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(447, 523);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(label5);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MaximumSize = new Size(463, 562);
            MinimumSize = new Size(463, 562);
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

        private Label label1;
        private TextBox txtSaborId;
        private Label label2;
        private Label label15;
        private TextBox txtNomeSabor;
        private Label labal16;
        private ComboBox comboBoxCategoriaSabor;
        private ComboBox comboBoxTipoSabor;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private SaveCloseUserControlForm saveCloseUserControlForm1;
    }
}