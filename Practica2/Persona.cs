using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Persona
    {
        //Atributos
        //Definir a través de variables
        string nombre;
        string apellidos;
        string fechanacimiento;
        int edad;
        float altura;

        //Métodos
        //Definidos a través de funciones
        void cumpliraños()
        {
            edad++; 
        }

        void crecimiento(float cantidadcrecimiento)
        {
            altura += cantidadcrecimiento;
        }
    }
}
