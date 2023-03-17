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
            panelBarraLateral.SuspendLayout();
            panelInicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarraLateral
            // 
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
            panelInicio.Location = new Point(3, 265);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(318, 61);
            panelInicio.TabIndex = 0;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelInicio.ForeColor = Color.GhostWhite;
            labelInicio.Location = new Point(105, 11);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(83, 38);
            labelInicio.TabIndex = 0;
            labelInicio.Text = "Inicio";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraLateral;
        private Panel panelInicio;
        private Label labelInicio;
    }
}
