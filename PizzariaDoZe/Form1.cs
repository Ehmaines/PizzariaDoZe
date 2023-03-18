namespace PizzariaDoZe
{
    public partial class PaginaPrincipalForm : Form
    {
        CadastroFuncionarioForms cadastroFuncionario;
        CadastroClienteForms cadastroCliente;
        CadastroIngredienteForms cadastroIgrediente;
        CadastroSaborForms cadastroSabor;
        public PaginaPrincipalForm()
        {
            InitializeComponent();
            cadastroFuncionario = new CadastroFuncionarioForms();
            cadastroCliente = new CadastroClienteForms();
            cadastroIgrediente = new CadastroIngredienteForms();
            cadastroSabor = new CadastroSaborForms();
            setEventosBarraLateralInicio();
            setEventosBarraLateralFuncionarios();
            setEventosBarraLateralClientes();
            setEventosBarraLateralIngredientes();
            setEventosBarraLateralSabores();
            setEventosBarraLateralConfiguracoes();
        }

        private void setEventosBarraLateralInicio()
        {
            barraLateralUserControlForm.panelInicio.Click += IrParaInicio;
            barraLateralUserControlForm.labelInicio.Click += IrParaInicio;
            barraLateralUserControlForm.pictureBoxInicio.Click += IrParaInicio;
        }

        private void setEventosBarraLateralFuncionarios()
        {
            barraLateralUserControlForm.panelFuncionario.Click += IrParaFuncionarios;
            barraLateralUserControlForm.labelFuncionarios.Click += IrParaFuncionarios;
            barraLateralUserControlForm.pictureBoxFuncionario.Click += IrParaFuncionarios;
        }
        private void setEventosBarraLateralClientes()
        {
            barraLateralUserControlForm.panelClientes.Click += IrParaClientes;
            barraLateralUserControlForm.labelClientes.Click += IrParaClientes;
            barraLateralUserControlForm.pictureBoxClientes.Click += IrParaClientes;
        }

        private void setEventosBarraLateralIngredientes()
        {
            barraLateralUserControlForm.panelIngredientes.Click += IrParaIngredientes;
            barraLateralUserControlForm.labelIngredientes.Click += IrParaIngredientes;
            barraLateralUserControlForm.pictureBoxIngredientes.Click += IrParaIngredientes;
        }

        private void setEventosBarraLateralSabores()
        {
            barraLateralUserControlForm.panelSabores.Click += IrParaSabores;
            barraLateralUserControlForm.labelSabores.Click += IrParaSabores;
            barraLateralUserControlForm.pictureBoxSabores.Click += IrParaSabores;
        }

        private void setEventosBarraLateralConfiguracoes()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaginaPrincipalForm_Resize(object sender, EventArgs e)
        {
            //tabControl1.Width = this.Width - 300;
        }

        private void PaginaPrincipalForm_Load(object sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(163, 184, 247);
            panelPrincipalInicio.Visible = true;
        }

        private void IrParaInicio(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(163, 184, 247);
            panelPrincipalInicio.Visible = true;
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

        private void IrParaConfiguracoes(object? sender, EventArgs e)
        {
            setTodosCadastrosParaNaoVisiveis();
            setTodasAsCoresDaBarraLateralParaPadrao();
            barraLateralUserControlForm.panelConfiguracoes.BackColor = Color.FromArgb(163, 184, 247);
        }

        private void setTodasAsCoresDaBarraLateralParaPadrao()
        {
            barraLateralUserControlForm.panelInicio.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelFuncionario.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelClientes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelIngredientes.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelSabores.BackColor = Color.FromArgb(88, 95, 105);
            barraLateralUserControlForm.panelConfiguracoes.BackColor = Color.FromArgb(88, 95, 105);
        }

        private void setTodosCadastrosParaNaoVisiveis()
        {
            panelCadastroCliente.Visible = false;
            panelCadastroIngrediente.Visible = false;
            panelCadastroSabor.Visible = false;
            panelCadastroFuncionario.Visible = false;
            panelPrincipalInicio.Visible = false;
        }
    }
}