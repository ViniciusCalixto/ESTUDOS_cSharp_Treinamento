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
            using (ModelExemploModelFirstContainer contexto = new ModelExemploModelFirstContainer())
            {
                Usuario objetoUsuario = new Usuario();

                objetoUsuario.Nome = "Vinicius";
                objetoUsuario.DataNascimento = new DateTime(1994, 01, 16);
                objetoUsuario.RG = "40.602.497-02";

                contexto.Usuario.Add(objetoUsuario);
                contexto.SaveChanges();



            }

        }
    }
}
