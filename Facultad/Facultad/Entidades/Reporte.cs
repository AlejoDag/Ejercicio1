using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Persistencia;
using Negocio;
using Facultad.Entidades;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace Facultad.Entidades
{
    public class Reporte
    {
        
        public string NombreCarrera { get; set; }
        public int MateriasAprobadas { get; set; }
        public int MateriasFaltantes { get; set; }
        public double PorcentajeAvance
        {
            get
            {
                int total = MateriasAprobadas + MateriasFaltantes;
                return total == 0 ? 0 : (MateriasAprobadas * 100.0) / total;
            }
        }

        public Reporte(Alumno alumno, Carrera carrera)
        {
            this.NombreCarrera = carrera.Nombre;

            List<Examen> examenes = alumno.Examenes;
            List<Materia> materiasDeCarrera = carrera.Materias;

            int aprobadas = 0;

            foreach (Materia materia in materiasDeCarrera)
            {
                bool estaAprobada = false;

                foreach (Examen examen in examenes)
                {
                    if (examen.IdMateria == materia.Id && examen.Nota >= 4)
                    {
                        estaAprobada = true;
                        break;
                    }
                }

                if (estaAprobada)
                {
                    aprobadas++;
                }
            }

            this.MateriasAprobadas = aprobadas;
            this.MateriasFaltantes = materiasDeCarrera.Count - aprobadas;
        }
    }
}