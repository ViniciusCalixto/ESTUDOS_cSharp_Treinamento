using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExemploADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiro definiremos a conexão. (primeiro pilar do ADO .Net)
            IDbConnection conexao = new SqlConnection(@"Server=localhost\sqlexpress;Database=EXEMPLO_ADO;User Id=sa;Password=sage@2016;");
            //Agora precisamos abrir a conexão.
            conexao.Open();


            //Depois precisamos definir o comando (segundo pilar do ADO .Net)
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * From TBL_USUARIO"; //Exemplo de select

            //Agora preciso definir o DataAdapter (armazenar os dados na memória, terceiro pilar do ADO .Net)
            IDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                Console.WriteLine(leitor["NOME"].ToString() + " - " + leitor["LOGIN"].ToString());
            }

            conexao.Close();
            Console.ReadLine();


            //Exemplo de INSERT
            //InserirDados();


            Console.WriteLine("Digite o nome");
            string NomeDigitado = Console.ReadLine();

            Console.WriteLine("Digite o login");
            string LoginDigitado = Console.ReadLine();

            Console.WriteLine("Digite a senha");
            string SenhaDigitada = Console.ReadLine();

            NomeDigitado = "'" + NomeDigitado + "'";
            LoginDigitado = "'" + LoginDigitado + "'";
            SenhaDigitada = "'" + SenhaDigitada + "'";

            InserirDados(NomeDigitado, LoginDigitado, SenhaDigitada);

        }

        /// <summary>
        /// Método responsável por oferecer o exemplo de insert com ADO .Net
        /// </summary>
        static void InserirDados()
        {
            //Primeiro definiremos a conexão. (primeiro pilar do ADO .Net)
            IDbConnection conexao = new SqlConnection(@"Server=localhost\sqlexpress;Database=EXEMPLO_ADO;User Id=sa;Password=sage@2016;");
            //Agora precisamos abrir a conexão.
            conexao.Open();


            //Depois precisamos definir o comando (segundo pilar do ADO .Net)
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into tbl_usuario values('João','joao', 'j123')"; //Exemplo de insert

            comando.ExecuteNonQuery();

            conexao.Close();
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="nome"></param>
       /// <param name="login"></param>
       /// <param name="senha"></param>
        static void InserirDados(string nome, string login, string senha)
        {
            //Primeiro definiremos a conexão. (primeiro pilar do ADO .Net)
            IDbConnection conexao = new SqlConnection(@"Server=localhost\sqlexpress;Database=EXEMPLO_ADO;User Id=sa;Password=sage@2016;");
            //Agora precisamos abrir a conexão.
            conexao.Open();


            //Depois precisamos definir o comando (segundo pilar do ADO .Net)
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into tbl_usuario values(" + nome + "," + login + "," + senha + ")"; //Exemplo de insert

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
