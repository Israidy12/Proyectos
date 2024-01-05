using SIstemadeGestiondeClientes.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemadeGestiondeClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarlista();
            
        }

        private void actualizarlista()
        {

            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.obtenerListadoDeClientes();

            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {

                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetadeCredito = txtTarjetadeCredito.Text;


            if (lblid.Text != "")
            {
                cliente.Id = lblid.Text;    
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarlista();

          

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          Cliente cliente =  (Cliente) listClientes.SelectedItem;

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarlista();
            limpiarlistado();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
           
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetadeCredito.Text = cliente.TarjetadeCredito;
            lblid.Text = cliente.Id;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            limpiarlistado();
        }

        private void limpiarlistado()
        {

            lblid.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjetadeCredito.Text = "";



        }
    }



}
