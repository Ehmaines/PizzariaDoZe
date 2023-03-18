namespace PizzariaDoZe.UserControls
{
    partial class CadastrarFuncionarioUserControlForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFuncionarioUserControlForm));
            panel2 = new Panel();
            labelAdicionarFuncionario = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(114, 138, 244);
            panel2.Controls.Add(labelAdicionarFuncionario);
            panel2.Controls.Add(pictureBox1);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 79);
            panel2.TabIndex = 1;
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
            // 
            // CadastrarFuncionarioUserControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Name = "CadastrarFuncionarioUserControlForm";
            Size = new Size(384, 87);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label labelAdicionarFuncionario;
        private PictureBox pictureBox1;
    }
}
