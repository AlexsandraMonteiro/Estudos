// Exercício para descobrir qual tipo era o número digitado

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string valor = Console.ReadLine();

        bool num1 = (int.TryParse(valor, out var inteiro));
        bool num2 = (float.TryParse(valor, out var quebrado));
        bool num3 = (bool.TryParse(valor, out var letras));

        if (num1 == true)
        {
            Console.WriteLine("É int");
        } else if (num2 == true)
        {
            Console.WriteLine("É float");
        } else if (num3 == true)
        {
            Console.WriteLine("É bool");
        } else
        {
            Console.WriteLine("É string");
        }
    }
}