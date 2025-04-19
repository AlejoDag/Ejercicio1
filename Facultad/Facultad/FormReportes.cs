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
                mensaje += $"{reporte.NombreCarrera}\n" +
                           $"Materias Aprobadas: {reporte.MateriasAprobadas}\n" +
                           $"Materias Faltantes: {reporte.MateriasFaltantes}\n" +
                           $"Porcentaje de avance: {reporte.PorcentajeAvance:F0}%\n" +
                           $"--------------------------\n";
            }

            MessageBox.Show(mensaje);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte reporte = generarReporteAlumnoConMasMaterias();
            
            string mensaje =
                $"Alumno: {reporte.NombreAlumno}\n" +
                $"Carreras: {reporte.NombreCarrera}\n" +
                $"Materias Aprobadas: {reporte.MateriasAprobadas}";

            MessageBox.Show(mensaje);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> materias = buscarMateriasAlumno(74508);

            string mensaje = "Perdió las siguientes materias\n";

            foreach (string materia in materias)
            {
                mensaje += "- " + materia + "\n";
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

        private Reporte generarReporteAlumnoConMasMaterias()
        {
            Alumno alumno = BuscarAlumnoConMasCarrerasYMateriasAprobadas();

            string nombreCarrera = "";
            
            foreach (Carrera carrera in alumno.Carreras)
            {
                if (nombreCarrera != "")
                {
                    nombreCarrera += " y "; // Añadir " y " entre los nombres de las carreras
                }
                nombreCarrera += carrera.Nombre;
            }
            // Crear una lista de IDs de materias aprobadas (sin repetir)
            List<int> materiasAprobadas = new List<int>();

            foreach (Examen examen in alumno.Examenes)
            {
                if (examen.Nota >= 4 && !materiasAprobadas.Contains(examen.IdMateria))
                {
                    materiasAprobadas.Add(examen.IdMateria);
                }
            }

            Reporte reporte = new Reporte(alumno, alumno.Carreras.First())
            {
                NombreAlumno = alumno.Nombre + " " + alumno.Apellido,
                NombreCarrera = nombreCarrera,
                MateriasAprobadas = materiasAprobadas.Count,
            };
            return reporte;
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

        private Alumno BuscarAlumnoConMasCarrerasYMateriasAprobadas()
        {
            Alumno mejorAlumno = null;
            int maxAprobadas = 0;
            
            foreach (Alumno alumno in uba.Alumnos)
            {
                if (alumno.Carreras.Count > 1)
                {
                    // Contamos materias únicas aprobadas sin duplicados
                    List<int> materiasAprobadas = new List<int>();

                    foreach (Examen ex in alumno.Examenes)
                    {
                        if (ex.Nota >= 4 && !materiasAprobadas.Contains(ex.IdMateria))
                        {
                            materiasAprobadas.Add(ex.IdMateria);
                        }
                    }

                    if (materiasAprobadas.Count > maxAprobadas)
                    {
                        maxAprobadas = materiasAprobadas.Count;
                        mejorAlumno = alumno;
                    }
                }
            }
             return mejorAlumno;
        }

        private List<string> buscarMateriasAlumno(int idAlumno)
        {
            Alumno alumno = buscarAlumno(idAlumno);
            List<string> materiasDesregularizadas = new List<string>();
           
            foreach (Examen ex in alumno.Examenes)
            {
                Materia materia = null;
                
                if(ex.Nota < 4 && (ex.Fecha.AddYears(2) < DateTime.Today))
                {
                    foreach(Carrera carrera in alumno.Carreras)
                    {
                        foreach(Materia m in carrera.Materias)
                        {
                            if(m.Id == ex.IdMateria)
                            {
                                materia = m;
                                break;
                            }
                        }

                        if (materia != null)
                            break;
                    }

                    if (materia != null)
                    {
                        materiasDesregularizadas.Add(materia.Id + " - " + materia.Nombre);
                    }
                }
            }
            return materiasDesregularizadas;
        }
    }
}
