using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            borrarMensajeError();

            if ( string.IsNullOrEmpty( TDni.Text ) || string.IsNullOrEmpty(TApellido.Text) || string.IsNullOrEmpty(TNombre.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            validarCampos();

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if( ask == DialogResult.Yes)
            {
                ModificarLabel();
                MessageBox.Show("El Cliente: " + LModificar.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK,  MessageBoxIcon.Information );

            } 

        }

        private void ModificarLabel() 
        { 
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;

            string nombreCompleto = nombre + " " + apellido;

            LModificar.Text = nombreCompleto;
        }


        // ****** PARA VALIDAR CAMPOS DE TEXTO Y RESTRINGIR CARACTERES *******

        private bool validarCampos() 
        {
            bool validacion = true;

            if ( TDni.Text == "")
            {
                validacion = false;
                errorProvider1.SetError( TDni, "Ingrese el DNI");
            }

            if (TApellido.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(TApellido, "Ingrese el apellido");
            }

            if (TNombre.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(TNombre, "Ingrese el nombre");
            }

            return validacion;
        }


        private void borrarMensajeError()
        {
            errorProvider1.SetError(TDni, "");
            errorProvider1.SetError(TApellido, "");
            errorProvider1.SetError(TNombre, "");
        }


        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Para verificar si la tecla presionada no es un número y no es una tecla de control
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Para cancelar la entrada de caracteres no válidos
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
    
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Esta a punto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();

                LModificar.Text = "modificar";
                MessageBox.Show("El Cliente: " + LModificar.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
