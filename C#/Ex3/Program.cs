using System;

class Ex3
{
    static void Main()
    {
        int[] num = new int[] { 1, 2, 5, 10, 4, 3, 20, 35 };
        int qtdpares = 0;
        int qtdmul = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] % 2 == 0)
            {
                qtdpares++;
            }
            if (num[i] % 5 == 0)
            {
                qtdmul++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {qtdpares}");
        Console.WriteLine($"Quantidade de números múltiplos de 5: {qtdmul}");
    }
}