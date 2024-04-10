using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPD.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao Con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(string login, string senha)
        {
            // Comandos SQL para verificar se existe no banco
            cmd.CommandText = "select * from CadUsuario where Email = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                cmd.Connection = Con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                Con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
        public String cadastrar(String email, String nome, String nascimento, String sexo, String senha, String confirmarSenha)
        {
            tem = false;
            if (senha.Equals(confirmarSenha))
            {
                cmd.Parameters.Clear(); // Limpa os parâmetros anteriores
                cmd.CommandText = "insert into CadUsuario (Email, Nome, DataNascimento, Sexo, Senha, confirmarSenha) values (@e, @n, @na, @se, @s, @cs)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@na", nascimento);
                cmd.Parameters.AddWithValue("@se", sexo);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@cs", confirmarSenha);


                try
                {
                    cmd.Connection = Con.Conectar();
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro de banco de Dados: " + ex.Message;
                }
                finally
                {
                    Con.Desconectar();
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }

            return mensagem;
        }
    }
}