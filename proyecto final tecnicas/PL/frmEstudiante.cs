using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSistemaAcademico.DLL;

namespace ProyectoSistemaAcademico.PL
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }
        private void ObtenerInformacion()
        {
            Estudiante estudiantes = new Estudiante();
            int ID = 0;int.TryParse(txtID.Text,out ID);
            estudiantes.ID = ID;
            estudiantes.Nombre = txtNombre.Text;
            estudiantes.Carrera = txtCarrera.Text;

            MessageBox.Show(estudiantes.Nombre);
            MessageBox.Show(estudiantes.ID.ToString());
            MessageBox.Show(estudiantes.Carrera);



        }
    }
}
