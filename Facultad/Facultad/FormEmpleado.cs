using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla no permitida
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un item seleccionado
            if (Roles.SelectedItem != null)
            {
                // Copiar el item seleccionado al TextBox
                txtRol.Text = Roles.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ítem del ListBox.");
            }
        }
    }
}
