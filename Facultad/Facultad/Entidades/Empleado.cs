using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Empleado : Persona
    {
        // ATRIBUTOS
        protected DateTime _fechaIngreso;
        protected int _legajo;


        // PROPIEDADES
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }

        // PROPERTIES HEREDADAS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }
        public string NombreEmpleado { get => NombrePersona; set => NombrePersona = value; }
        public string ApellidoEmpleado { get => Apellido; set => Apellido = value; }

        // PROPERTIES CUSTOM
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }

        // METODOS
        protected override void GetCredencial()
        {

        }

        public abstract string ListarEmpleados(bool listarConId);


    }
}
