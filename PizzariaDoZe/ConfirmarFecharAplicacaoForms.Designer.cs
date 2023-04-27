namespace PizzariaDoZe
{
    partial class ConfirmarFecharAplicacaoForms
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
            labelConfirmarFecharAplicacao = new Label();
            buttonCancelar = new Button();
            buttonEnviarBandeja = new Button();
            buttonFechar = new Button();
            SuspendLayout();
            // 
            // labelConfirmarFecharAplicacao
            // 
            labelConfirmarFecharAplicacao.AutoSize = true;
            labelConfirmarFecharAplicacao.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelConfirmarFecharAplicacao.ForeColor = Color.GhostWhite;
            labelConfirmarFecharAplicacao.Location = new Point(29, 29);
            labelConfirmarFecharAplicacao.Margin = new Padding(2, 0, 2, 0);
            labelConfirmarFecharAplicacao.Name = "labelConfirmarFecharAplicacao";
            labelConfirmarFecharAplicacao.Size = new Size(505, 45);
            labelConfirmarFecharAplicacao.TabIndex = 37;
            labelConfirmarFecharAplicacao.Text = "Deseja mesmo fechar a aplicação?";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(114, 138, 244);
            buttonCancelar.Location = new Point(29, 114);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 34);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEnviarBandeja
            // 
            buttonEnviarBandeja.BackColor = Color.FromArgb(114, 138, 244);
            buttonEnviarBandeja.Location = new Point(161, 114);
            buttonEnviarBandeja.Name = "buttonEnviarBandeja";
            buttonEnviarBandeja.Size = new Size(188, 34);
            buttonEnviarBandeja.TabIndex = 39;
            buttonEnviarBandeja.Text = "Enviar para bandeja";
            buttonEnviarBandeja.UseVisualStyleBackColor = false;
            buttonEnviarBandeja.Click += buttonMinimizar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.FromArgb(114, 138, 244);
            buttonFechar.Location = new Point(369, 114);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(164, 34);
            buttonFechar.TabIndex = 40;
            buttonFechar.Text = "Fechar aplicação";
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // ConfirmarFecharAplicacaoForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(565, 167);
            Controls.Add(buttonFechar);
            Controls.Add(buttonEnviarBandeja);
            Controls.Add(buttonCancelar);
            Controls.Add(labelConfirmarFecharAplicacao);
            Name = "ConfirmarFecharAplicacaoForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmarFecharAplicacaoForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelConfirmarFecharAplicacao;
        private Button buttonCancelar;
        private Button buttonEnviarBandeja;
        private Button buttonFechar;
    }
}