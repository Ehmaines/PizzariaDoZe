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
            tabControlConfiguracoes = new TabControl();
            tabPageIdiomaRegiao = new TabPage();
            btnSalvar = new Button();
            checkBoxReniciarAplicacaoConfig = new CheckBox();
            comboBoxIdioma = new ComboBox();
            labelIdiomaRegiao = new Label();
            tabControlConfiguracoes.SuspendLayout();
            tabPageIdiomaRegiao.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlConfiguracoes
            // 
            tabControlConfiguracoes.Controls.Add(tabPageIdiomaRegiao);
            tabControlConfiguracoes.Location = new Point(21, 25);
            tabControlConfiguracoes.Margin = new Padding(4);
            tabControlConfiguracoes.Name = "tabControlConfiguracoes";
            tabControlConfiguracoes.SelectedIndex = 0;
            tabControlConfiguracoes.Size = new Size(698, 322);
            tabControlConfiguracoes.TabIndex = 0;
            // 
            // tabPageIdiomaRegiao
            // 
            tabPageIdiomaRegiao.BackColor = Color.FromArgb(39, 39, 41);
            tabPageIdiomaRegiao.Controls.Add(btnSalvar);
            tabPageIdiomaRegiao.Controls.Add(checkBoxReniciarAplicacaoConfig);
            tabPageIdiomaRegiao.Controls.Add(comboBoxIdioma);
            tabPageIdiomaRegiao.Controls.Add(labelIdiomaRegiao);
            tabPageIdiomaRegiao.Location = new Point(4, 34);
            tabPageIdiomaRegiao.Margin = new Padding(4);
            tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            tabPageIdiomaRegiao.Padding = new Padding(4);
            tabPageIdiomaRegiao.Size = new Size(690, 284);
            tabPageIdiomaRegiao.TabIndex = 0;
            tabPageIdiomaRegiao.Text = "Idioma / Região";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(562, 238);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 36);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // checkBoxReniciarAplicacaoConfig
            // 
            checkBoxReniciarAplicacaoConfig.AutoSize = true;
            checkBoxReniciarAplicacaoConfig.ForeColor = Color.GhostWhite;
            checkBoxReniciarAplicacaoConfig.Location = new Point(20, 85);
            checkBoxReniciarAplicacaoConfig.Margin = new Padding(4);
            checkBoxReniciarAplicacaoConfig.Name = "checkBoxReniciarAplicacaoConfig";
            checkBoxReniciarAplicacaoConfig.Size = new Size(336, 29);
            checkBoxReniciarAplicacaoConfig.TabIndex = 2;
            checkBoxReniciarAplicacaoConfig.Text = "Reiniciar aplicação para aplicar idioma";
            checkBoxReniciarAplicacaoConfig.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(20, 42);
            comboBoxIdioma.Margin = new Padding(4);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(145, 33);
            comboBoxIdioma.TabIndex = 1;
            // 
            // labelIdiomaRegiao
            // 
            labelIdiomaRegiao.AutoSize = true;
            labelIdiomaRegiao.ForeColor = Color.GhostWhite;
            labelIdiomaRegiao.Location = new Point(20, 14);
            labelIdiomaRegiao.Margin = new Padding(4, 0, 4, 0);
            labelIdiomaRegiao.Name = "labelIdiomaRegiao";
            labelIdiomaRegiao.Size = new Size(139, 25);
            labelIdiomaRegiao.TabIndex = 0;
            labelIdiomaRegiao.Text = "Idioma / Região";
            // 
            // ConfiguracoesUserControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            Controls.Add(tabControlConfiguracoes);
            Margin = new Padding(4);
            Name = "ConfiguracoesUserControlForm";
            Size = new Size(730, 375);
            tabControlConfiguracoes.ResumeLayout(false);
            tabPageIdiomaRegiao.ResumeLayout(false);
            tabPageIdiomaRegiao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageIdiomaRegiao;
        private Label labelIdiomaRegiao;
        /// <summary>
        /// tabControl1
        /// </summary>
        public TabControl tabControlConfiguracoes;
        /// <summary>
        /// comboBoxIdioma
        /// </summary>
        public ComboBox comboBoxIdioma;
        /// <summary>
        /// checkBoxReniciarAplicacaoConfig
        /// </summary>
        public CheckBox checkBoxReniciarAplicacaoConfig;
        /// <summary>
        /// buttonSalvarIdioma
        /// </summary>
        public Button btnSalvar;
    }
}
