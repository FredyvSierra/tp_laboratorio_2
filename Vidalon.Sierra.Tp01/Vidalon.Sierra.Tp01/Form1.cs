using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidalon.Sierra.Tp01
{
    public partial class Form1 : Form
    {
        //public Numero numeroUno;
        //public Numero numeroDos;
        public double resultado;
        public string operad = "";
        ////public Calculadora operacion;

        public Form1()
        {
            InitializeComponent();
            //declaro y  genero 
            //asignacion  de los operadores que deje c
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //creo el valor que va a tomar el recuadro de textbox de la primera posicion
           // Numero numeroUn = new Numero(this.txtNumero1.Text);
            
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            //creo el valor que va a tomar el recuadro de textbox de la primera posicion
            //Numero numeroDo = new Numero(this.txtNumero2.Text);
        }


        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numeroUn = new Numero(this.txtNumero1.Text);
            Numero numeroDo = new Numero(this.txtNumero2.Text);
            Calculadora calc = new Calculadora();
            string operad = cmbOperacion.Text;
            Calculadora.validarOperador(operad);
            resultado = Calculadora.operar(numeroUn, numeroDo, operad);
            lblResultado.Text = resultado.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        //codigo para limpiar los registros con el Boton CC
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.operad = "";
            this.lblResultado.Text = string.Empty;
        }
    }
}
