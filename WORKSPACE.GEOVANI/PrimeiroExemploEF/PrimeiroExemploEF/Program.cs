using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExemploEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste de comentário


            Console.WriteLine("Informe o Nome do usuário");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o login do usuário");
            string login = Console.ReadLine();
            Console.WriteLine("Informe a Senha do Usuário");
            string senha = Console.ReadLine();
            Console.WriteLine("Usuário ativo? <S> para SIM ou <N> NÃO");
            string statusDigitado = Console.ReadLine();
            int status = statusDigitado == "S" ? 1 : 2;

            GravarUsuario(nome, login, senha, status);

            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.ReadLine();


        }

        static void GravarUsuario(string nome, string login, string senha, int status)
        {
            
            using(EXEMPLO_EFEntities contextoEF = new EXEMPLO_EFEntities())//Abro a conexão com a minha base de dados
            {
                TBL_USUARIO objetoDaTabelaUsuario = new TBL_USUARIO(); //Inicializando meu objeto

                objetoDaTabelaUsuario.NOME = nome;
                objetoDaTabelaUsuario.LOGIN = login;
                objetoDaTabelaUsuario.SENHA = senha;
                objetoDaTabelaUsuario.ID_STATUS = status;

                contextoEF.TBL_USUARIO.Add(objetoDaTabelaUsuario);
                contextoEF.SaveChanges();
            }
        }
    }
}
