namespace PizzariaDoZe
{
    partial class SaveCloseUserControlForm
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            panelBtnCancelarSalvar = new Panel();
            panelBtnCancelarSalvar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(114, 138, 244);
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.FlatAppearance.BorderColor = Color.GhostWhite;
            btnSalvar.Location = new Point(113, 5);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 25);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(114, 138, 244);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.GhostWhite;
            btnCancelar.Location = new Point(7, 4);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 25);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panelBtnCancelarSalvar
            // 
            panelBtnCancelarSalvar.Controls.Add(btnCancelar);
            panelBtnCancelarSalvar.Controls.Add(btnSalvar);
            panelBtnCancelarSalvar.Location = new Point(3, 3);
            panelBtnCancelarSalvar.Name = "panelBtnCancelarSalvar";
            panelBtnCancelarSalvar.Size = new Size(218, 32);
            panelBtnCancelarSalvar.TabIndex = 34;
            // 
            // SaveCloseUserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            Controls.Add(panelBtnCancelarSalvar);
            Name = "SaveCloseUserControlForm";
            Size = new Size(227, 43);
            panelBtnCancelarSalvar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Button btnSalvar;
        public Button btnCancelar;
        public Panel panelBtnCancelarSalvar;
    }
}
