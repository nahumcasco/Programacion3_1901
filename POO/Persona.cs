using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Persona
    {
        //Atributos o Características
        private string identidad;
        private string nombre;

        //Propiedades
        public string Identidad 
        { 
            get
            {
                return identidad;
            }
            set
            {
                identidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Correo { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public string Direccion { get; set; }

        //Constructores
        public Persona () { }

        public Persona(string identidad, string nombre, string apellidos)
        {
            Identidad = identidad;
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public Persona(string identidad, string nombre, string correo, string apellidos, int edad, string direccion)
        {
            Identidad = identidad;
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Edad = edad;
            Direccion = direccion;
        }

        //Metodos o acciones
        public string GetNombreCompleto(string nombre, string apellidos)
        {
            string nombreCompleto = Nombre + " " + Apellidos;

            return nombreCompleto;
        }



    }
}
