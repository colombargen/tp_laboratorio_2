using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {          
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Limpia los textBox y el Label que contienen los numeros que estan operando. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// El boton "=" es aquel que arroja el resultado de la operacion informada.
        /// instancia un objeto calculadora. 
        /// crea : una variable local tipo string que almacena el dato de la operaciona efectuar segun el comboBox.
        /// dos instancias de la clase numero (n1 y n2) que recibe los string de los 2 textBox.
        /// un double que recibe el resultado de la funcion operar que resuelve la cuenta solicitada.
        /// Finalmente muestra el resultado en el label pero convirtiendolo a string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora c = new Calculadora();
            string oper = cmbOperacion.Text;
            Numero n1 = new Numero(txtNumero1.Text);
            Numero n2 = new Numero(txtNumero2.Text);
            double res = c.operar(n1, n2, oper);
            lblResultado.Text = res.ToString();            
        }
    }
}
