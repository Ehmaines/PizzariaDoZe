using PizzariaDoZe.UserControls;
using System.Configuration;

namespace PizzariaDoZe
{
    /// <summary>
    /// P�gina Principal da aplica��o
    /// </summary>
    public partial class PaginaPrincipalForm : Form
    {
        CadastroFuncionarioForms cadastroFuncionario;
        CadastroClienteForms cadastroCliente;
        CadastroIngredienteForms cadastroIgrediente;
        CadastroSaborForms cadastroSabor;
        CadastroValorForms cadastroValor;
        CadastroProdutoForms cadastroProduto;

        /// <summary>
        /// P�gina Principal da aplica��o
        /// </summary>
        public PaginaPrincipalForm()
        {
            InitializeComponent();

            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            cadastroFuncionario = new CadastroFuncionarioForms();
            cadastroCliente = new CadastroClienteForms();
            cadastroIgrediente = new CadastroIngredienteForms();
            cadastroSabor = new CadastroSaborForms();
            cadastroValor = new CadastroValorForms();
            cadastroProduto = new CadastroProdutoForms();

            SetEventosBarraLateralInicio();
            SetEventosBarraLateralFuncionarios();
            SetEventosBarraLateralClientes();
            SetEventosBarraLateralIngredientes();
            SetEventosBarraLateralSabores();
            SetEventosBarraLateralValores();
            SetEventosBarraLateralProdutos();
            SetEventosBarraLateralConfiguracoes();
            SetEventosContextMenu();
            SetAtalhosParaContextMenu();
            configuracoesUserControlForm.comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            Funcoes.AjustaResourcesItem(contextMenuStripGeral);
        }

        private void SetAtalhosParaContextMenu()
        {
            inicioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            funcionariosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            clientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            ingredientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            saboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            valoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            produtosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            configuracoesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;
            //Colocar o sair
        }

        private void SetEventosContextMenu()
        {
            inicioToolStripMenuItem.Click += new EventHandler(IrParaInicio!);
            funcionariosToolStripMenuItem.Click += new EventHandler(IrParaFuncionarios!);
            clientesToolStripMenuItem.Click += new EventHandler(IrParaClientes!);
            ingredientesToolStripMenuItem.Click += new EventHandler(IrParaIngredientes!);
            saboresToolStripMenuItem.Click += new EventHandler(IrParaSabores!);
            valoresToolStripMenuItem.Click += new EventHandler(IrParaValores!);
            produtosToolStripMenuItem.Click += new EventHandler(IrParaProdutos!);
            configuracoesToolStripMenuItem.Click += new EventHandler(IrParaConfiguracoes!);
            //pedidosToolStripMenuItem.Click += new EventHandler(IrPara!);
            //sairToolStripMenuItem.Click += new EventHandler(ButtonSair_Click!);
        }

        private void SetEventosBarraLateralInicio()
        {
            barraLateralUserControlForm.panelInicio.Click += IrParaInicio;
            barraLateralUserControlForm.labelInicio.Click += IrParaInicio;
            barraLateralUserControlForm.pictureBoxInicio.Click += IrParaInicio;
        }

        private void SetEventosBarraLateralFuncionarios()
        {
            barraLateralUserControlForm.panelFuncionario.Click += IrParaFuncionarios;
            barraLateralUserControlForm.labelFuncionarios.Click += IrParaFuncionarios;
            barraLateralUserControlForm.pictureBoxFuncionario.Click += IrParaFuncionarios;
        }
        private void SetEventosBarraLateralClientes()
        {
            barraLateralUserControlForm.panelClientes.Click += IrParaClientes;
            barraLateralUserControlForm.labelClientes.Click += IrParaClientes;
            barraLateralUserControlForm.pictureBoxClientes.Click += IrParaClientes;
        }

        private void SetEventosBarraLateralIngredientes()
        {
            barraLateralUserControlForm.panelIngredientes.Click += IrParaIngredientes;
            barraLateralUserControlForm.labelIngredientes.Click += IrParaIngredientes;
            barraLateralUserControlForm.pictureBoxIngredientes.Click += IrParaIngredientes;
        }

        private void SetEventosBarraLateralSabores()
        {
            barraLateralUserControlForm.panelSabores.Click += IrParaSabores;
            barraLateralUserControlForm.labelSabores.Click += IrParaSabores;
            barraLateralUserControlForm.pictureBoxSabores.Click += IrParaSabores;
        }

        private void SetEventosBarraLateralValores()
        {
            barraLateralUserControlForm.panelValores.Click += IrParaValores;
            barraLateralUserControlForm.labelValores.Click += IrParaValores;
            barraLateralUserControlForm.pictureBoxValores.Click += IrParaValores;
        }

        private void SetEventosBarraLateralProdutos()
        {
            barraLateralUserControlForm.panelProdutos.Click += IrParaProdutos;
            barraLateralUserControlForm.labelProdutos.Click += IrParaProdutos;
            barraLateralUserControlForm.pictureBoxProdutos.Click += IrParaProdutos;
        }

        private void SetEventosBarraLateralConfiguracoes()
        {
            barraLateralUserControlForm.panelConfiguracoes.Click += IrParaConfiguracoes;
            barraLateralUserControlForm.labelConfiguracoes.Click += IrParaConfiguracoes;
            barraLateralUserControlForm.pictureBoxConfiguracoes.Click += IrParaConfiguracoes;
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            cadastroFuncionario.ShowDialog();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            cadastroCliente.ShowDialog();
        }

        private void btnCadastroIngredientes_Click(object sender, EventArgs e)
        {
            cadastroIgrediente.ShowDialog();
        }

        private void btnCadastroSabores_Click(object sender, EventArgs e)
        {
            cadastroSabor.ShowDialog();
        }

        private void btnCadastroValores_Click(object sender, EventArgs e)
        {
            cadastroValor.ShowDialog();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            cadastroProduto.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaginaPrincipalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
        }

        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void PaginaPrincipalForm_Load(object sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaInicio(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaFuncionarios(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroFuncionario.Visible = true;
            barraLateralUserControlForm.panelFuncionario.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaClientes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroCliente.Visible = true;
            barraLateralUserControlForm.panelClientes.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaIngredientes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroIngrediente.Visible = true;
            barraLateralUserControlForm.panelIngredientes.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaSabores(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroSabor.Visible = true;
            barraLateralUserControlForm.panelSabores.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaValores(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            //TODO: Alterar aqui para Valores
            panelCadastroValor.Visible = true;
            barraLateralUserControlForm.panelValores.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaProdutos(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            //TODO: Alterar aqui para Produtos
            panelCadastroProduto.Visible = true;
            barraLateralUserControlForm.panelProdutos.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void IrParaConfiguracoes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelConfiguracoes.BackColor = Color.FromArgb(163, 184, 247);
            configuracoesUserControlForm.Visible = true;
            configuracoesUserControlForm.btnSalvar.Click += SalvarIdioma!;
        }

        private void setTodasAsCoresDaBarraLateralParaPadrao()
        {
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelFuncionario.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelClientes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelIngredientes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelSabores.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelConfiguracoes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelValores.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelProdutos.BackColor = Color.FromArgb(88, 95, 105);
        }

        private void setTodosCadastrosParaNaoVisiveis()
        {
            panelCadastroCliente.Visible = false;
            panelCadastroIngrediente.Visible = false;
            panelCadastroSabor.Visible = false;
            panelCadastroFuncionario.Visible = false;
            panelCadastroProduto.Visible = false;
            panelCadastroValor.Visible = false;
            configuracoesUserControlForm.Visible = false;
        }

        private void SalvarIdioma(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as altera��es em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", configuracoesUserControlForm.comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            MessageBox.Show("Idioma/regi�o alterada com sucesso! Reinicie a aplica��o para aplicar o novo Idioma/regi�o!");
            if (configuracoesUserControlForm.checkBoxReniciarAplicacaoConfig.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void notifyIconSystemTray_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void PaginaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ConfirmarFecharAplicacaoForms confirmarFecharForm = new ConfirmarFecharAplicacaoForms(this);
                var result = confirmarFecharForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    notifyIconSystemTray.ShowBalloonTip(1000);
                }

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void abrirAplica��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}