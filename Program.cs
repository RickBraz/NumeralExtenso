using System;
using Figgle;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            string texto = Console.ReadLine();
            int Numero = Convert.ToInt32(texto);
            string NumeroPorExtenso = Numero.ToWords();
            Console.WriteLine($"{Numero} => {NumeroPorExtenso}");
        }
    }
}
