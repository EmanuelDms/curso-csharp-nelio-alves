using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.38578;
            Console.Write(saldo.ToString("F2", CultureInfo.InvariantCulture));

            // placeholder
            int idade = 32;
            string nome = "Maria";

            Console.WriteLine("\n{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
        }
    }
}
