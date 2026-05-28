using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using(Stream entrada = File.Open("texto.txt", FileMode.Open))
                using(StreamReader leitor = new StreamReader(entrada))
                {
                    textoConteudo.Text = leitor.ReadToEnd();
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            using(Stream saida = File.Open("texto.txt", FileMode.Create))
            using(StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("Achei o texto " + busca);
            }
            else
            {
                MessageBox.Show("Não achei");
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            alterarOcorrencia(textoBusca.Text, textoReplace.Text);
        }

        private void botaoCaixaAlta_Click(object sender, EventArgs e)
        {
            string textoDoEditor = textoConteudo.Text;
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string trecho = textoDoEditor.Substring(inicioSelecao, tamanhoSelecao);
            string trechoAlteracao = trecho.ToUpper();

            alterarOcorrencia(trecho, trechoAlteracao);
        }

        private void botaoCaixaBaixa_Click(object sender, EventArgs e)
        {
            string textoDoEditor = textoConteudo.Text;
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string trecho = textoDoEditor.Substring(inicioSelecao, tamanhoSelecao);
            string trechoAlteracao = trecho.ToLower();

            alterarOcorrencia(trecho, trechoAlteracao);
        }

        private void alterarOcorrencia(string busca, string alteracao)
        {
            string textoDoEditor = textoConteudo.Text;

            string textoEditorAlterado = textoDoEditor.Replace(busca, alteracao);

            textoConteudo.Text = textoEditorAlterado;
        }
    }
}
