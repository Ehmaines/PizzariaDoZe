using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe_DAO;
using System.Configuration;

namespace PizzariaDoZe
{
    /// <summary>
    /// Formulário de Cadastro de Ingredientes
    /// </summary>
    public partial class CadastroIngredienteForms : Form
    {
        private readonly IngredienteDAO dao;
        /// <summary>
        /// Formulário de Cadastro de Ingredientes
        /// </summary>
        public CadastroIngredienteForms()
        {
            InitializeComponent();

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new IngredienteDAO(provider, strConnection);

            saveCloseUserControlForm1.btnSalvar.Click += SalvarIngrediente!;
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
        }
        private void SalvarIngrediente(object sender, EventArgs e)
        {
            var ingrediente = new Ingrediente()
            {
                IdIngrediente = 0,
                Nome = txtNomeIngrediente.Text
            };

            try
            {
                dao.InserirDbProvider(ingrediente);

                MessageBox.Show("Dados Inseridos com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
