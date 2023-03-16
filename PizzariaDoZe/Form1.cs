namespace PizzariaDoZe
{
    public partial class PaginaPrincipalForm : Form
    {
        //CadastroFuncionarioForm cadastroFuncionario;
        CadastroClienteForms cadastroCliente;
        CadastroIngredienteForms cadastroIgrediente;
        CadastroSaborForms cadastroSabor;
        public PaginaPrincipalForm()
        {
            InitializeComponent();
            //cadastroFuncionario = new CadastroFuncionarioForm();
            cadastroCliente = new CadastroClienteForms();
            cadastroIgrediente = new CadastroIngredienteForms();
            cadastroSabor = new CadastroSaborForms();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            //cadastroFuncionario.ShowDialog();
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
    }
}