using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0}°C equivalem a {1}°F", celsius, fahrenheit);
        }
    }
}
