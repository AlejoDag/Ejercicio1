using Facultad.Persistencia;
using Negocio;
using Facultad.Entidades;
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
            bool permiteAvanzar = true;

            if (txtUsuario.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("El nombre de usuario no puede estar vacio");
            }

            if (txtPassword.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("La contraseña no puede estar vacia.");
            }

            if (txtUsuario.Text.Length < 6 || txtPassword.Text.Length < 6)
            {
                permiteAvanzar = false;
                MessageBox.Show("Usuario y contraseña deben tener al menos 6 caracteres.");
            }

            permiteAvanzar = validarCredenciales(txtUsuario.Text, txtPassword.Text);

            if (permiteAvanzar)
            {
                validarEstadoClave(txtUsuario.Text);
            }

            // 2) Redirigir
            if (permiteAvanzar)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }
        }

        private Boolean validarCredenciales(String usuarioLogin, string passwordLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);
            if (credencialLogin == null)
            {
                return false;
                MessageBox.Show("Usuario no existe");
            }
            else
            {
                if (!credencialLogin.Password.Equals(passwordLogin))
                {
                    return false;
                    MessageBox.Show("Contraseña incorrecta");
                }
            }

            return true;
        }

        private void validarEstadoClave(String usuarioLogin)
        {
            Credencial credencialLogin = buscarUsuario(usuarioLogin);

            if (credencialLogin.FechaUltimoIngreso == null)
            {
                // Redirigir al cambio de contraseña
            }

            if (credencialLogin.FechaUltimoIngreso < DateTime.Today.AddDays(-30))
            {
                // Redirigir al cambio de contraseña
            }

        }

        private Credencial buscarUsuario(String usuarioLogin)
        {
            Credencial credencialLogin = null;

            foreach (Credencial credencial in obtenerCredenciales())
            {
                if (credencial.Usuario.Equals(usuarioLogin))
                {
                    credencialLogin = credencial;
                }
            }

            return credencialLogin;
        }

        private List<Credencial> obtenerCredenciales()
        {
            List<String> listado = persistenciaUtils.LeerRegistro("credenciales.csv");
            List<Credencial> listadoCredenciales = new List<Credencial>();

            foreach (String registro in listado)
            {
                Credencial credencial = new Credencial(registro);
                listadoCredenciales.Add(credencial);
            }

            return listadoCredenciales;
        }

    }
}