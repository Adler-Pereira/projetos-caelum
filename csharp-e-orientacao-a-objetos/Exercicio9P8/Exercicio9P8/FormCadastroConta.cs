using Exercicio9P8.Busca;
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
        private ICollection<string> devedores;
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
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
            bool ehDevedor = this.devedores.Contains(textoTitular.Text);

            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(textoTitular.Text);
            }
            if (!ehDevedor)
            {
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
            else
            {
                MessageBox.Show("devedor");
            }
        }

        private void btCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
