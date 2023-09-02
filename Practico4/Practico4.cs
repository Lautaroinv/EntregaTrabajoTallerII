using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Practico4 : Form
    {
        public Practico4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }


        private bool ValidarCampos()
        {
            bool validacion = true;

            if ( TDesde.Text == "" )
            {
                validacion = false;
                errorProvider1.SetError( TDesde, "Ingrese el primer numero");
            }

            if (THasta.Text == "")
            {
                validacion = false;
                errorProvider1.SetError(THasta, "Ingrese el segundo numero");
            }

            return validacion;
        }

        private void borrarMensajeError()
        {
            errorProvider1.SetError(TDesde, "");
            errorProvider1.SetError(THasta, "");
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
            }

        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            borrarMensajeError();
            ValidarCampos();

            if (ValidarCampos() == true )
            {
                listarNumeros();
                graficarNumeros();
            }
        }

        private void graficarNumeros()
        {
            
            int numDesde = int.Parse(TDesde.Text);
            int numHasta = int.Parse(THasta.Text);

            for (int i = numDesde; i <= numHasta; i++)
            {
                chart1.Series["Numeros"].Points.AddY(ListNumeros.Text);
            }

        }



        private void listarNumeros ()
        {
            int numDesde = int.Parse(TDesde.Text);
            int numHasta = int.Parse(THasta.Text);

            ListNumeros.Items.Clear(); 

            for (int i = numDesde; i < (numHasta + 1); i++)
            {
                ListNumeros.Items.Add(i);
            }
        
        }


        private bool esPar( int pNumero)
        { 
            bool esPar = false;

            if( pNumero % 2 == 0)
            {
                esPar = true;
            }

            return esPar;
        }

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            int numDesde = int.Parse(TDesde.Text);
            int numHasta = int.Parse (THasta.Text);

            ListNumeros.Items.Clear();

            for( int i = numDesde; i <= numHasta; i++)
            {
                if ( esPar(i) == true)
                {
                    ListNumeros.Items.Add(i);
                }

            }
        }

        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            int numDesde = int.Parse(TDesde.Text);
            int numHasta = int.Parse(THasta.Text);

            ListNumeros.Items.Clear();

            for (int i = numDesde; i <= numHasta; i++)
            {
                if (esPar(i) != true)
                {
                    ListNumeros.Items.Add(i);
                }

            }
        }


        private bool esPrimo( int pNumero)
        {
            bool esPrimo = true;
            int cantDivisores = 0;

            for (int i = 1; i <= pNumero; i++)
            {
                if ( pNumero % i == 0)
                {
                    cantDivisores++;
                }
            }

            if( cantDivisores != 2 ) 
            {
                esPrimo = false;
            }

            return esPrimo;
        }

        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            int numDesde = int.Parse(TDesde.Text);
            int numHasta = int.Parse (THasta.Text);

            ListNumeros.Items.Clear();

            for(int i = numDesde; i <= numHasta; i++)
            {
                if ( esPrimo(i) )
                {
                    ListNumeros.Items.Add(i);
                }
            }
        }
    }
}
