using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_p2_App.Dominio
{
    internal class Atencion
    {
        public int atencion_nro { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        


        public Atencion()
        {
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Importe = 0;
            
        }

        public Atencion(DateTime fecha, string desc, double imp)
        {
            this.Fecha = fecha;
            this.Descripcion = desc;
            this.Importe = imp;
          
        }


        public override string ToString()
        {
            return "";
        }
    }
}
