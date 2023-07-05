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
            //Primeiro definiremos a conexão. (Primeiro pilar do ADO .NET)
            IDbConnection conexao = new SqlConnection(@"Server=AMR-00186-NB\SAGE; Database=EXEMPLO_ADO; User Id=sa; Password=S@geBr.2014;");
            //Abrir Conexao
            conexao.Open();

            //Definir o comando. (Segundo pilar do ADO .NET)
            IDbCommand comando = conexao.CreateCommand();
            //dizer qual comando 
            comando.CommandText = "SELECT * FROM tbl_usuario"; //Exemplo de select 

            //Definir o DataAdapter, para armazernar os dados na memoria. (Terceiro pilar do ADO .NET)
            IDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                Console.WriteLine(leitor["NOME"].ToString() + " - " + leitor["LOGIN"].ToString());
            }

            //fechar conexao
            conexao.Close();




            //Exemplo de INSERT
            // InserirDados();

            //Exemplo de insert com dados digitados
            Console.WriteLine("\n");

            Console.WriteLine("Digite o nome (100 caracteres) ");
            string NomeDigitado = Console.ReadLine();

            Console.WriteLine("Digite o Login (10 caracteres) ");
            string LoginDigitado = Console.ReadLine();

            Console.WriteLine("Digite o Senha (5 caracteres) ");
            string SenhaDigitado = Console.ReadLine();


            InserirDadosDigitados(NomeDigitado, LoginDigitado, SenhaDigitado);

            Console.ReadLine();
        }

        /// <summary>
        /// Método responsavel por oferencer o exemplo de insert com ADO .NET
        /// </summary>
        static void InserirDados()
        {
            //Primeiro definiremos a conexão. (Primeiro pilar do ADO .NET)
            IDbConnection conexao = new SqlConnection(@"Server=AMR-00186-NB\SAGE; Database=EXEMPLO_ADO; User Id=sa; Password=S@geBr.2014;");
            //Abrir Conexao
            conexao.Open();

            //Definir o comando. (Segundo pilar do ADO .NET)
            IDbCommand comando = conexao.CreateCommand();
            //dizer qual comando 
            comando.CommandText = "INSERT INTO tbl_usuario VALUES('Calixto','calixto','123')"; //Exemplo de INSERT 

            //Apenas para executar o comando, utulizando em insert, delete e update
            comando.ExecuteNonQuery();
            
            //fechar conexao
            conexao.Close();
        }
         /// <summary>
        /// Metódo para inserir dados digitados pelo usuario 
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Login"></param>
        /// <param name="Senha"></param>
        static void InserirDadosDigitados(string Nome, string Login, string Senha)
        {
           
            //Primeiro definiremos a conexão. (Primeiro pilar do ADO .NET)
            IDbConnection conexao = new SqlConnection(@"Server=AMR-00186-NB\SAGE; Database=EXEMPLO_ADO; User Id=sa; Password=S@geBr.2014;");
            //Abrir Conexao
            conexao.Open();

            //Definir o comando. (Segundo pilar do ADO .NET)
            IDbCommand comando = conexao.CreateCommand();
            //dizer qual comando 
            comando.CommandText = "INSERT INTO tbl_usuario VALUES('" + Nome + "','" + Login + "','" + Senha + "')"; //Exemplo de INSERT 

            //Apenas para executar o comando, utulizando em insert, delete e update
            comando.ExecuteNonQuery();

            //fechar conexao
            conexao.Close();
        }
    }
}
