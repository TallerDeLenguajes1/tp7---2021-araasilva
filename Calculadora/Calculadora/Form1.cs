using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Calculadora Operacion = new Calculadora(DateTime.Now);
        List<Calculadora> ListaDeCalculos = new List<Calculadora>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtOperaciones.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            txtOperaciones.Text += ",";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            Operacion.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Operacion.OperacionRealizada = "+";
            limpiar();

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            Operacion.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Operacion.OperacionRealizada = "-";
            limpiar();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            Operacion.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Operacion.OperacionRealizada = "*";
            limpiar();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Operacion.Numero1 = Convert.ToSingle(txtOperaciones.Text);
            Operacion.OperacionRealizada = "/";
            limpiar();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Operacion.Numero2 = Convert.ToSingle(txtOperaciones.Text);
            switch (Operacion.OperacionRealizada)
            {
                case "+":
                    {
                        Operacion.Resultado = Operacion.Sumar(Operacion.Numero1, Operacion.Numero2);
                        AnadirALasListas();

                    }
                    break;
                case "-":
                    {
                        Operacion.Resultado = Operacion.Restar(Operacion.Numero1, Operacion.Numero2);
                        AnadirALasListas();
                    }
                    break;
                case "*":
                    {
                        Operacion.Resultado= Operacion.Multiplicar(Operacion.Numero1, Operacion.Numero2);
                        AnadirALasListas();
                    }
                    break;
                case "/":
                    {
                        if (Operacion.Numero2 != 0)
                        {
                            Operacion.Resultado = Operacion.Dividir(Operacion.Numero1, Operacion.Numero2);
                            AnadirALasListas();
                        }
                        else txtOperaciones.Text = "ERROR";

                    }
                    break;
            }


        } 
        private void AnadirALasListas()
        {
            txtOperaciones.Text = Operacion.Resultado.ToString();
            ListaDeCalculos.Add(Operacion);
            listBox1.Items.Add(Operacion.MostrarCalculo());
        }
     

        private void C_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void txtOperaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}