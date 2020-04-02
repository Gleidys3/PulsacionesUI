using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        string Ruta = @"persona.txt";
        List<Persona> personas;
        public PersonaRepository()
        {
            personas = new List<Persona>();
        }

        public void Guardar(Persona persona)
        {
            FileStream OrigenFlujo = new FileStream(Ruta, FileMode.Append);
            StreamWriter Escritor = new StreamWriter(OrigenFlujo);
            Escritor.WriteLine(persona.Identificacion + ";" + persona.Nombre + ";" + persona.Edad + ";" + persona.Genero + ";" + persona.Pulsacion);
            Escritor.Close();
            OrigenFlujo.Close();
        }
        public void Eliminar(Persona persona)
        {
            personas.Clear();
            personas = Consultar();
            personas.Remove(persona);
            FileStream SourceStream = new FileStream(Ruta, FileMode.Create);
            SourceStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != persona.Identificacion)
                {
                    Guardar(item);
                }
            }

        }



        public void Modificar(Persona persona)
        {
            personas= Consultar();
            FileStream SourceStream = new FileStream(Ruta, FileMode.Create);
            SourceStream.Close();
            foreach (var item in personas)

            {
                if (persona.Identificacion != item.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(persona);
                }
            }


        }

        public List<Persona> Consultar()
        {
            
                 
                FileStream origenFlujo = new FileStream(Ruta, FileMode.OpenOrCreate);
                StreamReader lector = new StreamReader(origenFlujo);

                string linea = string.Empty;

            while ((linea = lector.ReadLine()) != null)
            {
                Persona persona = Mapear(linea);

                personas.Add(persona);
            }
                lector.Close();
                origenFlujo.Close();
                return personas;
            
        }

        private Persona Mapear(string Linea)
        {
            char delimiter = ';';
            string[] DatosPersona = Linea.Split(delimiter);
             Persona persona = new Persona();

            persona.Identificacion = DatosPersona[0];
            persona.Nombre = DatosPersona[1];
            persona.Edad = Convert.ToInt32(DatosPersona[2]);
            persona.Genero = DatosPersona[3];
            persona.Pulsacion = Convert.ToDouble(DatosPersona[4]);
           
            return persona;
        }
        public Persona Buscar(Persona persona)
        {
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(persona.Identificacion))
                {
                    return item;
                }
            }
            return null;
        }

        public Persona Buscar(string identificacion)
        {
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }


    }
}
