using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, v4, media;

            Console.Write("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            v3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            v4 = double.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;

            Console.WriteLine("A média aritmética dos valores é: {0}", media);
        }
    }
}
