using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {

            InitializeComponent();
            this.cmbOperador.Items.Add( "+" );
            this.cmbOperador.Items.Add( "-" );
            this.cmbOperador.Items.Add( "*" );
            this.cmbOperador.Items.Add( "/" );
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region events

        private void btnLimpiar_Click( object sender, EventArgs e )
        {
            this.Limpiar();
        }

        private void btnCerrar_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnOperar_Click( object sender, EventArgs e )
        {
            
            if ( this.txtNumero2.Text.Trim() == "0" && this.cmbOperador.Text.Trim() == "/" )
            {
                this.lbResultado.Text = "Error";
            }
            else
            {
                double labelValue = Operar( this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text );
                this.lbResultado.Text = string.Format( "{0:0.##}", labelValue );
            }
        }

        private void btnConvertirABinario_Click( object sender, EventArgs e )
        {
            if ( !string.IsNullOrEmpty( this.lbResultado.Text ) && this.lbResultado.Text != "Error" )
            {
                Numero numberToConvert = new Numero( this.lbResultado.Text );
                this.lbResultado.Text = numberToConvert.DecimalBinario( this.lbResultado.Text );
            }
            else
                return;


        }

        private void btnConvertirADecimal_Click( object sender, EventArgs e )
        {
            if ( !string.IsNullOrEmpty( this.lbResultado.Text ) && this.lbResultado.Text != "Error" )
            {
                Numero numberToConvert = new Numero( this.lbResultado.Text );
                this.lbResultado.Text = numberToConvert.BinarioDecimal( this.lbResultado.Text );
            }
            else
                return;
        }

        #endregion

        #region Methods

        private static double Operar( string numero1, string numero2, string operador )
        {
            Numero numUno = new Numero( numero1 );
            Numero numDos = new Numero( numero2 );
            Calculadora calculadora = new Calculadora();
            double retVal = calculadora.Operar( numUno, numDos, operador );
            return retVal;
        }

        private void Limpiar()
        {
            foreach ( Control control in this.Controls )
            {

                if ( control.GetType() == typeof( TextBox ) || control.GetType() == typeof( ComboBox )
                    || control.GetType() == typeof( Label ) )
                {
                    control.Text = "";
                }

            }
        }

        #endregion

    }

}


