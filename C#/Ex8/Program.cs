
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando um livro
        Livro livro = new Livro("Dom Casmurro", "Machado de Assis", 300);

        // Exibindo os dados do livro
        livro.ExibirInformacoes();

        // Tempo de leitura baseado em minutos por página
        int tempoMinutos = livro.CalcularTempoLeitura(2); // 2 minutos por página
        Console.WriteLine($"Tempo estimado de leitura: {tempoMinutos} minutos");

        // Tempo baseado em páginas por hora
        double tempoHoras = livro.CalcularTempoLeituraHoras(50); // 50 páginas por hora
        Console.WriteLine($"Tempo estimado de leitura: {tempoHoras:F2} horas");
    }
}

public class Livro
{
    // Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    // Construtor
    public Livro(string titulo, string autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    // Exibir informações do livro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Número de páginas: {NumeroPaginas}");
    }

    // Cálculo do tempo de leitura informando minutos por página
    public int CalcularTempoLeitura(int minutosPorPagina)
    {
        return NumeroPaginas * minutosPorPagina;
    }

    // Cálculo do tempo de leitura informando leitura em páginas por hora
    public double CalcularTempoLeituraHoras(double paginasPorHora)
    {
        if (paginasPorHora <= 0)
            throw new ArgumentException("A velocidade de leitura deve ser maior que zero.");

        return NumeroPaginas / paginasPorHora;
    }
}
