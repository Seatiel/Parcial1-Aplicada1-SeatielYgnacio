using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1_Aplicada1_SeatielYgnacio
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroClientes rClientes = new Registros.RegistroClientes();
            rClientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta.ConsultaClientes rConsulta = new Consulta.ConsultaClientes();
            rConsulta.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Registros.RegistroClientes rClientes = new Registros.RegistroClientes();
            rClientes.Show();
        }
    }
}
