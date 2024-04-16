using Aplicacao_ASOO__Pedro_Gregorio_.modelo;
using System.Security.Cryptography.X509Certificates;

namespace Aplicacao_ASOO__Pedro_Gregorio_
{
    public class Verificacao
    {
        public string RaDigitado;
        public string mensagem;
        public string mensagem2;
        public string mensagem3;
        public string mensagem4;


        Pessoa Pessoa = new Pessoa();

        public string ValidarRA(string raDigitado)
        {
            mensagem = "";

            if (raDigitado == Pessoa.ra)
            {
                mensagem = "Esse é o RA correto de:";
                mensagem2 = Pessoa.nome.ToString();
            }
            else
            {
                mensagem = "Esse não é o RA de Pedro Gregório, o RA correto é G85ABF1";
            }
            return mensagem;
        }
    }
}
