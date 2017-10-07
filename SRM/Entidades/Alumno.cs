using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Alumno
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string PeriodoIngreso { get; set; }
        public string DNI { get; set; }
        public string Carrera { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int CreditosTotales { get; set; }
        public int CreditosMatriculados { get; set; }

        public Alumno(string codigo, string nombre, string apellido, string sexo, string periodoIngreso, string dNI, string carrera, string fechaNacimiento, string direccion, int creditosTotales, int creditosMatriculados)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            PeriodoIngreso = periodoIngreso;
            DNI = dNI;
            Carrera = carrera;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            CreditosTotales = creditosTotales;
            CreditosMatriculados = creditosMatriculados;
        }
    }
}
