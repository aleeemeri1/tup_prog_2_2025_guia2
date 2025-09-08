using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2.Models
{
    internal class Persona
    {
        public int Dni { get; }
        public string Nombre { get; set; }
        public Persona(int dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public string Describir()
        {
            return $"DNI: {Dni}- Nombre: {Nombre}";
        }
    }
}
