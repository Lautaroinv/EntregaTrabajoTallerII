﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;

            string nombreCompleto = apellido + " " + nombre;

            textBoxResultado.Text = nombreCompleto;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
