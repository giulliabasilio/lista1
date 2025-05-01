using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baze;
            int altura;
            int area;

            Console.Write("informe o valor da base do retangulo: ");
            baze= int.Parse(Console.ReadLine());

            Console.Write("informe o valor da altura do retangulo: ");
            altura= int.Parse(Console.ReadLine());

            area = baze * altura;

            Console.WriteLine("o valor da area de um retangulo que tem base {0}, altura {1} é {2}", baze, altura, area);
       



        }
    }
}
