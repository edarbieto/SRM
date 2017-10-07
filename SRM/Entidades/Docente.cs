using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Docente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string FechaNacimiento { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Facultad { get; set; }
        public string Contrato { get; set; }

        public Docente(string codigo, string nombre, string apellido, string dNI, string fechaNacimiento, string descripcion, string direccion, string facultad, string contrato)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
            Descripcion = descripcion;
            Direccion = direccion;
            Facultad = facultad;
            Contrato = contrato;
        }
    }
}
