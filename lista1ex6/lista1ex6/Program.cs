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
            double valor1, valor2, mediaGeometrica;

            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            mediaGeometrica = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A média geométrica de {0} e {1} é: {2}", valor1, valor2, mediaGeometrica);
        }
    }
}
