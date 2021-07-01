using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private float numero1;
        private float numero2;
        private string operacionRealizada;
        private DateTime fecha;
        private float resultado;

        public Calculadora(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string OperacionRealizada { get => operacionRealizada; set => operacionRealizada = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Resultado { get => resultado; set => resultado = value; }

        public float Sumar(float _num1, float _num2)
        {
            float resultado = _num1 + _num2;
            return resultado;
        }
        public float Restar(float _num1, float _num2)
        {
            float resultado = _num1 - _num2;
            return resultado;
        }
        public float Multiplicar(float _num1, float _num2)
        {
            float resultado = _num1 * _num2;
            return resultado;
        }
        public float Dividir(float _num1, float _num2)
        {
            float resultado = _num1 / _num2;
            return resultado;
        }

        public string MostrarCalculo()
        {
            return fecha.ToShortDateString()+ " "+ fecha.ToShortTimeString()+ "-->"+ Numero1 + OperacionRealizada+ Numero2 +"="+ Resultado;
        }
    }
}
