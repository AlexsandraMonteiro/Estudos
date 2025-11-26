class Program
{
    static void Main()
    {
        Console.Write("Total de voltas: ");
        int N = int.Parse(Console.ReadLine());

        double[] tempos = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Tempo da volta {i + 1}: ");
            tempos[i] = double.Parse(Console.ReadLine());
        }

        double melhorTempo = tempos[0];
        int melhorVolta = 1;
        double soma = tempos[0];

        for (int i = 1; i < N; i++)
        {
            soma += tempos[i];
            if (tempos[i] < melhorTempo)
            {
                melhorTempo = tempos[i];
                melhorVolta = i + 1;
            }
        }

        double media = soma / N;

        Console.WriteLine($"Melhor Tempo: {melhorTempo}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Melhor Volta: {melhorVolta}");

    }
}