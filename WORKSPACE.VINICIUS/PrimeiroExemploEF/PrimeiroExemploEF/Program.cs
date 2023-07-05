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
            /*
            Console.WriteLine("informe o nome de Usuario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("informe o Login de Usuario: ");
            string login = Console.ReadLine();
            Console.WriteLine("informe a senha de Usuario: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Usuario ativo? <S> - SIM ou  <N> - NÃO: ");
            string statusDigitado = Console.ReadLine().ToUpper();
            int status = statusDigitado == "S" ? 1 : 2;

            GravarUsuario(nome, login, senha, status);
            Console.WriteLine("Usuario cadastrado com sucesso!");
            Console.ReadLine();

            */
            //----------------------------------------------------

            Console.WriteLine("informe o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("informe a data de Nascimento: ");
            DateTime data_nascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe o RG: ");
            string rg = Console.ReadLine();

            Console.WriteLine("Informe o CPF: ");
            string cpf = Console.ReadLine();

            int id_usuario = 1;

            Console.WriteLine("Usuario ativo? <S> - SIM ou <N> - NÃO: ");
            string statusDigitado = Console.ReadLine().ToUpper();
            int status = statusDigitado == "S" ? 1 : 2;
            
            GravarFuncionario(nome, data_nascimento, rg, cpf, id_usuario, status);
            Console.WriteLine("Funcionario cadastrado com sucesso!");
            Console.ReadLine();
        }

        static void GravarUsuario(string nome, string login, string senha, int status)
        {
             using (EXEMPLO_EFEntities contextoEF = new EXEMPLO_EFEntities()) //Abro a conexao com base de dados
            {
                //manipulação dos dados dentro do Using 

                //inicializar a tabela que será manipulada (OBJETO)
                TBL_USUARIO objetoTabelaUsuario = new TBL_USUARIO();

                //passa para os atributos do objeto os parametros passados no metodo.
                objetoTabelaUsuario.NOME = nome;
                objetoTabelaUsuario.LOGIN = login;
                objetoTabelaUsuario.SENHA = senha;
                objetoTabelaUsuario.ID_STATUS = status;

                //passa como paramentro para o contextoEF add o objetotabelausuario
                contextoEF.TBL_USUARIO.Add(objetoTabelaUsuario);

                //salva na tabelas as informações.
                contextoEF.SaveChanges();

            }
        }


        static void GravarFuncionario(string nome, DateTime data_nascimento, string rg, string cpf, int id_usuario, int id_status)
        {
            using (EXEMPLO_EFEntities contextoEF = new EXEMPLO_EFEntities()) //Abro a conexao com base de dados
            {
                //manipulação dos dados dentro do Using 

                //inicializar a tabela que será manipulada (OBJETO)
                TBL_FUNCIONARIO objetoTabelaFunc = new TBL_FUNCIONARIO();

                //passa para os atributos do objeto os parametros passados no metodo.
                objetoTabelaFunc.NOME = nome;
                objetoTabelaFunc.DATA_NASCIMENTO = data_nascimento;
                objetoTabelaFunc.RG = rg;
                objetoTabelaFunc.CPF = cpf;
                objetoTabelaFunc.ID_USUARIO = id_usuario;
                objetoTabelaFunc.ID_STATUS = id_status;

                //passa como paramentro para o contextoEF add o objetotabelausuario
                contextoEF.TBL_FUNCIONARIO.Add(objetoTabelaFunc);

                //salva na tabelas as informações.
                contextoEF.SaveChanges();

            }
        }
    }
}
