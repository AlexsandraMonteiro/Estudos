class Program
{
    static void Main()
    {
        int[,] num = new int[,] { { 4, 3, 2 }, 
            { 3, 2, 1 }, 
            { 6, 4, 0 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (num[i, j] % 2 == 0)
                {
                    Console.Write($"{num[i, j]} ");
                }
            }
        }
    }
}