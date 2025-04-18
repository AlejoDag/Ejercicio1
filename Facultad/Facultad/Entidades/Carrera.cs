using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Persistencia;
using Negocio;
using Facultad.Entidades;
using System.Security.Cryptography;

namespace Facultad.Entidades
{
    public class Carrera
    {
        int _id;
        List<Materia> _materias;
        String _nombre;

        public int Id { get => _id; set => _id = value; }
        public List<Materia> Materias { get => _materias; set => _materias = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Carrera(string registro)
        {
            String[] datos = registro.Split(';');
            this.Id = int.Parse(datos[0]);
            this._materias = buscarMaterias(this.Id);
            this.Nombre = datos[1];
        }

        private List<Materia> buscarMaterias(int idCarrera)
        {
            List<Materia> materias = new List<Materia>();

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<string> listadoMaterias = persistenciaUtils.LeerRegistro("materias.csv");

            int contador = 0;
            foreach (string registro in listadoMaterias)
            {
                if (contador == 0)
                {
                    contador++;
                    continue; // Saltar encabezado
                }

                string[] datos = registro.Split(';');

                string carrerasTexto = datos[6];

                string[] idsCarreras = carrerasTexto.Split(',');

                foreach (string id in idsCarreras)
                {
                    // Trim para eliminar espacios y comparar como int
                    if (int.TryParse(id.Trim(), out int idCarreraMateria))
                    {
                        if (idCarreraMateria == idCarrera)
                        {
                            materias.Add(new Materia(registro));
                            break;
                        }
                    }
                }
            }

            return materias;
        }

    }
}
