using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9P8
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Conta");
            comboTipo.Items.Add("Poupança");
            comboTipo.Items.Add("Corrente");
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Conta novaConta = null;
            int cmbTipoIndice = comboTipo.SelectedIndex;

            if (cmbTipoIndice == -1)
            {
                MessageBox.Show("Erro: selecione um tipo no campo Tipo.");
            }
            else
            {
                switch (cmbTipoIndice){
                    case 0:
                        novaConta = new Conta();
                        break;
                    case 1:
                        novaConta = new ContaPoupanca();
                        break;
                    case 2:
                        novaConta = new ContaCorrente();
                        break;
                    default:
                        MessageBox.Show("Erro: tipo não identificado.");
                        break;
                }

                novaConta.Titular = new Titular(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);

                this.formPrincipal.AdicionaConta(novaConta);
            }
        }
    }
}
