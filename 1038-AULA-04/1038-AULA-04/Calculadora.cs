using System;
namespace _1038_AULA_04
{
    public class Calculadora
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public double Soma()
        {
            return valor1 + valor2;
        }

        public double Subtração()
        {
            return valor1 - valor2;
        }

        public double Multiplicação()
        {
            return valor1 * valor2;
        }

        public double Divisão()
        {
            return valor1 / valor2;
        }
    }
}

