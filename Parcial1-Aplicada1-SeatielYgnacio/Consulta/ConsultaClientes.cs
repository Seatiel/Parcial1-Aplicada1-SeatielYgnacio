using Entidades;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1_Aplicada1_SeatielYgnacio.Consulta
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        List<Clientes> lista = new List<Clientes>();         

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrartextBox.Text))
            {

                lista = ClientesBll.GetLista(Utilidades.ToInt(FiltrartextBox.Text));
            }
            else
            {
                lista = ClientesBll.GetLista();
            }
            DatosdataGridView.DataSource = lista;
        }
    }
}
