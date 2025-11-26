class Program
{
    static void Main()
    {
        int[,] matriz = new int[4,5] { { 4,5,6,7,8}, 
            { 9,8,7,6,5},
            { 1,2,3,4,5},
            { 0,1,2,3,4} };

        int qtdPares = 0;
        int qtdMul = 0;

        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 5; j++)
            {
                if (matriz[i,j] % 2 == 0)
                {
                    qtdPares++;
                }

                if (matriz[i,j] % 5 == 0)
                {
                    qtdMul++;
                }
            }
        }

        Console.WriteLine($"Quantidade de números pares: {qtdPares}");
        Console.WriteLine($"Quantidade de números múltiplos de 5: {qtdMul}");
    }
}