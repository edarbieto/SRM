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
        public Curso Curso { get; set; }
        public Docente Docente { get; set; }
        public string Dia { get; set; }
        public string HoraInicio { get; set; }
        public string NumeroHoras { get; set; }
        public string Aula { get; set; }

        public Seccion(string codigo, string sede, string modalidad, string periodo, Curso curso, Docente docente, string dia, string horaInicio, string numeroHoras, string aula)
        {
            Codigo = codigo;
            Sede = sede;
            Modalidad = modalidad;
            Periodo = periodo;
            Curso = curso;
            Docente = docente;
            Dia = dia;
            HoraInicio = horaInicio;
            NumeroHoras = numeroHoras;
            Aula = aula;
        }
    }
}
