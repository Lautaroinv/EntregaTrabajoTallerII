using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
            openFileDialog1.Title = "Seleccionar una imagen";

            if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog1.FileName;

                picFoto.Image = Image.FromFile(rutaImagen);

                txtRutaFoto.Text = rutaImagen;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrarMensajeError();
            validarCampos();

            if (validarCampos() == true)
            {

                int indice = dtgvPersonas.Rows.Add();

                dtgvPersonas.Rows[indice].Cells[0].Value = txtApellido.Text;
                dtgvPersonas.Rows[indice].Cells[1].Value = txtNombre.Text;
                dtgvPersonas.Rows[indice].Cells[2].Value = dateFechaNac.Text;
                dtgvPersonas.Rows[indice].Cells[3].Value = rbHombre.Text;

                if (rbMujer.Checked == true)
                {
                    dtgvPersonas.Rows[indice].Cells[3].Value = rbMujer.Text;
                }

                dtgvPersonas.Rows[indice].Cells[4].Value = "Eliminar";
                dtgvPersonas.Rows[indice].Cells[5].Value = txtSaldo.Text;
                dtgvPersonas.Rows[indice].Cells[6].Value = Image.FromFile(txtRutaFoto.Text);
                dtgvPersonas.Rows[indice].Cells[7].Value = txtRutaFoto.Text;

            }

            if( decimal.Parse(txtSaldo.Text) <= 50)
            {
                int indice = dtgvPersonas.Rows.Count;
                dtgvPersonas.Rows[indice - 1].DefaultCellStyle.BackColor = Color.Red;
            }

            borrarCampos();
        }


        private void borrarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtSaldo.Text = "";
            txtRutaFoto.Text = "";

            rbHombre.Checked = true;
            picFoto.Image = Practico5.Properties.Resources.usuario;

        }


        private void dtgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( this.dtgvPersonas.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar este registro?",
                                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button1);

                if( ask == DialogResult.Yes)
                {
                    dtgvPersonas.Rows.Remove(dtgvPersonas.CurrentRow);
                    MessageBox.Show("Se ha eliminado el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                // Convierte la primera letra en mayúscula y las demás en minúscula
                txtNombre.Text = txtNombre.Text.First().ToString().ToUpper() 
                                     + txtNombre.Text.Substring(1).ToLower();
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                // Convierte la primera letra en mayúscula y las demás en minúscula
                txtApellido.Text = txtApellido.Text.First().ToString().ToUpper()
                                   + txtApellido.Text.Substring(1).ToLower();
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


        private bool validarCampos()
        {
            bool validacion = true;

            if (txtApellido.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtApellido, "Ingrese el apellido");
            }

            if (txtNombre.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
            }

            if (txtSaldo.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtSaldo, "Ingrese el saldo");
            }

            if(txtRutaFoto.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(txtRutaFoto, "Ingrese la ruta de la imagen");
            }


            return validacion;
        }

        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtSaldo, "");
            errorProvider1.SetError(txtRutaFoto, "");
        }

        private void dtgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvPersonas.Columns["Sexo"].Index && e.RowIndex >= 0)
            {
                //**** Obtiene el valor de la celda de la columna de sexo para la fila seleccionada *****
                string valorSexo = dtgvPersonas.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();

                //**** Compara el valor de la celda con las opciones de sexo y selecciona el RadioButton correspondiente
                if (valorSexo == "Hombre")
                {
                    rbHombre.Checked = true;
                }
                else
                {
                    rbMujer.Checked = true;
                }

            }
        }
    }
}
