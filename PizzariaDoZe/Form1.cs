using PizzariaDoZe.UserControls;
using PizzariaDoZe_DAO;
using System.Configuration;
using System.Data;
using System.Data.Common;

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
        IngredienteDAO ingredienteDAO;
        EnderecoDAO enderecoDAO;
        ClienteDAO clienteDAO;
        FuncionarioDAO funcionarioDAO;

        /// <summary>
        /// P�gina Principal da aplica��o
        /// </summary>
        public PaginaPrincipalForm()
        {
            InitializeComponent();
            ValidaConexaoDB();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            SetEventosBarraLateralInicio();
            SetEventosBarraLateralFuncionarios();
            SetEventosBarraLateralClientes();
            SetEventosBarraLateralIngredientes();
            SetEventosBarraLateralEnderecos();
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
            enderecoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            ingredientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            saboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            valoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            produtosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;
            configuracoesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F9;
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
        }

        private void SetEventosContextMenu()
        {
            inicioToolStripMenuItem.Click += new EventHandler(IrParaInicio!);
            funcionariosToolStripMenuItem.Click += new EventHandler(IrParaFuncionarios!);
            clientesToolStripMenuItem.Click += new EventHandler(IrParaClientes!);
            enderecoToolStripMenuItem.Click += new EventHandler(IrParaEnderecos!);
            ingredientesToolStripMenuItem.Click += new EventHandler(IrParaIngredientes!);
            saboresToolStripMenuItem.Click += new EventHandler(IrParaSabores!);
            valoresToolStripMenuItem.Click += new EventHandler(IrParaValores!);
            produtosToolStripMenuItem.Click += new EventHandler(IrParaProdutos!);
            configuracoesToolStripMenuItem.Click += new EventHandler(IrParaConfiguracoes!);
            //pedidosToolStripMenuItem.Click += new EventHandler(IrPara!);
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

        private void SetEventosBarraLateralEnderecos()
        {
            barraLateralUserControlForm.panelEnderecos.Click += IrParaEnderecos;
            barraLateralUserControlForm.labelEnderecos.Click += IrParaEnderecos;
            barraLateralUserControlForm.pictureBoxEndereco.Click += IrParaEnderecos;
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
            cadastroFuncionario = new CadastroFuncionarioForms();
            cadastroFuncionario.ShowDialog();
            AtualizarTela(GetFuncionarioDataTable());
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            cadastroCliente = new CadastroClienteForms();
            cadastroCliente.ShowDialog();
            AtualizarTela(GetClienteDataTable());
        }

        private void btnCadastroIngredientes_Click(object sender, EventArgs e)
        {
            cadastroIgrediente = new CadastroIngredienteForms();
            cadastroIgrediente.ShowDialog();
            AtualizarTela(GetIngredienteDataTable());
        }

        private void btnCadastroSabores_Click(object sender, EventArgs e)
        {
            cadastroSabor = new CadastroSaborForms();
            cadastroSabor.ShowDialog();
        }

        private void btnCadastroValores_Click(object sender, EventArgs e)
        {
            cadastroValor = new CadastroValorForms();
            cadastroValor.ShowDialog();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            cadastroProduto = new CadastroProdutoForms();
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
            dataGridViewDados.Visible = true;
            barraLateralUserControlForm.panelFuncionario.BackColor = Color.FromArgb(163, 184, 247);
            AtualizarTela(GetFuncionarioDataTable());
        }

        private void IrParaClientes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroCliente.Visible = true;
            dataGridViewDados.Visible = true;
            barraLateralUserControlForm.panelClientes.BackColor = Color.FromArgb(163, 184, 247);
            AtualizarTela(GetClienteDataTable());
        }

        private void IrParaEnderecos(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            dataGridViewDados.Visible = true;
            barraLateralUserControlForm.panelEnderecos.BackColor = Color.FromArgb(163, 184, 247);
            AtualizarTela(GetEnderecoDataTable());
        }

        private void IrParaIngredientes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            panelCadastroIngrediente.Visible = true;
            dataGridViewDados.Visible = true;
            barraLateralUserControlForm.panelIngredientes.BackColor = Color.FromArgb(163, 184, 247);
            AtualizarTela(GetIngredienteDataTable());
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
            configuracoesUserControlForm.buttonConfigurarBanco.Click += ConfiguraDB!;
        }

        private void setTodasAsCoresDaBarraLateralParaPadrao()
        {
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelFuncionario.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelClientes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelEnderecos.BackColor = Color.FromArgb(88, 95, 105);
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
            dataGridViewDados.Visible = false;
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

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obt�m o providerName e atualiza em tela
            configuracoesUserControlForm.comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obt�m a connectionString e atualiza em tela
            configuracoesUserControlForm.textBoxStringConnection.Text = connectionStringSettings.ConnectionString;
        }

        #region ReturnItensDAO

        private DataTable GetIngredienteDataTable()
        {
            var ingrediente = new Ingrediente();
            return ingredienteDAO.Buscar(ingrediente);
        }

        private DataTable GetEnderecoDataTable()
        {
            var endereco = new Endereco();
            return enderecoDAO.Buscar(endereco);
        }

        private DataTable GetClienteDataTable()
        {
            var cliente = new Cliente();
            return clienteDAO.Buscar(cliente);
        }

        private DataTable GetFuncionarioDataTable()
        {
            var funcionario = new Funcionario();
            return funcionarioDAO.Buscar(funcionario);
        }

        #endregion

        private void ConfiguraDB(object sender, EventArgs e)
        {
            new ConfigurarBancoDeDadosForm().ShowDialog();
            ValidaConexaoDB();
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region AtualizaTela

        private void AtualizarTela(DataTable linhas)
        {
            //Inst�ncia e Preenche o objeto com os dados da view

            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model

                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        /// <summary>
        /// Valida conex�o com database
        /// </summary>
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new ConfigurarBancoDeDadosForm().ShowDialog();
                ValidaConexaoDB();
            }
        }

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }
    }
}