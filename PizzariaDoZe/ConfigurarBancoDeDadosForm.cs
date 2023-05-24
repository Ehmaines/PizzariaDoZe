using PizzariaDoZe.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace PizzariaDoZe
{
    public partial class ConfigurarBancoDeDadosForm : Form
    {
        public ConfigurarBancoDeDadosForm()
        {
            InitializeComponent();
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringConnection.Text = connectionStringSettings.ConnectionString;
        }



        private void buttonSalvarBanco_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (ValidaConexaoDB(comboBoxProvider.Text, textBoxStringConnection.Text))
            {
                this.Close();
            }

            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringConnection.Text;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");

            //TODO: fazer algo para não deixar trocar das configurações
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }

        public static bool ValidaConexaoDB(string ProviderName, string ConnectionString)
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
                return conexao.State == ConnectionState.Open;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new ConfigurarBancoDeDadosForm().ShowDialog();
                ValidaConexaoDB(ProviderName, ConnectionString);
                return false;
            }
        }

        private void ConfigurarBancoDeDadosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ValidaConexaoDB(config.ConnectionStrings.ConnectionStrings["BD"].ProviderName, config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString);
        }
    }
}
