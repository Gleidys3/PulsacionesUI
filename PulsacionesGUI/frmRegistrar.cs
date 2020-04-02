using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionesGUI
{
    public partial class frmRegistrar : Form
    {
        PersonaService personaService = new PersonaService();

        Persona persona;
        public frmRegistrar()
        {
            InitializeComponent();
        }
        string mensaje;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                persona = new Persona();
                persona.Identificacion = txtIdentificacion.Text.Trim();
                persona.Nombre = txtNombre.Text.Trim();
                persona.Edad = Convert.ToInt32(txtEdad.Text.Trim());
                persona.Genero = cmbGenero.Text.Trim();
                txtPulsacion.Text = persona.CalcularPulsacion().ToString();
                mensaje = personaService.Guardar(persona);
                MessageBox.Show(mensaje, "Mensaje");
                Limpiar();
            }
            catch (Exception error)
            {
                mensaje = Convert.ToString(error);
                MessageBox.Show(mensaje, "Mensaje");
            }

           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtIdentificacion.Text.Trim();
                persona = personaService.BuscarPersona(identificacion);
                if (persona != null)
                {
                    txtNombre.Text = persona.Nombre;
                    txtEdad.Text = Convert.ToString(persona.Edad);
                    cmbGenero.Text = persona.Genero;
                    txtPulsacion.Text = persona.Pulsacion.ToString();
                }
                else
                {
                    mensaje = $"La persona con la identificacion {identificacion} buscada no se encuentra en el sistema registrada";
                    MessageBox.Show(mensaje, "Mensaje");
                    Limpiar();
                }
            }
            catch (Exception error)
            {
                mensaje = Convert.ToString(error);
                MessageBox.Show(mensaje, "Mensaje");
            }
            
            
        }
        public void Limpiar()
        {
            txtEdad.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtPulsacion.Text = "";
            cmbGenero.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text != "")
            {
                Persona persona = new Persona(txtIdentificacion.Text, txtNombre.Text, Convert.ToInt32(txtEdad.Text),
                    CmbGenero.Text);
                string mensaje = PersonaService.Modificar(persona);
                Limpiar();
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Debe ingresar el numero de identificacion");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string identificacion = txtIdentificacion.Text.Trim();
                persona = personaService.BuscarPersona(identificacion);
                if (persona != null)
                {
                    txtNombre.Text = persona.Nombre;
                    txtEdad.Text = Convert.ToString(persona.Edad);
                    cmbGenero.Text = persona.Genero;
                    txtPulsacion.Text = persona.Pulsacion.ToString();
                    mensaje = personaService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Mensaje");
                    Limpiar();
                }
                else
                {
                    mensaje = personaService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Mensaje");
                    Limpiar();
                }
            }
            catch (Exception error)
            {
                mensaje = Convert.ToString(error);
                MessageBox.Show(mensaje, "Mensaje");
            }
        }
    }
}
