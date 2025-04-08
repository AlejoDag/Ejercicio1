using Facultad.Persistencia;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad
{
    public partial class FormInicio : Form
    {
        PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1) Validaciones

            // 1.1) Validaciones de integridad de datos

            // 1.) Validaciones de negocio

            // 1.1) Longitud de usuario (mayor igual a 6)

            // 1.2) Longitud de password (mayor igual a 6)

            // 1.3) Primero Login? -> Cambio password

            // 1.4) Expira password?

            // 2) Redirigir
            foreach (string linea in File.ReadAllLines(@"C:\Users\--\Desktop\Alejo\CAI\GitHub\Ejercicio1\Facultad\Facultad\Datos\")) 
            {
                var campos = linea.Split(',');

                string usuarioCsv = campos[0];
                string passCsv = campos[1];
                DateTime fechaPrimerLogin = DateTime.Parse(campos[2]);
                DateTime fechaExpiracionPass = DateTime.Parse(campos[3]);
                bool encontrado = false;

                if (txtUsuario.Text == usuarioCsv && txtPassword.Text == passCsv)
                {
                    encontrado = true;

                    if (fechaPrimerLogin == DateTime.MinValue)
                    {
                        MessageBox.Show("Debe cambiar su contraseña al ser su primer ingreso.");
                        return;
                    }

                    // Validación: ¿la contraseña expiró?
                    if (fechaExpiracionPass < DateTime.Now)
                    {
                        MessageBox.Show("Su contraseña ha expirado.");
                        return;
                    }

                    this.Hide();
                    FormMenu formMenu = new FormMenu();
                    formMenu.ShowDialog();
                }
                if (!encontrado)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

        }

        private List<String> obtenerUsuarios()
        {
            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");

            return listado;
        }

    }
}
