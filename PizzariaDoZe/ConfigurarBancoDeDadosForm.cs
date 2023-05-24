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

            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringConnection.Text;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");

            //TODO: fazer algo para não deixar trocar das configurações
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }
    }
}
