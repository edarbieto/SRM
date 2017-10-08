using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Matricula
    {
        public int Codigo { get; set; }
        public string CodigoAlumno { get; set; }
        public string CodigoSeccion { get; set; }
        public string CodigoUsuario { get; set; }

        public Matricula(int codigo, string codigoAlumno, string codigoSeccion, string codigoUsuario)
        {
            this.Codigo = codigo;
            CodigoAlumno = codigoAlumno;
            CodigoSeccion = codigoSeccion;
            CodigoUsuario = codigoUsuario;
        }
    }
}
