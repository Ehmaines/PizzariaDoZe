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
    public partial class ConfirmarFecharAplicacaoForms : Form
    {
        public enum OpcaoConfirmacao
        {
            Fechar,
            Minimizar,
            Cancelar
        }

        Form form;

        public OpcaoConfirmacao EscolhaDoUsuario { get; private set; }
        public ConfirmarFecharAplicacaoForms(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.EscolhaDoUsuario = OpcaoConfirmacao.Fechar;
            this.form.Close();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.EscolhaDoUsuario = OpcaoConfirmacao.Minimizar;
            this.form.WindowState = FormWindowState.Minimized;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.EscolhaDoUsuario = OpcaoConfirmacao.Cancelar;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
