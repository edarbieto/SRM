using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Seccion
    {
        public string Codigo { get; set; }
        public string Sede { get; set; }
        public string Modalidad { get; set; }
        public string Periodo { get; set; }
        public string CodigoCurso { get; set; }
        public string CodigoDocente { get; set; }
        public string Dia { get; set; }
        public string HoraInicio { get; set; }
        public string NumeroHoras { get; set; }
        public string Aula { get; set; }

        public Seccion(string codigo, string sede, string modalidad, string periodo, string codigoCurso, string codigoDocente, string dia, string horaInicio, string numeroHoras, string aula)
        {
            Codigo = codigo;
            Sede = sede;
            Modalidad = modalidad;
            Periodo = periodo;
            CodigoCurso = codigoCurso;
            CodigoDocente = codigoDocente;
            Dia = dia;
            HoraInicio = horaInicio;
            NumeroHoras = numeroHoras;
            Aula = aula;
        }
    }
}
