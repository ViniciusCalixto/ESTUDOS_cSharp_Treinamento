using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEFModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (DB_ExemploModelFirstEntities contexto = new DB_ExemploModelFirstEntities())
            {
                Usuario objetoUsuario = new Usuario();

                objetoUsuario.Nome = "Geovani S.";
                objetoUsuario.RG = "123456";
                objetoUsuario.DataNascimento = new DateTime(1988, 08, 10);

                contexto.Usuario.Add(objetoUsuario);
                contexto.SaveChanges();
            }

        }
    }
}
