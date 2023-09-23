using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_p2_App.Dominio
{
    internal class Cliente
    {
        public int cod_cliente { get; set; }
        public string  Nombre { get; set; }
        public string Sexo { get; set; }

        public List< Mascota> lista_mascotas { get; set; }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = string.Empty;
            lista_mascotas = new List< Mascota>();
        
        }

        public Cliente(string nombre, string sexo)
        {
            this.Nombre = nombre;
            this.Sexo = sexo;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "Sexo: " + Sexo;
        }
    }
}
