using PizzariaDoZe_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de Cadastro de Funcionários
    /// </summary>
    public partial class CadastroFuncionarioForms : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;
        /// <summary>
        /// Formulário de Cadastro de Funcionários
        /// </summary>
        public CadastroFuncionarioForms()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            SaveCloseUserControlForm operacoes = new SaveCloseUserControlForm();
            Controls.Add(operacoes);

            operacoes.btnSalvar.Click += BtnSalvar_Click;
            operacoes.btnCancelar.Click += BtnCancelar_Click;
            #endregion

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            saveCloseUserControlForm1.btnCancelar.Click += BtnCancelar_Click;
            saveCloseUserControlForm1.btnSalvar.Click += BtnSalvar_Click!;
            userControlEndereco.maskedTextBoxCEP.Leave += SairCep!;
            userControlEndereco.textBoxId.Leave += SairIdEndereco!;
        }

        private void SairCep(object sender, EventArgs e)
        {
            if (userControlEndereco.maskedTextBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = userControlEndereco.maskedTextBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                //userControlEndereco.maskedTextBoxCep.Text = "";
                userControlEndereco.textBoxRua.Text = "";
                userControlEndereco.textBoxBairro.Text = "";
                userControlEndereco.textBoxCidade.Text = "";
                userControlEndereco.textBoxEstado.Text = "";
                userControlEndereco.textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    userControlEndereco.maskedTextBoxCEP.Text = row["cep"].ToString();
                    userControlEndereco.textBoxRua.Text = row["logradouro"].ToString();
                    userControlEndereco.textBoxBairro.Text = row["bairro"].ToString();
                    userControlEndereco.textBoxCidade.Text = row["cidade"].ToString();
                    userControlEndereco.textBoxEstado.Text = row["uf"].ToString();
                    userControlEndereco.textBoxPais.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SairIdEndereco(object sender, EventArgs e)
        {
            if (userControlEndereco.textBoxId.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Id = int.Parse(userControlEndereco.textBoxId.Text.Trim()),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                //userControlEndereco.maskedTextBoxCep.Text = "";
                userControlEndereco.textBoxRua.Text = "";
                userControlEndereco.textBoxBairro.Text = "";
                userControlEndereco.textBoxCidade.Text = "";
                userControlEndereco.textBoxEstado.Text = "";
                userControlEndereco.textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    userControlEndereco.maskedTextBoxCEP.Text = row["cep"].ToString();
                    userControlEndereco.textBoxRua.Text = row["logradouro"].ToString();
                    userControlEndereco.textBoxBairro.Text = row["bairro"].ToString();
                    userControlEndereco.textBoxCidade.Text = row["cidade"].ToString();
                    userControlEndereco.textBoxEstado.Text = row["uf"].ToString();
                    userControlEndereco.textBoxPais.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if(maskedTxtSenha.Text != maskedTxtVerificarSenha.Text)
            {
                MessageBox.Show("As senhas não são iguais");
                return;
            }

            if (userControlEndereco.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }

            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = txtNome.Text,
                Cpf = maskedTxtCPF.Text,
                Matricula = txtMatricula.Text,
                Senha = Funcoes.Sha256Hash(maskedTxtSenha.Text),
                Grupo = (radioBtnGrupoAdministrador.Checked) ? '1' : (radioBtnGrupoAtendente.Checked) ? '2' : '3',
                Motorista = txtCarteiraMotorista.Text,
                Validade = dateTimeValidadeCarteira.Value,
                Observacao = txtObservacao.Text,
                Telefone = maskedTxtTelefone.Text,
                Email = txtEmail.Text,
                EnderecoId = int.Parse(userControlEndereco.textBoxId.Text),
                Numero = userControlEndereco.textBoxNumeroCasa.Text,
                Complemento = userControlEndereco.textBoxComplemento.Text,
            };

            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
