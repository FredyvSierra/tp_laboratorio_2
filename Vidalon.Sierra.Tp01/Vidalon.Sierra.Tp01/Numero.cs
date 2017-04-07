using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidalon.Sierra.Tp01
{
    class Numero
    {
        private double _numero;

        //constructores
        public double getNumero()
        {
            return this._numero;
        }

        public Numero()
        { 
            this._numero = 0;
        }
        public Numero(double numeroAux)
        {
            this._numero = numeroAux;
        }

        // recibe string y consigura el formato
        public Numero(string numeroAux)
        {
            this.setNumero(numeroAux);
        }

        //seteo el numero

        private void setNumero(string numeroAux)
        {
            this._numero = validarNumero(numeroAux);
        }
        // validar  numero ingresado como double
        private static double validarNumero(string numeroString)
        {
            double numeroValidado = 0;

            double.TryParse(numeroString, out numeroValidado);
            return numeroValidado;
        }

    }
}
