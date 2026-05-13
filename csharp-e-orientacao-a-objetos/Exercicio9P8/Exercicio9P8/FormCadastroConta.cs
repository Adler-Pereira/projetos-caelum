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

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Titular(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
