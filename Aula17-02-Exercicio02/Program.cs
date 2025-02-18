using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_02_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, r, s;
            Console.WriteLine("Digite três números: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            r = Math.Pow(a + b, 2);
            s = Math.Pow(b + c, 2);

            d = ((r + s) / 2);

            Console.WriteLine($"O resultado é: {d:F2}");
            Console.ReadKey();

        }
    }
}
