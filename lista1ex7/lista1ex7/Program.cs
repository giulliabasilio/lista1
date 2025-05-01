using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhas, km;

            Console.Write("Digite a quantidade de milhas marítimas: ");
            milhas = double.Parse(Console.ReadLine());

            km = (milhas * 1852) / 1000;

            Console.WriteLine("{0} milhas marítimas equivalem a {1} km", milhas, km);
        }
    }
}
