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
            panel2 = new Panel();
            labelAdicionarFuncionario = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            barraLateralUserControlForm2 = new BarraLateralUserControlForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 25, 41);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
            panel1.ForeColor = Color.GhostWhite;
            panel1.Location = new Point(323, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1966, 171);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(114, 138, 244);
            panel2.Controls.Add(labelAdicionarFuncionario);
            panel2.Controls.Add(pictureBox1);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(1564, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 79);
            panel2.TabIndex = 4;
            panel2.Click += btnCadastroFuncionario_Click;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(616, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(32, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 39);
            textBox1.TabIndex = 1;
            // 
            // barraLateralUserControlForm2
            // 
            barraLateralUserControlForm2.BackColor = Color.FromArgb(64, 65, 71);
            barraLateralUserControlForm2.Location = new Point(-2, 0);
            barraLateralUserControlForm2.Name = "barraLateralUserControlForm2";
            barraLateralUserControlForm2.Size = new Size(331, 1202);
            barraLateralUserControlForm2.TabIndex = 2;
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(2288, 1187);
            Controls.Add(barraLateralUserControlForm2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "PaginaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Principal";
            Load += PaginaPrincipalForm_Load;
            Resize += PaginaPrincipalForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BarraLateralUserControlForm barraLateralUserControlForm1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Label labelAdicionarFuncionario;
        private PictureBox pictureBox1;
        private BarraLateralUserControlForm barraLateralUserControlForm2;
    }
}