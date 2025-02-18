using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite as notas do aluno: ");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)/10);

            Console.WriteLine($"A média da nota do aluno é: {media:F2}");
            Console.ReadKey();
        }
    }
}
