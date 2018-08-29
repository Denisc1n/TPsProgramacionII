using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        #region Properties
        public string SetNumero {
           
            set
            {
                this._numero = ValidarNumero( value );
            }
        }


        #endregion

        #region Constructors

        public Numero() { }

        public Numero( double value )
        {
            this._numero = value;
        }

        public Numero( string strNumero )
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Methods

        private double ValidarNumero( string strNumero )
        {
            double retDouble = 0;

            double.TryParse( strNumero, out retDouble );

            return retDouble;
        }

        public string BinarioDecimal( string binario )
        {

            return Convert.ToInt64( binario, 2 ).ToString();
        }

        public string DecimalBinario ( string numero )
        {
            bool check = double.TryParse( numero, out double retValue );

            return check == true ? DecimalBinario( retValue ) : "Numero Invalido";
        }


        public string DecimalBinario( double numero )
        {
            String result = Convert.ToString( Convert.ToInt32( numero.ToString(), 10 ), 2 );
            return result;
        }
        #endregion

        #region Operators

        public static double operator + ( Numero num1, Numero num2 )
        {
            return num1._numero + num2._numero;
        }

        public static double operator -( Numero num1, Numero num2 )
        {
            return num1._numero - num2._numero;
        }

        public static double operator *( Numero num1, Numero num2 )
        {
            return num1._numero * num2._numero;
        }

        public static double operator /( Numero num1, Numero num2 )
        {
            if ( num2._numero != 0 )
            {
                return num1._numero / num2._numero;
            }
            return -1;
        }
        #endregion
    }
}
