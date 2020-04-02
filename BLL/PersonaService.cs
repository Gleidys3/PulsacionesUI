using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public  class PersonaService
    {
      public   PersonaRepository personaRepository = new PersonaRepository();
        

        public  string Guardar(Persona persona)
        {
            if (Buscar(persona.Identificacion) == null)
            {
                personaRepository.Guardar(persona);
                return $" Persona guardada correctamente [{persona.Nombre}]";
            }
            return $" El numero de identificacion ya existe [{persona.Identificacion}]";
        }

        
        public   List<Persona> Consultar()
        {
            return personaRepository.Consultar();
        }
        public  string Eliminar(string identificacion)
        {
            Persona persona = personaRepository.Buscar(identificacion);
            if (persona != null)
            {
                personaRepository.Eliminar(persona);
                return $"Los datos de {persona.Nombre} se han eliminado correctamente";
            }
            else
            {
                return $"Error la persona que desea eliminar no se encuentra en el sistema";
            }

        }
        public static string Modificar(Persona persona)
        {
            Persona persona1 = PersonaRepository.Buscar(persona.Identificacion);

            if (persona1 == null)
            {

                return $"La persona con identificacion no se encuentra registrada";

            }
            else
            {
                persona1.Identificacion = persona.Identificacion;
                persona1.Nombre = persona.Nombre;
                persona1.Edad = persona.Edad;
                persona1.Genero = persona.Genero;
                PersonaRepository.Modificar(persona);
                return $"La persona {persona.Identificacion} fue Modificada";
            }
        }

        public static Persona Buscar(string identificacion)
        {
            return PersonaRepository.Buscar(identificacion);
        }


        
    }
}
