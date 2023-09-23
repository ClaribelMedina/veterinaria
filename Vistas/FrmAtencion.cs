using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria_p2_App.Dominio;

namespace Veterinaria_p2_App.Vistas
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();

            //Crear atencion
            Atencion atencion = new Atencion();

        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarMascotas();
            ProximaAtencion();

            dtpFechaAtencion.Value= DateTime.Now;
            this.ActiveControl = cbocliente;
        }

        private void CargarMascotas()
        {
            
        }

        private void CargarClientes()
        {
            throw new NotImplementedException();
        }

        private void ProximaAtencion()
        {
            try
            {
                SqlConnection cnn = new SqlConnection();                              //creamos un obj connection y un connection string
                cnn.ConnectionString = @"Data Source = CLARI\SQLEXPRESS01; Initial Catalog = VETERINARIA_P2_MD; Integrated Security = True";
                cnn.Open();                                                           //Abrimos conexion
                SqlCommand cmd = new SqlCommand("SP_PROXIMA_ATENCION", cnn);          //creamos un obj command
                cmd.CommandType = CommandType.StoredProcedure;                        //de tipo SP
                SqlParameter param= new SqlParameter("@next", SqlDbType.Int);         //creamos un obj parameter de salida
                param.Direction = ParameterDirection.Output;                          //direction output
                cmd.Parameters.Add(param);                                            //lo agregamos a nuestros parametros de nuestro comando
                cmd.ExecuteNonQuery();                 
                int next = Convert.ToInt32(param.Value);                              //creamos una variable para almacenar el valor del parametro de salida
                lblNumAtencion.Text= "Atención N°: "+ next.ToString();                //lo seteamos en nuestro label
                cnn.Close();                                                          //CERRAMOS CONNECTION
            }
            catch (Exception)
            {

                MessageBox.Show("Error de datos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
         
            
        }
    }
}
