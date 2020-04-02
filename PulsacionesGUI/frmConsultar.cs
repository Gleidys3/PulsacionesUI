using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PulsacionesGUI
{
    public partial class frmConsultar : Form
    {
        PersonaService personaService = new PersonaService();
        List<Persona> personasConsultas = new List<Persona>();
        List<Persona> personas = new List<Persona>();


        public frmConsultar()
        {
            InitializeComponent();
        }

        private void DtgConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            personas.Clear();
            personas= personaService.Consultar();
            DtgPersona.DataSource = null;
            DtgPersona.DataSource = personas;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnConsultarIndividual_Click(object sender, EventArgs e)
        {
            personas.Clear();
            personasConsultas.Clear();
            personas = personaService.Consultar();
            personasConsultas = personas.Where(p => p.Genero.Equals(CmbGneros.Text)).ToList();
            DtgConsultarIndi.DataSource = null;
            DtgConsultarIndi.DataSource = personasConsultas;




        }
    }
}
