using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, p5, total, pagamento, troco;

            Console.Write("Digite o valor do primeiro produto: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo produto: ");
            p2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro produto: ");
            p3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quarto produto: ");
            p4 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quinto produto: ");
            p5 = double.Parse(Console.ReadLine());

            total = p1 + p2 + p3 + p4 + p5;

            Console.Write("Digite o valor do pagamento: ");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - total;

            Console.WriteLine("O total da compra é: R$ {0}", total);
            Console.WriteLine("O troco a ser devolvido é: R$ {0}", troco);
        }
    }
}
