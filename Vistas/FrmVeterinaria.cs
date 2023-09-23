using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria_p2_App.Vistas;

namespace Veterinaria_p2_App
{
    public partial class FrmVeterinaria : Form
    {
        public FrmVeterinaria()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nuevaAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencion nuevo = new FrmAtencion();
            nuevo.ShowDialog();
        }

        private void nuevaMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaMascota nuevo = new FrmNuevaMascota();
            nuevo.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevo= new FrmNuevoCliente();
            nuevo.ShowDialog();
        }
    }
}
