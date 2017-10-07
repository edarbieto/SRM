using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SRM.Entidades;

namespace SRM.Formularios
{
    public partial class AgregarEditarAlumno : MetroForm
    {
        public AgregarEditarAlumno(string modo, Alumno obj)
        {
            InitializeComponent();
            if (modo == "agregar")
            {
                Text = "Agregar nuevo alumno";
            }
            else if (modo == "editar")
            {
                Text = "Editar alumno";
                mtCodigo.Text = obj.Codigo;
                mtNombre.Text = obj.Nombre;
                mtApellido.Text = obj.Apellido;
                mcSexo.Text = obj.Sexo;
                mtDni.Text = obj.DNI;
                mtPeriodo.Text = obj.PeriodoIngreso;
                mcCarrera.Text = obj.Carrera;
                mdtFechanacimiento.Text = obj.FechaNacimiento;
                mtDireccion.Text = obj.Direccion;
                mtCreditostotales.Text = obj.CreditosTotales.ToString();
                mtCreditosmatriculados.Text = obj.CreditosMatriculados.ToString();
            }
        }
    }
}
