﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PizzariaDoZe
{
    internal class Funcoes
    {
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado, executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo, por exemplo Text, Font, Size, PasswordChar, Location etc.
        /// O objetivo principal aqui é ajustar o Control, por exemplo o Form, para o Idioma e Cultura escolhido pelo usuário.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Text, em outros textBoxSenha.PasswordChar, ou seja, todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="container">Informar o container inicial, geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.</param>
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }

        /// <summary>
        /// Altera a cor do BackGroud quando o campo ganha o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter); </example>
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Alterar a cor do BackGroup quando o campo perde o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Leave += new System.EventHandler(ClassFuncoes.CampoEventoLeave); </example>
        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// adicionando nos tipos informados os eventos Enter e Leave,
        /// e vinculando aos manipuladores criados.
        /// </summary>
        /// <param name="container">Informar o container inicial,
        /// geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.
        /// </param>
        public static void EventoFocoCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                EventoFocoCampos(c);
                switch (c)
                {
                    case TextBoxBase:
                    case ComboBox:
                    case RadioButton:
                    case CheckBox:
                        //case ButtonBase:
                        //adiciona eventos ganhar e perder o foco
                        c.Enter += new EventHandler(CampoEventoEnter!);
                        c.Leave += new EventHandler(CampoEventoLeave!);
                        break;

                }
            }
        }

        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando com TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para true.</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        ///</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm()!;
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }
        // Os itens de menu do nosso menu suspenso fazem parte de uma Collection, ou seja,
        // não estão diretamente em uma camada de Control e sim internamente no menu de contexto.
        // Desta forma precisamos percorrer seus itens para poder ajustar os parâmetros via resources
        public static void AjustaResourcesItem(ContextMenuStrip cmt)
        {
            ComponentResourceManager resources = new(typeof(Properties.Resources));
            foreach (ToolStripItem c in cmt.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
        }

        /* Estilo moeda em TextBox, usuário entra e digita somente números, ao sair é realizada a formatação R$ 10,90.
* Ao entrar novamente no campo, é removido o R$ e libera para editar novamente
* TextBox : TextBoxBase | MaskedTextBox : TextBoxBase
*
* ClassFuncoes.AplicaMascaraMoeda( textBoxValor ); */
        //Função para colocar a mascara
        private static void RetornarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            string? auxIdiomaRegiao =
                (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
                ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "pt-BR";

            txt.Text = double.Parse(txt.Text).ToString("C2", CultureInfo.CreateSpecificCulture(auxIdiomaRegiao!)); ;
        }

        //Função para retirar a mascara
        private static void TirarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        //Função para somente permitir números e virgula
        private static void ApenasValorNumericoMoeda(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    // Verifica se já existe um separador decimal no texto
                    if (txt.Text.Contains(separadorDecimal))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        //Aplica todas as funções aos respectivos eventos
        public static void AplicaMascaraMoeda(TextBoxBase txt)
        {
            txt.Enter += TirarMascaraMoeda!;
            txt.Leave += RetornarMascaraMoeda!;
            txt.KeyPress += ApenasValorNumericoMoeda!;
        }

        private static void VerificaFormClosing(object sender, FormClosingEventArgs e)
        {
            Control x = (Control)sender;
            Form form = x.FindForm()!;

            ConfirmarFecharAplicacaoForms confirmarFecharForm = new ConfirmarFecharAplicacaoForms(form);

            confirmarFecharForm.ShowDialog();

            if (confirmarFecharForm.EscolhaDoUsuario == ConfirmarFecharAplicacaoForms.OpcaoConfirmacao.Fechar)
            {
                Application.Exit();
            }
            else if (confirmarFecharForm.EscolhaDoUsuario == ConfirmarFecharAplicacaoForms.OpcaoConfirmacao.Minimizar)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else
            {
                e.Cancel = true;
            }
        }

        public static void AplicaFormClosing(Form form)
        {
            form.FormClosing += VerificaFormClosing!;
        }
    }
}
