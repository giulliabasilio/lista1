using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;
         

            Console.Write("informe o valor da diagonal do quadrado: ");
            diagonal= double.Parse(Console.ReadLine());

           

            area=  (diagonal* diagonal)/2;

            Console.WriteLine("o valor da area do quadrado que tem diagonal de {0} será {1}", diagonal, area);
        }
    }
}
