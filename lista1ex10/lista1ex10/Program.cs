using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, quantidadeDolares, valorEmReais;

            Console.Write("Digite a cotação do dólar (ex: 5.25): ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            quantidadeDolares = double.Parse(Console.ReadLine());

            valorEmReais = cotacao * quantidadeDolares;

            Console.WriteLine("{0} dólares equivalem a R$ {1}", quantidadeDolares, valorEmReais);
        }
    }
}
