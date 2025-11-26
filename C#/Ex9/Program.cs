using System;

public class Pessoa
{
    private string nome;
    private int idade;
    private string id;
   
    public string Nome
    {
        get { return nome; }
        private set { nome = value; }
    }
    
    public int Idade
    {
        get { return idade; }
        private set { idade = value; }
    }

    public string ID
    {
        get { return id; }
        private set { id = value; }
    }

    public Pessoa(string nome, int idade, string id)
    {
        Nome = nome;
        Idade = idade;
        ID = id;
    }

    public void ApresentarInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"ID: {ID}");
    }
}

public class Estudante : Pessoa
{
    private string serie;
  
    public string Serie
    {
        get { return serie; }
        private set { serie = value; }
    }

    public Estudante(string nome, int idade, string id, string serie)
        : base(nome, idade, id)  
    {
        Serie = serie;
    }

    public new void ApresentarInformacoes()
    {
        base.ApresentarInformacoes();   
        Console.WriteLine($"Série: {Serie}");
    }
}

public class Professor : Pessoa
{
    private string disciplina;
 
    public string Disciplina
    {
        get { return disciplina; }
        private set { disciplina = value; }
    }

   
    public Professor(string nome, int idade, string id, string disciplina)
        : base(nome, idade, id) 
    {
        Disciplina = disciplina;
    }

    public new void ApresentarInformacoes()
    {
        base.ApresentarInformacoes();  
        Console.WriteLine($"Disciplina: {Disciplina}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine();

        Estudante estudante = new Estudante(nome, 15, "E001", "9º ano");
        Console.WriteLine("Informações do Estudante:");
        estudante.ApresentarInformacoes();

        Console.WriteLine();  

        Professor professor = new Professor("Carlos", 35, "P001", "Matemática");
        Console.WriteLine("Informações do Professor:");
        professor.ApresentarInformacoes();
    }
}
