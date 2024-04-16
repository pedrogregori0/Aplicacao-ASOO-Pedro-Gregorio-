using Aplicacao_ASOO__Pedro_Gregorio_.modelo;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Aplicacao_ASOO__Pedro_Gregorio_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Verificacao verificacao = new Verificacao();
            Pessoa pessoa = new Pessoa();

            string RaDigitado = txbRa.Text;
            string mensagem = verificacao.ValidarRA(RaDigitado);
            string mensagem2 = "Nome: " + pessoa.nome.ToString();
            string mensagem3 = "RA: " + pessoa.ra.ToString();
            string mensagem4 = "Curso: " + pessoa.curso.ToString();

            if (mensagem.Equals("Esse é o RA correto de:"))
            { 
            lblResposta.Text = mensagem;
            lblResposta2.Text = mensagem2;
            lblResposta3.Text = mensagem3;
            lblResposta4.Text = mensagem4;
            }
            else
            {
                lblResposta.Text = mensagem;
            }
        }

        private void lblDigiteRA_Click(object sender, EventArgs e)
        {

        }
    }
}
