using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRM.Entidades
{
    public class Matricula
    {
        public int codigo { get; set; }
        public Alumno alumno { get; set; }
        public Seccion seccion { get; set; }
        public string CodigoUsuario { get; set; }

        public Matricula(int codigo, Alumno alumno, Seccion seccion, string codigoUsuario)
        {
            this.codigo = codigo;
            this.alumno = alumno;
            this.seccion = seccion;
            CodigoUsuario = codigoUsuario;
        }
    }
}
