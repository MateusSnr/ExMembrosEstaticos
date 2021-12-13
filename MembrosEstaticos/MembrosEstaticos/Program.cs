using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            ConversorDeMoeda.CotacaoDolar = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nQuantos dólares você vai comprar: ");
            ConversorDeMoeda.QtdASerComprada = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nValor a ser pago em reais: " + ConversorDeMoeda.ValorASerPagoEmReais().ToString("F2", CultureInfo.InvariantCulture) + "\n");

        }
    }
}
