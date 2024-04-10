using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SPD.DAL
{
    public class Conexao
    {
       
        SqlConnection con = new SqlConnection();

     public Conexao()
        {
             
               con.ConnectionString = @"Data Source=DESKTOP-LK06SV6\SQLEXPRESS;Initial Catalog=SPD;Integrated Security=True;Encrypt=False";
                                        //Data Source = DESKTOP - LK06SV6\SQLEXPRESS; Initial Catalog = SPD; Integrated Security = True; Encrypt = False
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}