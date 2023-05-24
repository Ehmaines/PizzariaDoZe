using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// <summary>
        /// Formulário de Cadastro de Clientes
        /// </summary>
        public CadastroClienteForms()
        {
            InitializeComponent();
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
        }

        private void VerificaCamposObrigatorios()
        {
            saveCloseUserControlForm1.btnSalvar.DialogResult = DialogResult.None;
            //User control
            if(maskedTxtCPF.Text == "   .   .   -")
            {
                maskedTxtCPF.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo CPF obrigatório");
            }
            else if(textBoxNome.Text == "")
            {
                textBoxNome.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Nome obrigatório");
            }
            else if (textBoxEmail.Text == "")
            {
                textBoxEmail.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Email obrigatório");
            }
            else if (maskedTxtTelefone.Text == "")
            {
                maskedTxtTelefone.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Telefone obrigatório");
            }
            else if (enderecoUserControlForm1.maskedTextBoxCEP.Text.Trim() == "")
            {
                enderecoUserControlForm1.maskedTextBoxCEP.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo CEP obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxRua.Text == "")
            {
                enderecoUserControlForm1.textBoxRua.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Rua obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxNumeroCasa.Text == "")
            {
                enderecoUserControlForm1.textBoxNumeroCasa.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Numero obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxBairro.Text == "")
            {
                enderecoUserControlForm1.textBoxBairro.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Bairro obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxCidade.Text == "")
            {
                enderecoUserControlForm1.textBoxCidade.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Cidade obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxEstado.Text == "")
            {
                enderecoUserControlForm1.textBoxEstado.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Estado obrigatório");
            }
            else if (enderecoUserControlForm1.textBoxPais.Text == "")
            {
                enderecoUserControlForm1.textBoxPais.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Campo Estado obrigatório");
            }
            else
            {
                enderecoUserControlForm1.textBoxBairro.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.textBoxCidade.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.textBoxEstado.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.textBoxNumeroCasa.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.textBoxPais.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.textBoxRua.BackColor = System.Drawing.Color.Yellow;
                enderecoUserControlForm1.maskedTextBoxCEP.BackColor = System.Drawing.Color.Yellow;
            }
        }
    }
}
