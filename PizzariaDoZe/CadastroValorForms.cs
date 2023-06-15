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
    /// Formulário de Cadastro de Valores
    /// </summary>
    public partial class CadastroValorForms : Form
    {
        private ValorDAO valorDAO;
        /// <summary>
        /// Formulário de Cadastro de Valores
        /// </summary>
        public CadastroValorForms()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            CarregaEnumListBox();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);

            saveCloseUserControlForm1.btnSalvar.Click += ButtonSalvar_Click!;
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(txtValor.Text),
                ValorBorda = decimal.Parse(txtValorBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
