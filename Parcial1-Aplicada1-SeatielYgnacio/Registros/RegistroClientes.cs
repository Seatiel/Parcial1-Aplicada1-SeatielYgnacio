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

namespace Parcial1_Aplicada1_SeatielYgnacio.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            if (!Validar())
            {
                MessageBox.Show("Complete los Campos");
                return;
            }
            cliente = LlenarFormulario();

            if(ClientesBll.Guardar(cliente))
            {
                MessageBox.Show("El Registro del Cliente se ha Guardado.");
            }
        }

        public Clientes LlenarFormulario()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = Utilidades.ToInt(ClienteIdtextBox.Text);
            cliente.Nombre = NombretextBox.Text;
            cliente.FechaNacimiento = FechaNacimienteomaskedTextBox.Text;
            cliente.LimiteCredito = Convert.ToInt32(LimiteCreditomaskedTextBox.Text);
            return cliente;
        }

        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Debe introducir el Nombre");
                errorProvider2.SetError(ClienteIdtextBox, "Debe introducir el ClienteId");
                errorProvider3.SetError(FechaNacimienteomaskedTextBox, "Debe introducir el Fecha de Nacimiento");
                errorProvider4.SetError(LimiteCreditomaskedTextBox, "Debe introducir el Limite de credito");
                retorno = false;
            }
            return retorno;
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            if (ClientesBll.Modificar(cliente))
            {
                MessageBox.Show("Se ha Modificado.");
            }
        }
    }
}