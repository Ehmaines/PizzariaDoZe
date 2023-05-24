namespace PizzariaDoZe
{
    partial class ConfigurarBancoDeDadosForm
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
            buttonSalvarBanco = new Button();
            textBoxStringConnection = new TextBox();
            labelStringConnection = new Label();
            comboBoxProvider = new ComboBox();
            labelProvider = new Label();
            SuspendLayout();
            // 
            // buttonSalvarBanco
            // 
            buttonSalvarBanco.Location = new Point(564, 221);
            buttonSalvarBanco.Margin = new Padding(4, 4, 4, 4);
            buttonSalvarBanco.Name = "buttonSalvarBanco";
            buttonSalvarBanco.Size = new Size(118, 36);
            buttonSalvarBanco.TabIndex = 11;
            buttonSalvarBanco.Text = "Salvar";
            buttonSalvarBanco.UseVisualStyleBackColor = true;
            buttonSalvarBanco.Click += buttonSalvarBanco_Click;
            // 
            // textBoxStringConnection
            // 
            textBoxStringConnection.Location = new Point(46, 169);
            textBoxStringConnection.Margin = new Padding(4, 4, 4, 4);
            textBoxStringConnection.Name = "textBoxStringConnection";
            textBoxStringConnection.Size = new Size(634, 31);
            textBoxStringConnection.TabIndex = 10;
            // 
            // labelStringConnection
            // 
            labelStringConnection.AutoSize = true;
            labelStringConnection.ForeColor = Color.GhostWhite;
            labelStringConnection.Location = new Point(46, 140);
            labelStringConnection.Margin = new Padding(4, 0, 4, 0);
            labelStringConnection.Name = "labelStringConnection";
            labelStringConnection.Size = new Size(154, 25);
            labelStringConnection.TabIndex = 9;
            labelStringConnection.Text = "String de conexão";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "System.Data.SqlClient", "MySql.Data.MySqlClient" });
            comboBoxProvider.Location = new Point(46, 72);
            comboBoxProvider.Margin = new Padding(4, 4, 4, 4);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(216, 33);
            comboBoxProvider.TabIndex = 8;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.ForeColor = Color.GhostWhite;
            labelProvider.Location = new Point(46, 44);
            labelProvider.Margin = new Padding(4, 0, 4, 0);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(78, 25);
            labelProvider.TabIndex = 7;
            labelProvider.Text = "Provider";
            // 
            // ConfigurarBancoDeDadosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(710, 292);
            Controls.Add(buttonSalvarBanco);
            Controls.Add(textBoxStringConnection);
            Controls.Add(labelStringConnection);
            Controls.Add(comboBoxProvider);
            Controls.Add(labelProvider);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ConfigurarBancoDeDadosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar Banco de dados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonSalvarBanco;
        public TextBox textBoxStringConnection;
        private Label labelStringConnection;
        public ComboBox comboBoxProvider;
        private Label labelProvider;
    }
}