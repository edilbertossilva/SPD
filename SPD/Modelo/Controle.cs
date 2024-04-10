using SPD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SPD.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))// tudo ok 
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String Email, String Nome, String DataNascimento, String Sexo, String Senha, String ConfSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(Email, Nome, DataNascimento, Sexo, Senha, ConfSenha);

            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
        public static int acertos = 0, erros = 0;
        public static int totalPerguntas = 0; // Certifique-se de incrementar isso para cada pergunta

        public static string CalcularPorcentagens()
        {
            double porcentagemAcertos = (double)acertos * 100 / totalPerguntas;
            double porcentagemErros = (double)erros * 100 / totalPerguntas;
            return $"Acertos: {porcentagemAcertos}% | Erros: {porcentagemErros}%";
        }



    } 
    
}
