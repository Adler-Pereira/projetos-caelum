using Exercicio9P8.Contas;
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
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            comboTipo.Items.Add("Poupança");
            comboTipo.Items.Add("Corrente");
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Conta novaConta = null;
            int cmbTipoIndice = comboTipo.SelectedIndex;

            if (cmbTipoIndice > -1)
            {
                switch (cmbTipoIndice)
                {
                    case 0:
                        novaConta = new ContaPoupanca();
                        break;
                    case 1:
                        novaConta = new ContaCorrente();
                        break;
                    default:
                        MessageBox.Show("Erro: tipo selecionado não encontrado.");
                        break;
                }
                if (novaConta != null)
                {
                    novaConta.Titular = new Titular(textoTitular.Text);

                    this.formPrincipal.AdicionaConta(novaConta);

                    MessageBox.Show("Conta criada com sucesso!");

                    this.Close();
                }
                else
                    MessageBox.Show("Erro: não foi possível criar a conta.");
            }
            else
                MessageBox.Show("Erro: selecione um tipo no campo Tipo.");
        }

        private void btCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
