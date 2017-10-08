using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Carrera { get; set; }
        public int Creditaje { get; set; }

        public Curso(string codigo, string nombre, string descripcion, string carrera, int creditaje)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Carrera = carrera;
            Creditaje = creditaje;
        }
    }
}
