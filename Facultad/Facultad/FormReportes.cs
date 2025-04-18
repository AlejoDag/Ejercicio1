using System;
using Facultad.Persistencia;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facultad.Entidades;
using System.Runtime.CompilerServices;

namespace Facultad
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        Universidad uba = new Universidad();

        private void button1_Click(object sender, EventArgs e)
        {

            int cantidadExamenes = obtenerExamenesPorAlumno(16198);

            MessageBox.Show("El alumno 16198 tiene rendido " + cantidadExamenes + " examenes.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Reporte> reporteAlumno = generarReporte(53270);

            string mensaje = "";

            foreach (Reporte reporte in reporteAlumno)
            {
                string carrera = reporte.NombreCarrera;
                int cantAprobadas = reporte.MateriasAprobadas;
                int cantFaltantes = reporte.MateriasFaltantes;
                double porcentajeAvance = reporte.PorcentajeAvance;

                mensaje += $"{carrera}\n" +
                           $"Materias Aprobadas: {cantAprobadas}\n" +
                           $"Materias Faltantes: {cantFaltantes}\n" +
                           $"Porcentaje de avance: {porcentajeAvance:F0}%\n" +
                           $"--------------------------\n";
            }

            MessageBox.Show(mensaje);
        }

        private int obtenerExamenesPorAlumno(int idAlumno)
        {

            Alumno alumno = buscarAlumno(idAlumno);
            return alumno.Examenes.Count;

        }

        private List<Reporte> generarReporte(int idAlumno)
        {
            Alumno alumno = buscarAlumno(idAlumno);
            List<Reporte> reportes = new List<Reporte>();

            foreach (Carrera carrera in alumno.Carreras)
            {
                Reporte reporte = new Reporte(alumno, carrera);
                reportes.Add(reporte);
            }

            return reportes;
        }


        private Alumno buscarAlumno(int codigo)
        {
            Alumno alumnoBuscado = null;
            List<Alumno> listadoAlumnos = uba.Alumnos;

            foreach (Alumno alumno in listadoAlumnos)
            {
                if (alumno.Codigo == codigo)
                {
                    alumnoBuscado = alumno;
                    break;
                }
            }

            return alumnoBuscado;
        }
    }
}
