using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public double Pulsacion { get; set; } 

        public Persona(string identificacion, string nombre, int edad, string genero, double pulsacion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Pulsacion = pulsacion;
        }

        public Persona()
        {
        }

        public  double CalcularPulsacion()
        {
            if (Genero.Equals("F"))
            {
                Pulsacion = (210 - Edad) / 10;

            }
            Pulsacion = (220 - Edad) / 10;

            return Pulsacion;
        }
    }
}