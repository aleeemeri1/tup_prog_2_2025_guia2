using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2.Models
{
    internal class Servicio
    {
        List<Persona> personas = new List<Persona>();
        public Servicio()
        {
        
        }

        public bool Agregarpersona(Persona nueva)
        {
            bool agregar = false;
            int nuevodni = nueva.Dni;
            if (Verpersonapordni(nuevodni) == null)
            {
                agregar = true;
                personas.Add(nueva);
            }
            return agregar;
        }
        public Persona Verpersonapordni(int dni)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < personas.Count)
            {
                if (personas[n].Dni == dni)
                {
                    idx = n;
                }
                n++;
            }
            if (idx > -1)
                return personas[idx];
            else
                return null;
        }
        public int Vercantidadpersonas()
        {
            return personas.Count;
        }
        public Persona Verpersona(int n)
        { 
          if (n>=0 && n<=personas.Count)
          {
                return personas[n];
          }
            return null;
        }
        public void Eliminarpersonas(Persona persona)
        {
           Persona existente = Verpersonapordni(persona.Dni);
           if (personas != null)
           {
                personas.Remove(persona);
           }
        }
    } 
}
