using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_p2_App.Dominio
{
    internal class Mascota
    {
        private string nombre;
        private DateTime fecha_nacimiento;

        public List<Atencion> Atenciones { get; set; }
        public Tipo Tipo_mascota { get; set; }

        public string  Nombre 
        {
            get { return nombre; }
            set { value= nombre; }
        }

        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { value = fecha_nacimiento; }
        }

      

        //constructores
        public Mascota()
        {
            nombre = string.Empty;
            fecha_nacimiento = DateTime.Now;
            Tipo_mascota = null;
          

        }


        public Mascota(string nombre, DateTime fecha_nac, Tipo tipo_masc)
        {
            this.nombre = nombre;
            this.fecha_nacimiento= fecha_nac;
            
        }


        //metodo ToString()

        public override string ToString()
        {
            return "Nombre : " + nombre + "Nacimiento : " + fecha_nacimiento +
                "Tipo de mascota: " + Tipo_mascota;
        }


    }
}
