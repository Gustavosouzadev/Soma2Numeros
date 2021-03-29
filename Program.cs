using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double X, Y, soma;

            Console.WriteLine("Cálculo da soma entre dois números.");
            Console.WriteLine("");
            Console.Write("Digite o primeiro numero: ");
            X = Convert.ToDouble (Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            Y = Convert.ToDouble (Console.ReadLine());

            soma = X + Y;

            Console.WriteLine("");
            Console.WriteLine($"Soma: {soma}");
        }
    }
}
