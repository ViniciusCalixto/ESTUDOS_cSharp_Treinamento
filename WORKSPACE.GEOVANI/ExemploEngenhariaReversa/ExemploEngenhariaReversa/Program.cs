using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEngenhariaReversa
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ModeloEngenhariaReversa contexto = new ModeloEngenhariaReversa())
            {
                Usuarios user = new Usuarios();
                user.Nome = "Geovani S. Engenharia Reversa";
                user.RG = "12334455";
                user.DataNascimento = new DateTime(1988, 08, 10);

                contexto.Usuarios.Add(user);
                contexto.SaveChanges();
            }
        }
    }
}
