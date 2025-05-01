using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro, raio, area;

            Console.Write("Digite o diâmetro do círculo: ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;
            area = Math.PI * raio * raio;

            Console.WriteLine("A área de um círculo com diâmetro {0} é: {1}", diametro, area);
        }
    }
}
