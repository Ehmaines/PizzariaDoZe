namespace PizzariaDoZe
{
    partial class EnderecoUserControlForm
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
            panelCadastroFuncionarioGeral = new Panel();
            textBoxId = new TextBox();
            labelId = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            labelEndereco = new Label();
            labelPais = new Label();
            textBoxPais = new TextBox();
            labelEstado = new Label();
            textBoxEstado = new TextBox();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            labelBairro = new Label();
            textBoxBairro = new TextBox();
            labelComplemento = new Label();
            textBoxComplemento = new TextBox();
            labelNumero = new Label();
            textBoxNumeroCasa = new TextBox();
            labelLogradouro = new Label();
            textBoxRua = new TextBox();
            labelCEP = new Label();
            panelCadastroFuncionarioGeral.SuspendLayout();
            SuspendLayout();
            // 
            // panelCadastroFuncionarioGeral
            // 
            panelCadastroFuncionarioGeral.Controls.Add(textBoxId);
            panelCadastroFuncionarioGeral.Controls.Add(labelId);
            panelCadastroFuncionarioGeral.Controls.Add(maskedTextBoxCEP);
            panelCadastroFuncionarioGeral.Controls.Add(labelEndereco);
            panelCadastroFuncionarioGeral.Controls.Add(labelPais);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxPais);
            panelCadastroFuncionarioGeral.Controls.Add(labelEstado);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxEstado);
            panelCadastroFuncionarioGeral.Controls.Add(labelCidade);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxCidade);
            panelCadastroFuncionarioGeral.Controls.Add(labelBairro);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxBairro);
            panelCadastroFuncionarioGeral.Controls.Add(labelComplemento);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxComplemento);
            panelCadastroFuncionarioGeral.Controls.Add(labelNumero);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxNumeroCasa);
            panelCadastroFuncionarioGeral.Controls.Add(labelLogradouro);
            panelCadastroFuncionarioGeral.Controls.Add(textBoxRua);
            panelCadastroFuncionarioGeral.Controls.Add(labelCEP);
            panelCadastroFuncionarioGeral.Location = new Point(6, 2);
            panelCadastroFuncionarioGeral.Margin = new Padding(2);
            panelCadastroFuncionarioGeral.Name = "panelCadastroFuncionarioGeral";
            panelCadastroFuncionarioGeral.Size = new Size(366, 818);
            panelCadastroFuncionarioGeral.TabIndex = 9;
            // 
            // textBoxId
            // 
            textBoxId.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxId.Location = new Point(31, 95);
            textBoxId.Margin = new Padding(4);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(87, 31);
            textBoxId.TabIndex = 44;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.ForeColor = Color.GhostWhite;
            labelId.Location = new Point(34, 59);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(54, 32);
            labelId.TabIndex = 43;
            labelId.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(31, 165);
            maskedTextBoxCEP.Mask = "00000\\-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(312, 31);
            maskedTextBoxCEP.TabIndex = 26;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereco.ForeColor = Color.GhostWhite;
            labelEndereco.Location = new Point(112, 16);
            labelEndereco.Margin = new Padding(2, 0, 2, 0);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(152, 45);
            labelEndereco.TabIndex = 41;
            labelEndereco.Text = "Endereço";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPais.ForeColor = Color.GhostWhite;
            labelPais.Location = new Point(34, 716);
            labelPais.Margin = new Padding(2, 0, 2, 0);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(54, 32);
            labelPais.TabIndex = 40;
            labelPais.Text = "País";
            // 
            // textBoxPais
            // 
            textBoxPais.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxPais.Location = new Point(31, 752);
            textBoxPais.Margin = new Padding(4);
            textBoxPais.MaxLength = 20;
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(312, 31);
            textBoxPais.TabIndex = 39;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEstado.ForeColor = Color.GhostWhite;
            labelEstado.Location = new Point(34, 634);
            labelEstado.Margin = new Padding(2, 0, 2, 0);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(84, 32);
            labelEstado.TabIndex = 38;
            labelEstado.Text = "Estado";
            // 
            // textBoxEstado
            // 
            textBoxEstado.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxEstado.Location = new Point(31, 670);
            textBoxEstado.Margin = new Padding(4);
            textBoxEstado.MaxLength = 20;
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(312, 31);
            textBoxEstado.TabIndex = 37;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCidade.ForeColor = Color.GhostWhite;
            labelCidade.Location = new Point(34, 548);
            labelCidade.Margin = new Padding(2, 0, 2, 0);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(88, 32);
            labelCidade.TabIndex = 36;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxCidade.Location = new Point(31, 584);
            textBoxCidade.Margin = new Padding(4);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(312, 31);
            textBoxCidade.TabIndex = 35;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBairro.ForeColor = Color.GhostWhite;
            labelBairro.Location = new Point(34, 469);
            labelBairro.Margin = new Padding(2, 0, 2, 0);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(76, 32);
            labelBairro.TabIndex = 34;
            labelBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            textBoxBairro.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxBairro.Location = new Point(31, 506);
            textBoxBairro.Margin = new Padding(4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(312, 31);
            textBoxBairro.TabIndex = 33;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelComplemento.ForeColor = Color.GhostWhite;
            labelComplemento.Location = new Point(34, 386);
            labelComplemento.Margin = new Padding(2, 0, 2, 0);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(167, 32);
            labelComplemento.TabIndex = 32;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxComplemento.Location = new Point(31, 420);
            textBoxComplemento.Margin = new Padding(4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(312, 31);
            textBoxComplemento.TabIndex = 31;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.ForeColor = Color.GhostWhite;
            labelNumero.Location = new Point(34, 292);
            labelNumero.Margin = new Padding(2, 0, 2, 0);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(102, 32);
            labelNumero.TabIndex = 30;
            labelNumero.Text = "Número";
            // 
            // textBoxNumeroCasa
            // 
            textBoxNumeroCasa.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxNumeroCasa.Location = new Point(31, 328);
            textBoxNumeroCasa.Margin = new Padding(4);
            textBoxNumeroCasa.Name = "textBoxNumeroCasa";
            textBoxNumeroCasa.Size = new Size(312, 31);
            textBoxNumeroCasa.TabIndex = 29;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogradouro.ForeColor = Color.GhostWhite;
            labelLogradouro.Location = new Point(34, 212);
            labelLogradouro.Margin = new Padding(2, 0, 2, 0);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(137, 32);
            labelLogradouro.TabIndex = 28;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxRua
            // 
            textBoxRua.ForeColor = Color.FromArgb(39, 39, 41);
            textBoxRua.Location = new Point(31, 248);
            textBoxRua.Margin = new Padding(4);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(312, 31);
            textBoxRua.TabIndex = 27;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCEP.ForeColor = Color.GhostWhite;
            labelCEP.Location = new Point(34, 130);
            labelCEP.Margin = new Padding(2, 0, 2, 0);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(54, 32);
            labelCEP.TabIndex = 26;
            labelCEP.Text = "CEP";
            // 
            // EnderecoUserControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            Controls.Add(panelCadastroFuncionarioGeral);
            Margin = new Padding(2);
            Name = "EnderecoUserControlForm";
            Size = new Size(372, 828);
            panelCadastroFuncionarioGeral.ResumeLayout(false);
            panelCadastroFuncionarioGeral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelEndereco;
        private Label labelPais;
        private Label labelEstado;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelLogradouro;
        private Label labelCEP;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxPais;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxEstado;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxCidade;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxBairro;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxComplemento;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxNumeroCasa;
        /// <summary>
        /// 
        /// </summary>
        public TextBox textBoxRua;
        public Panel panelCadastroFuncionarioGeral;
        public TextBox textBoxId;
        private Label labelId;
        public MaskedTextBox maskedTextBoxCEP;
    }
}
