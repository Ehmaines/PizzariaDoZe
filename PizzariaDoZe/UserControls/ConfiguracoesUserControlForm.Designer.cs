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
            tabPageDataBase = new TabPage();
            buttonConfigurarBanco = new Button();
            tabControlConfiguracoes.SuspendLayout();
            tabPageIdiomaRegiao.SuspendLayout();
            tabPageDataBase.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlConfiguracoes
            // 
            tabControlConfiguracoes.Controls.Add(tabPageIdiomaRegiao);
            tabControlConfiguracoes.Controls.Add(tabPageDataBase);
            tabControlConfiguracoes.Location = new Point(17, 20);
            tabControlConfiguracoes.Name = "tabControlConfiguracoes";
            tabControlConfiguracoes.SelectedIndex = 0;
            tabControlConfiguracoes.Size = new Size(564, 232);
            tabControlConfiguracoes.TabIndex = 0;
            // 
            // tabPageIdiomaRegiao
            // 
            tabPageIdiomaRegiao.BackColor = Color.FromArgb(39, 39, 41);
            tabPageIdiomaRegiao.Controls.Add(btnSalvar);
            tabPageIdiomaRegiao.Controls.Add(checkBoxReniciarAplicacaoConfig);
            tabPageIdiomaRegiao.Controls.Add(comboBoxIdioma);
            tabPageIdiomaRegiao.Controls.Add(labelIdiomaRegiao);
            tabPageIdiomaRegiao.Location = new Point(4, 29);
            tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            tabPageIdiomaRegiao.Padding = new Padding(3);
            tabPageIdiomaRegiao.Size = new Size(556, 199);
            tabPageIdiomaRegiao.TabIndex = 0;
            tabPageIdiomaRegiao.Text = "Idioma / Região";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(440, 164);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
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
            // tabPageDataBase
            // 
            tabPageDataBase.BackColor = Color.FromArgb(39, 39, 41);
            tabPageDataBase.Controls.Add(buttonConfigurarBanco);
            tabPageDataBase.Location = new Point(4, 29);
            tabPageDataBase.Name = "tabPageDataBase";
            tabPageDataBase.Size = new Size(556, 199);
            tabPageDataBase.TabIndex = 1;
            tabPageDataBase.Text = "Banco de dados";
            // 
            // buttonConfigurarBanco
            // 
            buttonConfigurarBanco.Location = new Point(128, 60);
            buttonConfigurarBanco.Name = "buttonConfigurarBanco";
            buttonConfigurarBanco.Size = new Size(239, 67);
            buttonConfigurarBanco.TabIndex = 6;
            buttonConfigurarBanco.Text = "Configurar Banco de dados";
            buttonConfigurarBanco.UseVisualStyleBackColor = true;
            // 
            // ConfiguracoesUserControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            Controls.Add(tabControlConfiguracoes);
            Name = "ConfiguracoesUserControlForm";
            Size = new Size(584, 300);
            tabControlConfiguracoes.ResumeLayout(false);
            tabPageIdiomaRegiao.ResumeLayout(false);
            tabPageIdiomaRegiao.PerformLayout();
            tabPageDataBase.ResumeLayout(false);
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
        private TabPage tabPageDataBase;
        public ComboBox comboBoxProvider;
        private Label labelProvider;
        private Label labelStringConnection;
        public TextBox textBoxStringConnection;
        public Button buttonConfigurarBanco;
    }
}
