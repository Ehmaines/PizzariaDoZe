using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            operacoes.Dock = DockStyle.Top;
            Controls.Add(operacoes);

            operacoes.btnSalvar.Click += BtnSalvar_Click;
            operacoes.btnCancelar.Click += BtnCancelar_Click;
            #endregion
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
