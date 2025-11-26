using System;

public class Publicacao
{
    private string _titulo;
    private string _autor;
    private int _anoPublicacao;

    public Publicacao (string titulo, string autor, int anoPublicado)
    {
        this._titulo = titulo;
        this._autor = autor;
        this._anoPublicacao = anoPublicado; 
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Ano de Publicação: {_anoPublicacao}");  
    }
}

public class  Livro : Publicacao
{
    private int numeroPaginas;

    public Livro (string titulo, string autor, int anoPublicado, int numeroPaginas)
        : base(titulo, autor, anoPublicado)
    {
        this.numeroPaginas = numeroPaginas;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Número de Páginas: {numeroPaginas}");
    }
}

public class Revista : Publicacao
{
    private int numeroEdicao;

    public Revista(string titulo, string autor, int anoPublicado, int numeroEdicao) 
        : base(titulo, autor, anoPublicado)
    {
        this.numeroEdicao = numeroEdicao;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Número de Edição: {numeroEdicao}");
    }
}

public class Program
{
    public static void Main()
    {
        Livro livro = new Livro("1984", "George Orwell", 1949, 328);
        Console.WriteLine("Informações do Livro:");
        livro.ExibirInformacoes();

        Console.WriteLine();

        Revista revista = new Revista("National Geographic", "Vários Autores", 2021, 150);
        Console.WriteLine("Informações da Revista:");
        revista.ExibirInformacoes();
    }
}