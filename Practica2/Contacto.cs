using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoCasa { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        

        //ESto es un constructor 
        public Contacto()
        {
            Nombre = "Nuevo Contacto";
            TelefonoCasa = "(000) 000 - 0000"; 
        }
        public Contacto(string nombre)
        {
            nombre = Nombre;
        }
        public Contacto(string nombre, string telefonocelular, string telefonocasa, string direccion, string correoelectronico)
        {
            Nombre = nombre;
            TelefonoCelular = telefonocelular;
            TelefonoCasa = telefonocasa;
            Direccion = direccion;
            CorreoElectronico = correoelectronico;

        }
    }
}
