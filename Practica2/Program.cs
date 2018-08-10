using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variable
            Persona persona1;
            //Creación de instancia, alojamiento en memoria
            persona1 = new Persona();
            persona1.nombre = "juan";
            persona1.apellidos = "Locote";
            persona1.edad = 20;
            persona1.altura = 1.70f;

            Console.WriteLine(persona1.nombre + " " + persona1.apellidos + " tiene " + persona1.edad + " años");

            persona1.cumplirAños();
            Console.WriteLine("Ahora " + persona1.nombre + " " + persona1.apellidos + " tiene " + persona1.edad + " años");
            //Imprimir su altura
            Console.WriteLine(persona1.nombre + " Mide: " + persona1.altura);
            persona1.crecimiento(0.12f);
            Console.WriteLine(persona1.altura + " ahora mide  ");
            Console.ReadLine();
        }
    }
}
