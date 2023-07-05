using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (EntidadesContext contexto = new EntidadesContext())
            {
                Usuario user = new Usuario();
                user.Nome = "Geovani S.";
                user.RG = "123455";
                user.DataNascimento = new DateTime(1988, 08, 10);

                contexto.Usuarios.Add(user);
                contexto.SaveChanges();
            }
        }
    }
}
