using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace PulsacionesUI
{
    class Program
    {
        static Persona persona;
        static PersonaService personaService = new PersonaService();

        static void Main(string[] args){
            Menu();
        }

        public static void Menu(){
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n ------ Menu de pulsaciones ------");
                Console.WriteLine(" 1. Registrarse");
                Console.WriteLine(" 2. Buscar");
                Console.WriteLine(" 3. Modificar");
                Console.WriteLine(" 4. Consultar");
                Console.WriteLine(" 5. Salir");
                Console.WriteLine(" ---------------------------------");
                Console.Write("\n DIGITE UNA OPCION: "); opcion = Int32.Parse(Console.ReadLine());
                switch (opcion){
                    case 1: Registrarse(); break;
                    case 2: Buscar(); break;
                    case 3: Modificar();  break;
                    case 4: Consultar(); break;
                    case 5: Console.Write("\n Presione enter para salir..."); Console.ReadKey(); break;
                    default: Console.WriteLine("\n Numero fuera de rango intente de nuevo..."); break;
                }
            } while (opcion!=5);
        }

        public static void Registrarse(){
            persona = new Persona();
            Console.WriteLine("\n Digite su informacion");
            Console.Write(" Identifiacion: "); persona.Identificacion = Console.ReadLine();
            Console.Write(" Nombre: "); persona.Nombre = Console.ReadLine();
            Console.Write(" Edad: "); persona.Edad = Int32.Parse(Console.ReadLine());
            Console.Write(" Genero[M/F]: "); persona.Genero = Console.ReadLine();
            persona.Pulsacion = persona.CalcularPulsacion(persona.Genero, persona.Edad);
            Console.WriteLine($" Pulsaciones: {persona.Pulsacion}");
            Console.WriteLine($"\n{personaService.Guardar(persona)}");
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }
        public static void Buscar()
        {
            string identificacion;
            Console.Write("\n Digite identificacion: "); identificacion = Console.ReadLine();
            persona = personaService.BuscarIdentificacion(identificacion);
            if (persona == null)
            {
                Console.WriteLine($"\n El numero de identificacion [{identificacion}] no existe");
            }
            else
            {
                Console.WriteLine("\n Informacion de persona");
                Console.WriteLine($" Identificacion: {persona.Identificacion}");
                Console.WriteLine($" Nombre: {persona.Nombre}");
                Console.WriteLine($" Edad: {persona.Edad}");
                Console.WriteLine($" Genero: {persona.Genero}");
                Console.WriteLine($" Pulsaciones: {persona.Pulsacion}");
            }
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }
        public static void Modificar()
        {
            int opcion;
            Buscar();
            Console.Clear();
            if (persona!=null)
            {
                do
                {
                    Console.WriteLine("\n Modificar persona");
                    Console.WriteLine(" 1. Identificacion");
                    Console.WriteLine(" 2. Nombre");
                    Console.WriteLine(" 3. Edad");
                    Console.WriteLine(" 4. Genero");
                    Console.WriteLine(" 5. Salir");
                    Console.WriteLine(" ---------------------------------");
                    Console.Write("\n DIGITE UNA OPCION: "); opcion = Int32.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1: ModificarIdentificacion(); break;
                        case 2: ModificarNombre(); break;
                        case 3: ModificarEdad(); break;
                        case 4: ModificarGenero(); break;
                        case 5: Console.Write("\n Pulse enter para salir..."); Console.ReadKey(); break;
                        default:
                            break;
                    }
                } while (opcion!=5);
            }
        }
        public static void ModificarIdentificacion()
        {
            string identificacion;
            Console.Write("\n Digite nueva Identificacion: "); identificacion = Console.ReadLine();
            
            if (personaService.BuscarIdentificacion(identificacion) != null)
            {
                Console.WriteLine("\n El numero de identifacion ya existe");
            }
            else
            {
                persona.Identificacion = identificacion;
                Console.WriteLine("\n Identificacion modificada correctamente");
                Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
            }
            
        }
        public static void ModificarNombre()
        {
            string nombre;
            Console.Write("\n Digite nuevo nombre: "); nombre = Console.ReadLine();
            persona.Nombre = nombre;
            Console.WriteLine("\n Nombre modificado correctamente");
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }
        public static void ModificarEdad()
        {
            int edad;
            Console.Write("\n Digite nuevo edad: "); edad = Int32.Parse(Console.ReadLine());
            persona.Edad = edad;
            persona.Pulsacion = persona.CalcularPulsacion(persona.Genero,persona.Edad);
            Console.WriteLine("\n Edad modificada correctamente");
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }
        public static void ModificarGenero()
        {
            string genero;
            Console.Write("\n Digite nuevo genero[M/F]: "); genero = Console.ReadLine();
            persona.Genero = genero;
            persona.Pulsacion = persona.CalcularPulsacion(persona.Genero, persona.Edad);
            Console.WriteLine("\n Genero modificado correctamente");
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }

        public static void Consultar()
        {
            List<Persona> personas = personaService.Consultar();
            if (personas.Count == 0)
            {
                Console.WriteLine("\n No hay personas registradas");
            }
            else
            {
                foreach (var itemPersona in personas)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n Consulta de personas");
                    Console.WriteLine("\n --------------------");
                    Console.WriteLine($" Identificacion: {itemPersona.Identificacion}");
                    Console.WriteLine($" Nombre: {itemPersona.Nombre}");
                    Console.WriteLine($" Edad: {itemPersona.Edad}");
                    Console.WriteLine($" Genero: {itemPersona.Genero}");
                    Console.WriteLine($" Pulsaciones: {itemPersona.Pulsacion}");
                    Console.WriteLine(" --------------------");
                }
            }
            Console.Write("\n Pulse enter para continuar..."); Console.ReadKey();
        }
    }
}