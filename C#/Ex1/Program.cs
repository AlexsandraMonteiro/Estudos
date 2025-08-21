// Programa para calcular a média de notas de um aluno
// e determinar se ele foi aprovado, reprovado ou está em recuperação.

using System;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            float trabalho1, trabalho2, prova1, prova2;
            float media = 0;

            Console.WriteLine("== Digite suas notas a baixo ==");
            Console.Write("Trabalho N1: ");
            trabalho1 = float.Parse(Console.ReadLine());
            Console.Write("Prova N1: ");
            prova1 = float.Parse(Console.ReadLine());
            Console.Write("Trabalho N2: ");
            trabalho2 = float.Parse(Console.ReadLine());
            Console.Write("Prova N2: ");
            prova2 = float.Parse(Console.ReadLine());

            media = ((trabalho1 * 0.30f) + (prova1 * 0.70f) + (trabalho2 * 0.30f) + (prova2 * 0.70f)) / 2;

            Console.WriteLine("Sua média é " + media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media >= 3)
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

        }
    }
}
     
