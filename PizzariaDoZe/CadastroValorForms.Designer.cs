namespace PizzariaDoZe
{
    partial class CadastroValorForms
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
            labelValor = new Label();
            txtValorTradicional = new TextBox();
            labelCadastrarValor = new Label();
            labelValorBorda = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            labelTamanho = new Label();
            comboBox1 = new ComboBox();
            labelCategoria = new Label();
            SuspendLayout();
            // 
            // saveCloseUserControlForm1
            // 
            saveCloseUserControlForm1.BackColor = Color.FromArgb(39, 39, 41);
            saveCloseUserControlForm1.Location = new Point(132, 695);
            saveCloseUserControlForm1.Margin = new Padding(4, 6, 4, 6);
            saveCloseUserControlForm1.Name = "saveCloseUserControlForm1";
            saveCloseUserControlForm1.Size = new Size(329, 60);
            saveCloseUserControlForm1.TabIndex = 40;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(46, 79);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(91, 32);
            labelId.TabIndex = 39;
            labelId.Text = "Código";
            // 
            // txtIngredienteId
            // 
            txtIngredienteId.BackColor = Color.GhostWhite;
            txtIngredienteId.Enabled = false;
            txtIngredienteId.Location = new Point(46, 125);
            txtIngredienteId.Margin = new Padding(4);
            txtIngredienteId.Name = "txtIngredienteId";
            txtIngredienteId.Size = new Size(112, 31);
            txtIngredienteId.TabIndex = 36;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.ForeColor = Color.GhostWhite;
            labelValor.Location = new Point(46, 465);
            labelValor.Margin = new Padding(2, 0, 2, 0);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(67, 32);
            labelValor.TabIndex = 38;
            labelValor.Text = "Valor";
            // 
            // txtValorTradicional
            // 
            txtValorTradicional.BackColor = Color.GhostWhite;
            txtValorTradicional.Location = new Point(42, 511);
            txtValorTradicional.Margin = new Padding(4);
            txtValorTradicional.Name = "txtValorTradicional";
            txtValorTradicional.Size = new Size(368, 31);
            txtValorTradicional.TabIndex = 35;
            // 
            // labelCadastrarValor
            // 
            labelCadastrarValor.AutoSize = true;
            labelCadastrarValor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarValor.ForeColor = Color.GhostWhite;
            labelCadastrarValor.Location = new Point(26, 11);
            labelCadastrarValor.Margin = new Padding(2, 0, 2, 0);
            labelCadastrarValor.Name = "labelCadastrarValor";
            labelCadastrarValor.Size = new Size(446, 65);
            labelCadastrarValor.TabIndex = 37;
            labelCadastrarValor.Text = "Cadastro de Valores";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorBorda.ForeColor = Color.GhostWhite;
            labelValorBorda.Location = new Point(46, 561);
            labelValorBorda.Margin = new Padding(2, 0, 2, 0);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(136, 32);
            labelValorBorda.TabIndex = 47;
            labelValorBorda.Text = "Valor Borda";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.GhostWhite;
            textBox1.Location = new Point(42, 608);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 46;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Pequena", "Média", "Grande" });
            listBox1.Location = new Point(46, 222);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 129);
            listBox1.TabIndex = 48;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTamanho.ForeColor = Color.GhostWhite;
            labelTamanho.Location = new Point(46, 176);
            labelTamanho.Margin = new Padding(2, 0, 2, 0);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(111, 32);
            labelTamanho.TabIndex = 49;
            labelTamanho.Text = "Tamanho";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tradicional", "Especial" });
            comboBox1.Location = new Point(46, 414);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 33);
            comboBox1.TabIndex = 50;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoria.ForeColor = Color.GhostWhite;
            labelCategoria.Location = new Point(46, 368);
            labelCategoria.Margin = new Padding(2, 0, 2, 0);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(116, 32);
            labelCategoria.TabIndex = 51;
            labelCategoria.Text = "Categoria";
            // 
            // CadastroValorForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(495, 772);
            Controls.Add(labelCategoria);
            Controls.Add(comboBox1);
            Controls.Add(labelTamanho);
            Controls.Add(listBox1);
            Controls.Add(labelValorBorda);
            Controls.Add(textBox1);
            Controls.Add(saveCloseUserControlForm1);
            Controls.Add(labelId);
            Controls.Add(txtIngredienteId);
            Controls.Add(labelValor);
            Controls.Add(txtValorTradicional);
            Controls.Add(labelCadastrarValor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "CadastroValorForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroValorForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveCloseUserControlForm saveCloseUserControlForm1;
        private Label labelId;
        private TextBox txtIngredienteId;
        private Label labelValor;
        private TextBox txtValorTradicional;
        private Label labelCadastrarValor;
        private Label labelValorBorda;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label labelTamanho;
        private ComboBox comboBox1;
        private Label labelCategoria;
    }
}