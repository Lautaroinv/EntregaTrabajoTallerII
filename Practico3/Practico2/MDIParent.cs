using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pequenoForm = new Form1();
            pequenoForm.MdiParent = this;
            pequenoForm.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la ventana hija
            Form1 pequenoForm = new Form1();

            // Establecer el MDIParent del formulario hijo como el MDIParent1 (formulario principal)
            pequenoForm.MdiParent = this;

            // Mostrar la ventana hija
            pequenoForm.Show();
        }
    }
}
