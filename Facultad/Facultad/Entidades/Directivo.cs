using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Entidades;

namespace Negocio
{
    public class Directivo : Empleado
    {
        public override string ListarEmpleados(bool listarConId)
        {
            return $"{_legajo} - {_nombre} {_apellido}";
        }

    }
}
