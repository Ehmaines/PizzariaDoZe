using Org.BouncyCastle.Asn1.Cmp;
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

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de Cadastro de Clientes
    /// </summary>
    public partial class CadastroClienteForms : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;
        /// <summary>
        /// Formulário de Cadastro de Clientes
        /// </summary>
        public CadastroClienteForms()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);

            InitializeComponent();
            userControlEndereco.maskedTextBoxCEP.Leave += SairCep!;
            userControlEndereco.textBoxId.Leave += SairIdEndereco!;
            saveCloseUserControlForm1.btnSalvar.Click += SalvarCliente!;
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }

        private void SalvarCliente(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
            if (userControlEndereco.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = textBoxNome.Text,
                Cpf = maskedTxtCPF.Text,
                Telefone = maskedTxtTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(userControlEndereco.textBoxId.Text),
                Numero = userControlEndereco.textBoxNumeroCasa.Text,
                Complemento = userControlEndereco.textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    userControlEndereco.textBoxId.Text = row["id"].ToString();
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

        private void VerificaCamposObrigatorios()
        {
            saveCloseUserControlForm1.btnSalvar.DialogResult = DialogResult.None;
            //User control
            if (maskedTxtCPF.Text == "   .   .   -")
            {
                maskedTxtCPF.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo CPF obrigatório");
                return;
            }
            else if (textBoxNome.Text == "")
            {
                textBoxNome.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Nome obrigatório");
                return;
            }
            else if (textBoxEmail.Text == "")
            {
                textBoxEmail.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Email obrigatório");
                return;
            }
            else if (maskedTxtTelefone.Text == "")
            {
                maskedTxtTelefone.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Telefone obrigatório");
                return;
            }
            else if (userControlEndereco.maskedTextBoxCEP.Text.Trim() == "")
            {
                userControlEndereco.maskedTextBoxCEP.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo CEP obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxRua.Text == "")
            {
                userControlEndereco.textBoxRua.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Rua obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxNumeroCasa.Text == "")
            {
                userControlEndereco.textBoxNumeroCasa.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Numero obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxBairro.Text == "")
            {
                userControlEndereco.textBoxBairro.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Bairro obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxCidade.Text == "")
            {
                userControlEndereco.textBoxCidade.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Cidade obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxEstado.Text == "")
            {
                userControlEndereco.textBoxEstado.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Estado obrigatório");
                return;
            }
            else if (userControlEndereco.textBoxPais.Text == "")
            {
                userControlEndereco.textBoxPais.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Estado obrigatório");
                return;
            }
        }
    }
}
