using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidalon.Sierra.Tp01
{
    class Calculadora
    {
        //calculo si  es "/" es por "0" el resultado = 0
        public static double  operar (Numero numeroUno, Numero numeroDos, string operadores)
        {
            double resultado = 0;

            switch (operadores)//validarOperador (operadores))
            {
                case "+":
                            resultado = numeroUno.getNumero() + numeroDos.getNumero();
                            return resultado;
                        
                case "-":
                            resultado = numeroUno.getNumero() - numeroDos.getNumero();
                            return resultado;
                        
                case "*":
                            resultado = numeroUno.getNumero() * numeroDos.getNumero();
                            return resultado;
                        
                case "/":
                            if (numeroDos.getNumero() ==0)
                            {
                                resultado = 0;
                            }
                            else
                            {
                                resultado = numeroUno.getNumero() / numeroDos.getNumero();
                            }
                            return resultado;
            }
            return resultado;
        }

        //validar carracter correcto

        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
                return operador;
            }
            else
            {
                return operador;
            }
            
        }


    }
}
