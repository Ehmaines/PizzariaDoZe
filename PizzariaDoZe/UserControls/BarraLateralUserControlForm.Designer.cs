namespace PizzariaDoZe
{
    partial class BarraLateralUserControlForm
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
            panelBarraLateral = new Panel();
            panelInicio = new Panel();
            labelInicio = new Label();
            panelFuncionario = new Panel();
            labelFuncionarios = new Label();
            panelClientes = new Panel();
            labelClientes = new Label();
            panelIngredientes = new Panel();
            labelIngredientes = new Label();
            panelSabores = new Panel();
            labelSabores = new Label();
            panelBarraLateral.SuspendLayout();
            panelInicio.SuspendLayout();
            panelFuncionario.SuspendLayout();
            panelClientes.SuspendLayout();
            panelIngredientes.SuspendLayout();
            panelSabores.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarraLateral
            // 
            panelBarraLateral.Controls.Add(panelSabores);
            panelBarraLateral.Controls.Add(panelIngredientes);
            panelBarraLateral.Controls.Add(panelClientes);
            panelBarraLateral.Controls.Add(panelFuncionario);
            panelBarraLateral.Controls.Add(panelInicio);
            panelBarraLateral.Location = new Point(3, 3);
            panelBarraLateral.Name = "panelBarraLateral";
            panelBarraLateral.Size = new Size(324, 1240);
            panelBarraLateral.TabIndex = 0;
            // 
            // panelInicio
            // 
            panelInicio.BackColor = Color.FromArgb(163, 184, 247);
            panelInicio.Controls.Add(labelInicio);
            panelInicio.Location = new Point(3, 424);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(318, 61);
            panelInicio.TabIndex = 0;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelInicio.ForeColor = Color.GhostWhite;
            labelInicio.Location = new Point(3, 12);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(83, 38);
            labelInicio.TabIndex = 0;
            labelInicio.Text = "Inicio";
            // 
            // panelFuncionario
            // 
            panelFuncionario.BackColor = Color.FromArgb(88, 95, 105);
            panelFuncionario.Controls.Add(labelFuncionarios);
            panelFuncionario.Location = new Point(3, 491);
            panelFuncionario.Name = "panelFuncionario";
            panelFuncionario.Size = new Size(318, 61);
            panelFuncionario.TabIndex = 1;
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFuncionarios.ForeColor = Color.GhostWhite;
            labelFuncionarios.Location = new Point(3, 11);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(174, 38);
            labelFuncionarios.TabIndex = 0;
            labelFuncionarios.Text = "Funcionários";
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.FromArgb(88, 95, 105);
            panelClientes.Controls.Add(labelClientes);
            panelClientes.Location = new Point(3, 558);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(318, 61);
            panelClientes.TabIndex = 2;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelClientes.ForeColor = Color.GhostWhite;
            labelClientes.Location = new Point(0, 11);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(115, 38);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Clientes";
            // 
            // panelIngredientes
            // 
            panelIngredientes.BackColor = Color.FromArgb(88, 95, 105);
            panelIngredientes.Controls.Add(labelIngredientes);
            panelIngredientes.Location = new Point(3, 625);
            panelIngredientes.Name = "panelIngredientes";
            panelIngredientes.Size = new Size(318, 61);
            panelIngredientes.TabIndex = 3;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngredientes.ForeColor = Color.GhostWhite;
            labelIngredientes.Location = new Point(0, 11);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(171, 38);
            labelIngredientes.TabIndex = 0;
            labelIngredientes.Text = "Ingredientes";
            // 
            // panelSabores
            // 
            panelSabores.BackColor = Color.FromArgb(88, 95, 105);
            panelSabores.Controls.Add(labelSabores);
            panelSabores.Location = new Point(3, 692);
            panelSabores.Name = "panelSabores";
            panelSabores.Size = new Size(318, 61);
            panelSabores.TabIndex = 4;
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSabores.ForeColor = Color.GhostWhite;
            labelSabores.Location = new Point(3, 11);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(115, 38);
            labelSabores.TabIndex = 0;
            labelSabores.Text = "Sabores";
            // 
            // BarraLateralUserControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 65, 71);
            Controls.Add(panelBarraLateral);
            Name = "BarraLateralUserControlForm";
            Size = new Size(327, 1243);
            panelBarraLateral.ResumeLayout(false);
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            panelFuncionario.ResumeLayout(false);
            panelFuncionario.PerformLayout();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            panelIngredientes.ResumeLayout(false);
            panelIngredientes.PerformLayout();
            panelSabores.ResumeLayout(false);
            panelSabores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraLateral;
        public Panel panelFuncionario;
        public Label labelFuncionarios;
        public Panel panelClientes;
        public Label labelClientes;
        public Panel panelSabores;
        public Label labelSabores;
        public Panel panelIngredientes;
        public Label labelIngredientes;
        public Panel panelInicio;
        public Label labelInicio;
    }
}
