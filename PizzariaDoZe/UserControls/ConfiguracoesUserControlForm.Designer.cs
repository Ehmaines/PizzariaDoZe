namespace PizzariaDoZe.UserControls
{
    partial class ConfiguracoesUserControlForm
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
            tabControl1 = new TabControl();
            tabPageIdiomaRegiao = new TabPage();
            buttonSalvarIdioma = new Button();
            checkBoxReniciarAplicacaoConfig = new CheckBox();
            comboBoxIdioma = new ComboBox();
            labelIdiomaRegiao = new Label();
            tabControl1.SuspendLayout();
            tabPageIdiomaRegiao.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageIdiomaRegiao);
            tabControl1.Location = new Point(17, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(558, 258);
            tabControl1.TabIndex = 0;
            // 
            // tabPageIdiomaRegiao
            // 
            tabPageIdiomaRegiao.BackColor = Color.FromArgb(39, 39, 41);
            tabPageIdiomaRegiao.Controls.Add(buttonSalvarIdioma);
            tabPageIdiomaRegiao.Controls.Add(checkBoxReniciarAplicacaoConfig);
            tabPageIdiomaRegiao.Controls.Add(comboBoxIdioma);
            tabPageIdiomaRegiao.Controls.Add(labelIdiomaRegiao);
            tabPageIdiomaRegiao.Location = new Point(4, 29);
            tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            tabPageIdiomaRegiao.Padding = new Padding(3);
            tabPageIdiomaRegiao.Size = new Size(550, 225);
            tabPageIdiomaRegiao.TabIndex = 0;
            tabPageIdiomaRegiao.Text = "Idioma / Região";
            // 
            // buttonSalvarIdioma
            // 
            buttonSalvarIdioma.Location = new Point(450, 190);
            buttonSalvarIdioma.Name = "buttonSalvarIdioma";
            buttonSalvarIdioma.Size = new Size(94, 29);
            buttonSalvarIdioma.TabIndex = 3;
            buttonSalvarIdioma.Text = "Salvar";
            buttonSalvarIdioma.UseVisualStyleBackColor = true;
            // 
            // checkBoxReniciarAplicacaoConfig
            // 
            checkBoxReniciarAplicacaoConfig.AutoSize = true;
            checkBoxReniciarAplicacaoConfig.ForeColor = Color.GhostWhite;
            checkBoxReniciarAplicacaoConfig.Location = new Point(16, 68);
            checkBoxReniciarAplicacaoConfig.Name = "checkBoxReniciarAplicacaoConfig";
            checkBoxReniciarAplicacaoConfig.Size = new Size(290, 24);
            checkBoxReniciarAplicacaoConfig.TabIndex = 2;
            checkBoxReniciarAplicacaoConfig.Text = "Reiniciar aplicação para aplicar idioma";
            checkBoxReniciarAplicacaoConfig.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(16, 34);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(117, 28);
            comboBoxIdioma.TabIndex = 1;
            // 
            // labelIdiomaRegiao
            // 
            labelIdiomaRegiao.AutoSize = true;
            labelIdiomaRegiao.ForeColor = Color.GhostWhite;
            labelIdiomaRegiao.Location = new Point(16, 11);
            labelIdiomaRegiao.Name = "labelIdiomaRegiao";
            labelIdiomaRegiao.Size = new Size(117, 20);
            labelIdiomaRegiao.TabIndex = 0;
            labelIdiomaRegiao.Text = "Idioma / Região";
            // 
            // ConfiguracoesUserControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            Controls.Add(tabControl1);
            Name = "ConfiguracoesUserControlForm";
            Size = new Size(584, 300);
            tabControl1.ResumeLayout(false);
            tabPageIdiomaRegiao.ResumeLayout(false);
            tabPageIdiomaRegiao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageIdiomaRegiao;
        private Label labelIdiomaRegiao;
        public TabControl tabControl1;
        public ComboBox comboBoxIdioma;
        public CheckBox checkBoxReniciarAplicacaoConfig;
        public Button buttonSalvarIdioma;
    }
}
