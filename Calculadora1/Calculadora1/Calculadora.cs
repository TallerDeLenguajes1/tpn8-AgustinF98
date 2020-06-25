using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        private float num1;
        private float num2;
        private float resultado;
        private char operador;
        private DateTime fecha;

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        public char Operador { get => operador; set => operador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public float Suma()
        {
            return Num1 + Num2;
        }

        public float Resta()
        {
            return Num1 - Num2;
        }

        public float Multiplicacion()
        {
            return Num1 * Num2;
        }

        public float Division()
        {
            if (Num2 != 0)
            {
                return Num1 / Num2;
            }
            else
            {
                return -9999;
            }
        }

        public string MostrarLista()
        {
            return Convert.ToString(Fecha) + " ---> " + Convert.ToString(Num1) + Convert.ToString(Operador) + Convert.ToString(Num2) + " = " + Convert.ToString(Resultado);
        }
    }
}