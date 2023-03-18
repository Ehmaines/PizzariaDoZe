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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipalForm));
            panel1 = new Panel();
            panelCadastroSabor = new Panel();
            labelCadastroSabor = new Label();
            pictureBoxCadastroSabor = new PictureBox();
            panelCadastroFuncionario = new Panel();
            labelAdicionarFuncionario = new Label();
            pictureBox1 = new PictureBox();
            panelCadastroIngrediente = new Panel();
            labelCadastroIngrediente = new Label();
            pictureBoxCadastroIngrediente = new PictureBox();
            pictureBox2 = new PictureBox();
            panelCadastroCliente = new Panel();
            labelCadastrarCliente = new Label();
            pictureBoxCadastrarCliente = new PictureBox();
            textBoxPesquisa = new TextBox();
            barraLateralUserControlForm = new BarraLateralUserControlForm();
            panelPrincipalInicio = new Panel();
            dataGridView1 = new DataGridView();
            labelReultadosInicio = new Label();
            panel1.SuspendLayout();
            panelCadastroSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroSabor).BeginInit();
            panelCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCadastroIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroIngrediente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarCliente).BeginInit();
            panelPrincipalInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 25, 41);
            panel1.Controls.Add(panelCadastroSabor);
            panel1.Controls.Add(panelCadastroFuncionario);
            panel1.Controls.Add(panelCadastroIngrediente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panelCadastroCliente);
            panel1.Controls.Add(textBoxPesquisa);
            panel1.ForeColor = Color.GhostWhite;
            panel1.Location = new Point(323, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1966, 171);
            panel1.TabIndex = 1;
            // 
            // panelCadastroSabor
            // 
            panelCadastroSabor.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroSabor.Controls.Add(labelCadastroSabor);
            panelCadastroSabor.Controls.Add(pictureBoxCadastroSabor);
            panelCadastroSabor.Cursor = Cursors.Hand;
            panelCadastroSabor.Location = new Point(1564, 46);
            panelCadastroSabor.Name = "panelCadastroSabor";
            panelCadastroSabor.Size = new Size(373, 79);
            panelCadastroSabor.TabIndex = 6;
            panelCadastroSabor.Click += btnCadastroSabores_Click;
            // 
            // labelCadastroSabor
            // 
            labelCadastroSabor.AutoSize = true;
            labelCadastroSabor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastroSabor.ForeColor = Color.GhostWhite;
            labelCadastroSabor.Location = new Point(81, 21);
            labelCadastroSabor.Name = "labelCadastroSabor";
            labelCadastroSabor.Size = new Size(212, 38);
            labelCadastroSabor.TabIndex = 1;
            labelCadastroSabor.Text = "Cadastrar Sabor";
            labelCadastroSabor.Click += btnCadastroSabores_Click;
            // 
            // pictureBoxCadastroSabor
            // 
            pictureBoxCadastroSabor.Image = (Image)resources.GetObject("pictureBoxCadastroSabor.Image");
            pictureBoxCadastroSabor.Location = new Point(6, 9);
            pictureBoxCadastroSabor.Name = "pictureBoxCadastroSabor";
            pictureBoxCadastroSabor.Size = new Size(69, 63);
            pictureBoxCadastroSabor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroSabor.TabIndex = 0;
            pictureBoxCadastroSabor.TabStop = false;
            pictureBoxCadastroSabor.Click += btnCadastroSabores_Click;
            // 
            // panelCadastroFuncionario
            // 
            panelCadastroFuncionario.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroFuncionario.Controls.Add(labelAdicionarFuncionario);
            panelCadastroFuncionario.Controls.Add(pictureBox1);
            panelCadastroFuncionario.Cursor = Cursors.Hand;
            panelCadastroFuncionario.Location = new Point(1564, 46);
            panelCadastroFuncionario.Name = "panelCadastroFuncionario";
            panelCadastroFuncionario.Size = new Size(373, 79);
            panelCadastroFuncionario.TabIndex = 4;
            panelCadastroFuncionario.Click += btnCadastroFuncionario_Click;
            // 
            // labelAdicionarFuncionario
            // 
            labelAdicionarFuncionario.AutoSize = true;
            labelAdicionarFuncionario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdicionarFuncionario.ForeColor = Color.GhostWhite;
            labelAdicionarFuncionario.Location = new Point(81, 21);
            labelAdicionarFuncionario.Name = "labelAdicionarFuncionario";
            labelAdicionarFuncionario.Size = new Size(286, 38);
            labelAdicionarFuncionario.TabIndex = 1;
            labelAdicionarFuncionario.Text = "Cadastrar Funcionário";
            labelAdicionarFuncionario.Click += btnCadastroFuncionario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnCadastroFuncionario_Click;
            // 
            // panelCadastroIngrediente
            // 
            panelCadastroIngrediente.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroIngrediente.Controls.Add(labelCadastroIngrediente);
            panelCadastroIngrediente.Controls.Add(pictureBoxCadastroIngrediente);
            panelCadastroIngrediente.Cursor = Cursors.Hand;
            panelCadastroIngrediente.Location = new Point(1564, 46);
            panelCadastroIngrediente.Name = "panelCadastroIngrediente";
            panelCadastroIngrediente.Size = new Size(373, 79);
            panelCadastroIngrediente.TabIndex = 6;
            panelCadastroIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // labelCadastroIngrediente
            // 
            labelCadastroIngrediente.AutoSize = true;
            labelCadastroIngrediente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastroIngrediente.ForeColor = Color.GhostWhite;
            labelCadastroIngrediente.Location = new Point(81, 21);
            labelCadastroIngrediente.Name = "labelCadastroIngrediente";
            labelCadastroIngrediente.Size = new Size(295, 38);
            labelCadastroIngrediente.TabIndex = 1;
            labelCadastroIngrediente.Text = "Cadastrar Ingredientes";
            labelCadastroIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // pictureBoxCadastroIngrediente
            // 
            pictureBoxCadastroIngrediente.Image = (Image)resources.GetObject("pictureBoxCadastroIngrediente.Image");
            pictureBoxCadastroIngrediente.Location = new Point(6, 9);
            pictureBoxCadastroIngrediente.Name = "pictureBoxCadastroIngrediente";
            pictureBoxCadastroIngrediente.Size = new Size(69, 63);
            pictureBoxCadastroIngrediente.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroIngrediente.TabIndex = 0;
            pictureBoxCadastroIngrediente.TabStop = false;
            pictureBoxCadastroIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(616, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelCadastroCliente
            // 
            panelCadastroCliente.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroCliente.Controls.Add(labelCadastrarCliente);
            panelCadastroCliente.Controls.Add(pictureBoxCadastrarCliente);
            panelCadastroCliente.Cursor = Cursors.Hand;
            panelCadastroCliente.Location = new Point(1564, 46);
            panelCadastroCliente.Name = "panelCadastroCliente";
            panelCadastroCliente.Size = new Size(373, 79);
            panelCadastroCliente.TabIndex = 5;
            panelCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // labelCadastrarCliente
            // 
            labelCadastrarCliente.AutoSize = true;
            labelCadastrarCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarCliente.ForeColor = Color.GhostWhite;
            labelCadastrarCliente.Location = new Point(81, 21);
            labelCadastrarCliente.Name = "labelCadastrarCliente";
            labelCadastrarCliente.Size = new Size(227, 38);
            labelCadastrarCliente.TabIndex = 1;
            labelCadastrarCliente.Text = "Cadastrar Cliente";
            labelCadastrarCliente.Click += btnCadastroCliente_Click;
            // 
            // pictureBoxCadastrarCliente
            // 
            pictureBoxCadastrarCliente.Image = (Image)resources.GetObject("pictureBoxCadastrarCliente.Image");
            pictureBoxCadastrarCliente.Location = new Point(6, 9);
            pictureBoxCadastrarCliente.Name = "pictureBoxCadastrarCliente";
            pictureBoxCadastrarCliente.Size = new Size(69, 63);
            pictureBoxCadastrarCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastrarCliente.TabIndex = 0;
            pictureBoxCadastrarCliente.TabStop = false;
            pictureBoxCadastrarCliente.Click += btnCadastroCliente_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(32, 66);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(578, 39);
            textBoxPesquisa.TabIndex = 1;
            // 
            // barraLateralUserControlForm
            // 
            barraLateralUserControlForm.BackColor = Color.FromArgb(64, 65, 71);
            barraLateralUserControlForm.Location = new Point(-2, 0);
            barraLateralUserControlForm.Name = "barraLateralUserControlForm";
            barraLateralUserControlForm.Size = new Size(331, 1202);
            barraLateralUserControlForm.TabIndex = 2;
            // 
            // panelPrincipalInicio
            // 
            panelPrincipalInicio.Controls.Add(labelReultadosInicio);
            panelPrincipalInicio.Controls.Add(dataGridView1);
            panelPrincipalInicio.Location = new Point(375, 205);
            panelPrincipalInicio.Name = "panelPrincipalInicio";
            panelPrincipalInicio.Size = new Size(1879, 954);
            panelPrincipalInicio.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(39, 39, 41);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1830, 820);
            dataGridView1.TabIndex = 0;
            // 
            // labelReultadosInicio
            // 
            labelReultadosInicio.AutoSize = true;
            labelReultadosInicio.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelReultadosInicio.ForeColor = Color.GhostWhite;
            labelReultadosInicio.Location = new Point(848, 28);
            labelReultadosInicio.Name = "labelReultadosInicio";
            labelReultadosInicio.Size = new Size(142, 65);
            labelReultadosInicio.TabIndex = 1;
            labelReultadosInicio.Text = "Inicio";
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(2288, 1187);
            Controls.Add(panelPrincipalInicio);
            Controls.Add(barraLateralUserControlForm);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "PaginaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé";
            Load += PaginaPrincipalForm_Load;
            Resize += PaginaPrincipalForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCadastroSabor.ResumeLayout(false);
            panelCadastroSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroSabor).EndInit();
            panelCadastroFuncionario.ResumeLayout(false);
            panelCadastroFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCadastroIngrediente.ResumeLayout(false);
            panelCadastroIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroIngrediente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroCliente.ResumeLayout(false);
            panelCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarCliente).EndInit();
            panelPrincipalInicio.ResumeLayout(false);
            panelPrincipalInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BarraLateralUserControlForm barraLateralUserControlForm1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox textBoxPesquisa;
        private Panel panelCadastroFuncionario;
        private Label labelAdicionarFuncionario;
        private PictureBox pictureBox1;
        private BarraLateralUserControlForm barraLateralUserControlForm;
        private Panel panelCadastroCliente;
        private Label labelCadastrarCliente;
        private PictureBox pictureBoxCadastrarCliente;
        private Panel panelCadastroIngrediente;
        private Label labelCadastroIngrediente;
        private PictureBox pictureBoxCadastroIngrediente;
        private Panel panelCadastroSabor;
        private Label labelCadastroSabor;
        private PictureBox pictureBoxCadastroSabor;
        private Panel panelPrincipalInicio;
        private Label labelReultadosInicio;
        private DataGridView dataGridView1;
    }
}