﻿using PizzariaDoZe_DAO;
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
    /// Formulário de Cadastro de Produtos
    /// </summary>
    public partial class CadastroProdutoForms : Form
    {
        private ProdutoDAO produtoDAO;
        /// <summary>
        /// Formulário de Cadastro de Produtos
        /// </summary>
        public CadastroProdutoForms()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);

            saveCloseUserControlForm1.btnSalvar.Click += ButtonSalvar_Click!;
            CarregaEnumListBox();
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = txtNomeProduto.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxML.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
