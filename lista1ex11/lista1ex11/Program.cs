using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, resultado;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine());

            resultado = Math.Pow(x, y);

            Console.WriteLine("{0} elevado a {1} é: {2}", x, y, resultado);
        }
    }
}
