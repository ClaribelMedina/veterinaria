using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_p2_App.Dominio
{
    internal class Tipo
    {
        //property
        public string Nombre { get; set; }

        //constructores

        public Tipo(string nom)
        {
            Nombre = nom;
                
        }

        //metodo to string()

        public override string ToString()
        {
            return "Tipo: " + Nombre;
        }



    }
}
