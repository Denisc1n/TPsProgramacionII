using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Methods
        private static string ValidarOperador( string operador )
        {
            switch ( operador.Trim() )
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    return "+";
            }
            return operador;
        } 

        public double Operar( Numero num1, Numero num2, string operador )
        {
            string result = ValidarOperador( operador );
            double retValue = 0;

            if ( result.Trim() == "+" ) retValue = num1 + num2;
            if ( result.Trim() == "-" ) retValue = num1 - num2;
            if ( result.Trim() == "*" ) retValue = num1 * num2;
            if ( result.Trim() == "/" ) retValue = num1 / num2;

            return retValue;

        }
        #endregion
    }

}
