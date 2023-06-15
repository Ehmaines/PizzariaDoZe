namespace PizzariaDoZe
{
    partial class PaginaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipalForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panelCadastroProduto = new Panel();
            labelCadastrarProduto = new Label();
            pictureBoxCadastroProduto = new PictureBox();
            panelCadastroValor = new Panel();
            labelCadastrarValor = new Label();
            pictureBoxCadastroValor = new PictureBox();
            panelCadastroSabor = new Panel();
            labelCadastrarSabor = new Label();
            pictureBoxCadastroSabor = new PictureBox();
            panelCadastroFuncionario = new Panel();
            labelCadastrarFuncionario = new Label();
            pictureBoxCadastrarProduto = new PictureBox();
            panelCadastroIngrediente = new Panel();
            labelCadastrarIngrediente = new Label();
            pictureBoxCadastroIngrediente = new PictureBox();
            pictureBox2 = new PictureBox();
            panelCadastroCliente = new Panel();
            labelCadastrarCliente = new Label();
            pictureBoxCadastrarCliente = new PictureBox();
            textBoxPesquisa = new TextBox();
            barraLateralUserControlForm = new BarraLateralUserControlForm();
            configuracoesUserControlForm = new UserControls.ConfiguracoesUserControlForm();
            contextMenuStripGeral = new ContextMenuStrip(components);
            inicioToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            enderecoToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            configuracoesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemStray = new ContextMenuStrip(components);
            abrirAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewDados = new DataGridView();
            panel1.SuspendLayout();
            panelCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroProduto).BeginInit();
            panelCadastroValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroValor).BeginInit();
            panelCadastroSabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroSabor).BeginInit();
            panelCadastroFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarProduto).BeginInit();
            panelCadastroIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroIngrediente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarCliente).BeginInit();
            contextMenuStripGeral.SuspendLayout();
            contextMenuStripSystemStray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 25, 41);
            panel1.Controls.Add(panelCadastroValor);
            panel1.Controls.Add(panelCadastroSabor);
            panel1.Controls.Add(panelCadastroFuncionario);
            panel1.Controls.Add(panelCadastroIngrediente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panelCadastroCliente);
            panel1.Controls.Add(textBoxPesquisa);
            panel1.Controls.Add(panelCadastroProduto);
            panel1.ForeColor = Color.GhostWhite;
            panel1.Location = new Point(227, 0);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 103);
            panel1.TabIndex = 1;
            // 
            // panelCadastroProduto
            // 
            panelCadastroProduto.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroProduto.Controls.Add(labelCadastrarProduto);
            panelCadastroProduto.Controls.Add(pictureBoxCadastroProduto);
            panelCadastroProduto.Cursor = Cursors.Hand;
            panelCadastroProduto.Location = new Point(809, 23);
            panelCadastroProduto.Margin = new Padding(1, 1, 1, 1);
            panelCadastroProduto.Name = "panelCadastroProduto";
            panelCadastroProduto.Size = new Size(260, 47);
            panelCadastroProduto.TabIndex = 8;
            panelCadastroProduto.Click += btnCadastroProdutos_Click;
            // 
            // labelCadastrarProduto
            // 
            labelCadastrarProduto.AutoSize = true;
            labelCadastrarProduto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarProduto.ForeColor = Color.GhostWhite;
            labelCadastrarProduto.Location = new Point(57, 13);
            labelCadastrarProduto.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarProduto.Name = "labelCadastrarProduto";
            labelCadastrarProduto.Size = new Size(166, 25);
            labelCadastrarProduto.TabIndex = 1;
            labelCadastrarProduto.Text = "Cadastrar Produto";
            labelCadastrarProduto.Click += btnCadastroProdutos_Click;
            // 
            // pictureBoxCadastroProduto
            // 
            pictureBoxCadastroProduto.Image = (Image)resources.GetObject("pictureBoxCadastroProduto.Image");
            pictureBoxCadastroProduto.Location = new Point(4, 5);
            pictureBoxCadastroProduto.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastroProduto.Name = "pictureBoxCadastroProduto";
            pictureBoxCadastroProduto.Size = new Size(48, 37);
            pictureBoxCadastroProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroProduto.TabIndex = 0;
            pictureBoxCadastroProduto.TabStop = false;
            pictureBoxCadastroProduto.Click += btnCadastroProdutos_Click;
            // 
            // panelCadastroValor
            // 
            panelCadastroValor.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroValor.Controls.Add(labelCadastrarValor);
            panelCadastroValor.Controls.Add(pictureBoxCadastroValor);
            panelCadastroValor.Cursor = Cursors.Hand;
            panelCadastroValor.Location = new Point(809, 23);
            panelCadastroValor.Margin = new Padding(1, 1, 1, 1);
            panelCadastroValor.Name = "panelCadastroValor";
            panelCadastroValor.Size = new Size(260, 47);
            panelCadastroValor.TabIndex = 7;
            panelCadastroValor.Click += btnCadastroValores_Click;
            // 
            // labelCadastrarValor
            // 
            labelCadastrarValor.AutoSize = true;
            labelCadastrarValor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarValor.ForeColor = Color.GhostWhite;
            labelCadastrarValor.Location = new Point(57, 13);
            labelCadastrarValor.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarValor.Name = "labelCadastrarValor";
            labelCadastrarValor.Size = new Size(142, 25);
            labelCadastrarValor.TabIndex = 1;
            labelCadastrarValor.Text = "Cadastrar Valor";
            labelCadastrarValor.Click += btnCadastroValores_Click;
            // 
            // pictureBoxCadastroValor
            // 
            pictureBoxCadastroValor.Image = (Image)resources.GetObject("pictureBoxCadastroValor.Image");
            pictureBoxCadastroValor.Location = new Point(4, 5);
            pictureBoxCadastroValor.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastroValor.Name = "pictureBoxCadastroValor";
            pictureBoxCadastroValor.Size = new Size(48, 37);
            pictureBoxCadastroValor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroValor.TabIndex = 0;
            pictureBoxCadastroValor.TabStop = false;
            pictureBoxCadastroValor.Click += btnCadastroValores_Click;
            // 
            // panelCadastroSabor
            // 
            panelCadastroSabor.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroSabor.Controls.Add(labelCadastrarSabor);
            panelCadastroSabor.Controls.Add(pictureBoxCadastroSabor);
            panelCadastroSabor.Cursor = Cursors.Hand;
            panelCadastroSabor.Location = new Point(809, 23);
            panelCadastroSabor.Margin = new Padding(1, 1, 1, 1);
            panelCadastroSabor.Name = "panelCadastroSabor";
            panelCadastroSabor.Size = new Size(260, 47);
            panelCadastroSabor.TabIndex = 6;
            panelCadastroSabor.Click += btnCadastroSabores_Click;
            // 
            // labelCadastrarSabor
            // 
            labelCadastrarSabor.AutoSize = true;
            labelCadastrarSabor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarSabor.ForeColor = Color.GhostWhite;
            labelCadastrarSabor.Location = new Point(57, 13);
            labelCadastrarSabor.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarSabor.Name = "labelCadastrarSabor";
            labelCadastrarSabor.Size = new Size(147, 25);
            labelCadastrarSabor.TabIndex = 1;
            labelCadastrarSabor.Text = "Cadastrar Sabor";
            labelCadastrarSabor.Click += btnCadastroSabores_Click;
            // 
            // pictureBoxCadastroSabor
            // 
            pictureBoxCadastroSabor.Image = (Image)resources.GetObject("pictureBoxCadastroSabor.Image");
            pictureBoxCadastroSabor.Location = new Point(4, 5);
            pictureBoxCadastroSabor.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastroSabor.Name = "pictureBoxCadastroSabor";
            pictureBoxCadastroSabor.Size = new Size(48, 37);
            pictureBoxCadastroSabor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroSabor.TabIndex = 0;
            pictureBoxCadastroSabor.TabStop = false;
            pictureBoxCadastroSabor.Click += btnCadastroSabores_Click;
            // 
            // panelCadastroFuncionario
            // 
            panelCadastroFuncionario.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroFuncionario.Controls.Add(labelCadastrarFuncionario);
            panelCadastroFuncionario.Controls.Add(pictureBoxCadastrarProduto);
            panelCadastroFuncionario.Cursor = Cursors.Hand;
            panelCadastroFuncionario.Location = new Point(809, 23);
            panelCadastroFuncionario.Margin = new Padding(1, 1, 1, 1);
            panelCadastroFuncionario.Name = "panelCadastroFuncionario";
            panelCadastroFuncionario.Size = new Size(260, 47);
            panelCadastroFuncionario.TabIndex = 4;
            panelCadastroFuncionario.Click += btnCadastroFuncionario_Click;
            // 
            // labelCadastrarFuncionario
            // 
            labelCadastrarFuncionario.AutoSize = true;
            labelCadastrarFuncionario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarFuncionario.ForeColor = Color.GhostWhite;
            labelCadastrarFuncionario.Location = new Point(57, 13);
            labelCadastrarFuncionario.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarFuncionario.Name = "labelCadastrarFuncionario";
            labelCadastrarFuncionario.Size = new Size(198, 25);
            labelCadastrarFuncionario.TabIndex = 1;
            labelCadastrarFuncionario.Text = "Cadastrar Funcionário";
            labelCadastrarFuncionario.Click += btnCadastroFuncionario_Click;
            // 
            // pictureBoxCadastrarProduto
            // 
            pictureBoxCadastrarProduto.Image = (Image)resources.GetObject("pictureBoxCadastrarProduto.Image");
            pictureBoxCadastrarProduto.Location = new Point(4, 5);
            pictureBoxCadastrarProduto.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastrarProduto.Name = "pictureBoxCadastrarProduto";
            pictureBoxCadastrarProduto.Size = new Size(48, 37);
            pictureBoxCadastrarProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastrarProduto.TabIndex = 0;
            pictureBoxCadastrarProduto.TabStop = false;
            pictureBoxCadastrarProduto.Click += btnCadastroFuncionario_Click;
            // 
            // panelCadastroIngrediente
            // 
            panelCadastroIngrediente.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroIngrediente.Controls.Add(labelCadastrarIngrediente);
            panelCadastroIngrediente.Controls.Add(pictureBoxCadastroIngrediente);
            panelCadastroIngrediente.Cursor = Cursors.Hand;
            panelCadastroIngrediente.Location = new Point(809, 23);
            panelCadastroIngrediente.Margin = new Padding(1, 1, 1, 1);
            panelCadastroIngrediente.Name = "panelCadastroIngrediente";
            panelCadastroIngrediente.Size = new Size(260, 47);
            panelCadastroIngrediente.TabIndex = 6;
            panelCadastroIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // labelCadastrarIngrediente
            // 
            labelCadastrarIngrediente.AutoSize = true;
            labelCadastrarIngrediente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarIngrediente.ForeColor = Color.GhostWhite;
            labelCadastrarIngrediente.Location = new Point(57, 13);
            labelCadastrarIngrediente.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarIngrediente.Name = "labelCadastrarIngrediente";
            labelCadastrarIngrediente.Size = new Size(203, 25);
            labelCadastrarIngrediente.TabIndex = 1;
            labelCadastrarIngrediente.Text = "Cadastrar Ingredientes";
            labelCadastrarIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // pictureBoxCadastroIngrediente
            // 
            pictureBoxCadastroIngrediente.Image = (Image)resources.GetObject("pictureBoxCadastroIngrediente.Image");
            pictureBoxCadastroIngrediente.Location = new Point(4, 5);
            pictureBoxCadastroIngrediente.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastroIngrediente.Name = "pictureBoxCadastroIngrediente";
            pictureBoxCadastroIngrediente.Size = new Size(48, 37);
            pictureBoxCadastroIngrediente.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastroIngrediente.TabIndex = 0;
            pictureBoxCadastroIngrediente.TabStop = false;
            pictureBoxCadastroIngrediente.Click += btnCadastroIngredientes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(447, 38);
            pictureBox2.Margin = new Padding(1, 1, 1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelCadastroCliente
            // 
            panelCadastroCliente.BackColor = Color.FromArgb(114, 138, 244);
            panelCadastroCliente.Controls.Add(labelCadastrarCliente);
            panelCadastroCliente.Controls.Add(pictureBoxCadastrarCliente);
            panelCadastroCliente.Cursor = Cursors.Hand;
            panelCadastroCliente.Location = new Point(809, 23);
            panelCadastroCliente.Margin = new Padding(1, 1, 1, 1);
            panelCadastroCliente.Name = "panelCadastroCliente";
            panelCadastroCliente.Size = new Size(260, 47);
            panelCadastroCliente.TabIndex = 5;
            panelCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // labelCadastrarCliente
            // 
            labelCadastrarCliente.AutoSize = true;
            labelCadastrarCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrarCliente.ForeColor = Color.GhostWhite;
            labelCadastrarCliente.Location = new Point(57, 13);
            labelCadastrarCliente.Margin = new Padding(1, 0, 1, 0);
            labelCadastrarCliente.Name = "labelCadastrarCliente";
            labelCadastrarCliente.Size = new Size(157, 25);
            labelCadastrarCliente.TabIndex = 1;
            labelCadastrarCliente.Text = "Cadastrar Cliente";
            labelCadastrarCliente.Click += btnCadastroCliente_Click;
            // 
            // pictureBoxCadastrarCliente
            // 
            pictureBoxCadastrarCliente.Image = (Image)resources.GetObject("pictureBoxCadastrarCliente.Image");
            pictureBoxCadastrarCliente.Location = new Point(4, 5);
            pictureBoxCadastrarCliente.Margin = new Padding(1, 1, 1, 1);
            pictureBoxCadastrarCliente.Name = "pictureBoxCadastrarCliente";
            pictureBoxCadastrarCliente.Size = new Size(48, 37);
            pictureBoxCadastrarCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCadastrarCliente.TabIndex = 0;
            pictureBoxCadastrarCliente.TabStop = false;
            pictureBoxCadastrarCliente.Click += btnCadastroCliente_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(36, 38);
            textBoxPesquisa.Margin = new Padding(1, 1, 1, 1);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(406, 29);
            textBoxPesquisa.TabIndex = 1;
            // 
            // barraLateralUserControlForm
            // 
            barraLateralUserControlForm.BackColor = Color.FromArgb(64, 65, 71);
            barraLateralUserControlForm.Location = new Point(-1, 0);
            barraLateralUserControlForm.Margin = new Padding(1, 1, 1, 1);
            barraLateralUserControlForm.Name = "barraLateralUserControlForm";
            barraLateralUserControlForm.Size = new Size(230, 804);
            barraLateralUserControlForm.TabIndex = 2;
            // 
            // configuracoesUserControlForm
            // 
            configuracoesUserControlForm.BackColor = Color.FromArgb(39, 39, 41);
            configuracoesUserControlForm.Location = new Point(227, 107);
            configuracoesUserControlForm.Margin = new Padding(4, 3, 4, 3);
            configuracoesUserControlForm.Name = "configuracoesUserControlForm";
            configuracoesUserControlForm.Size = new Size(1081, 494);
            configuracoesUserControlForm.TabIndex = 3;
            // 
            // contextMenuStripGeral
            // 
            contextMenuStripGeral.ImageScalingSize = new Size(24, 24);
            contextMenuStripGeral.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, funcionariosToolStripMenuItem, clientesToolStripMenuItem, enderecoToolStripMenuItem, ingredientesToolStripMenuItem, saboresToolStripMenuItem, valoresToolStripMenuItem, produtosToolStripMenuItem, configuracoesToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStripGeral.Name = "contextMenuStripGeral";
            contextMenuStripGeral.Size = new Size(152, 224);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(151, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(151, 22);
            funcionariosToolStripMenuItem.Text = "Funcionários";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(151, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // enderecoToolStripMenuItem
            // 
            enderecoToolStripMenuItem.Name = "enderecoToolStripMenuItem";
            enderecoToolStripMenuItem.Size = new Size(151, 22);
            enderecoToolStripMenuItem.Text = "Endereço";
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(151, 22);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(151, 22);
            saboresToolStripMenuItem.Text = "Sabores";
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.Size = new Size(151, 22);
            valoresToolStripMenuItem.Text = "Valores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(151, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // configuracoesToolStripMenuItem
            // 
            configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            configuracoesToolStripMenuItem.Size = new Size(151, 22);
            configuracoesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(151, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "A aplicação continua executando na bandeja";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria Do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemStray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria Do Zé";
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick_1;
            // 
            // contextMenuStripSystemStray
            // 
            contextMenuStripSystemStray.ImageScalingSize = new Size(24, 24);
            contextMenuStripSystemStray.Items.AddRange(new ToolStripItem[] { abrirAplicaçãoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemStray.Name = "contextMenuStripSystemStray";
            contextMenuStripSystemStray.Size = new Size(156, 70);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            abrirAplicaçãoToolStripMenuItem.Size = new Size(155, 22);
            abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            abrirAplicaçãoToolStripMenuItem.Click += abrirAplicaçãoToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(155, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(155, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDados.BackgroundColor = Color.FromArgb(39, 39, 41);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 25, 41);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.GhostWhite;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(233, 122);
            dataGridViewDados.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(39, 25, 41);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.GhostWhite;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(39, 39, 41);
            dataGridViewCellStyle4.ForeColor = Color.GhostWhite;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(114, 138, 244);
            dataGridViewCellStyle4.SelectionForeColor = Color.GhostWhite;
            dataGridViewDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDados.RowTemplate.Height = 29;
            dataGridViewDados.Size = new Size(1056, 460);
            dataGridViewDados.TabIndex = 20;
            dataGridViewDados.CellFormatting += dataGridViewDados_CellFormatting;
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 41);
            ClientSize = new Size(1315, 611);
            ContextMenuStrip = contextMenuStripGeral;
            Controls.Add(barraLateralUserControlForm);
            Controls.Add(panel1);
            Controls.Add(dataGridViewDados);
            Controls.Add(configuracoesUserControlForm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 1, 3, 1);
            MinimizeBox = false;
            Name = "PaginaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé";
            FormClosing += PaginaPrincipalForm_FormClosing;
            Load += PaginaPrincipalForm_Load;
            Resize += PaginaPrincipalForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCadastroProduto.ResumeLayout(false);
            panelCadastroProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroProduto).EndInit();
            panelCadastroValor.ResumeLayout(false);
            panelCadastroValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroValor).EndInit();
            panelCadastroSabor.ResumeLayout(false);
            panelCadastroSabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroSabor).EndInit();
            panelCadastroFuncionario.ResumeLayout(false);
            panelCadastroFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarProduto).EndInit();
            panelCadastroIngrediente.ResumeLayout(false);
            panelCadastroIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastroIngrediente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCadastroCliente.ResumeLayout(false);
            panelCadastroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCadastrarCliente).EndInit();
            contextMenuStripGeral.ResumeLayout(false);
            contextMenuStripSystemStray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox textBoxPesquisa;
        private Panel panelCadastroFuncionario;
        private Label labelCadastrarFuncionario;
        private PictureBox pictureBoxCadastrarProduto;
        private Panel panelCadastroCliente;
        private Label labelCadastrarCliente;
        private PictureBox pictureBoxCadastrarCliente;
        private Panel panelCadastroIngrediente;
        private Label labelCadastrarIngrediente;
        private PictureBox pictureBoxCadastroIngrediente;
        private Panel panelCadastroSabor;
        private Label labelCadastrarSabor;
        private PictureBox pictureBoxCadastroSabor;
        private Panel panelCadastroValor;
        private Label labelCadastrarValor;
        private PictureBox pictureBoxCadastroValor;
        private Panel panelCadastroProduto;
        private Label labelCadastrarProduto;
        private PictureBox pictureBoxCadastroProduto;
        private UserControls.ConfiguracoesUserControlForm configuracoesUserControlForm1;
        private BarraLateralUserControlForm barraLateralUserControlForm;
        /// <summary>
        /// configuracoesUserControlForm
        /// </summary>
        public UserControls.ConfiguracoesUserControlForm configuracoesUserControlForm;
        private ContextMenuStrip contextMenuStripGeral;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem configuracoesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        public NotifyIcon notifyIconSystemTray;
        public ContextMenuStrip contextMenuStripSystemStray;
        private DataGridView dataGridViewDados;
        private ToolStripMenuItem enderecoToolStripMenuItem;
    }
}