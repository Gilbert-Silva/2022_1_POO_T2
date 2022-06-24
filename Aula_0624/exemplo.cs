using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Aluno a1 = new Aluno("Gilbert", "1234",
                         DateTime.Parse("24/06/2022"));
    Aluno a2 = new Aluno("Eduardo", "4321",
                         DateTime.Parse("20/06/2000"));
    Aluno a3 = new Aluno("Jorgiano", "5678",
                         DateTime.Parse("20/05/1990"));
    Aluno a4 = new Aluno("Lucena", "8765",
                         DateTime.Parse("05/05/1990"));
    Aluno a5 = new Aluno("Minora", "1212",
                         DateTime.Parse("05/06/1990"));
    Aluno[] v = { a1, a2, a3, a4, a5 };
    Relatorio.Aniversariantes(v, 6);
    Console.WriteLine();

    Professor p1 = new Professor("Sales", "Redes",
                   DateTime.Parse("05/06/1990"));   
    Professor p2 = new Professor("Assis", "Hardware",
                   DateTime.Parse("05/06/1995"));   
    Professor p3 = new Professor("Teobaldo", "Hardware",
                   DateTime.Parse("05/03/1995")); 
    Professor[] w = { p1, p2, p3 };
    //w[0] = null;
    Relatorio.Aniversariantes(w, 6);
    Console.WriteLine();

    IAniversariante[] z = { a1, a2, a3, a4, a5, p1, p2, p3 };
    Relatorio.Aniversariantes(z, 6);

    /*
    object a = new Aluno("nome1", "mat1", DateTime.Now);
    IAniversariante b = new Aluno("nome2", "mat2", DateTime.Now);
    IComparable c = new Aluno("nome3", "mat3", DateTime.Now);
    Aluno d = new Aluno("nome4", "mat4", DateTime.Now);

    Console.WriteLine(a.ToString());
    Console.WriteLine(b.GetNome());
    Console.WriteLine(b.GetNascimento());
    Console.WriteLine(c.CompareTo(d));
    Console.WriteLine(d.GetMatricula());
    */

  }
}

interface IAniversariante {         // IComparable
  DateTime GetNascimento();
  string GetNome();
}

class Relatorio {                    // Array
  public static void Aniversariantes(IAniversariante[] v, int m) {
    Array.Sort(v);
    foreach(IAniversariante a in v) 
      if (a.GetNascimento().Month == m)
        Console.WriteLine($"{a.GetNome()}" +
                          $" - {a.GetNascimento():dd/MM}");
  }
  /*
  public static void Aniversariantes(Aluno[] v, int m) {
    foreach(Aluno a in v) 
      if (a.GetNascimento().Month == m)
        Console.WriteLine($"{a.GetNome()}" +
                          $" - {a.GetNascimento():dd/MM}");
  }
  public static void Aniversariantes(Professor[] v, int m) {
    foreach(Professor a in v) 
      if (a.GetNascimento().Month == m)
        Console.WriteLine($"{a.GetNome()}" +
                          $" - {a.GetNascimento():dd/MM}");
  }
  */
}

class Professor : IAniversariante, IComparable {    // Jogador
  private string nome, curso;
  private DateTime nascimento;
  public Professor(string nome, string curso, DateTime nascimento) 
  {
    this.nome = nome;
    this.curso = curso;
    this.nascimento = nascimento;
  }
  public int CompareTo(object obj) {
    IAniversariante p = (IAniversariante) obj;
    return this.nome.CompareTo(p.GetNome());
  }
  public string GetNome() {
    return nome;
  }
  public DateTime GetNascimento() {
    return nascimento;
  }
  public string GetCurso() {
    return curso;
  }
  public override string ToString() {
    return $"{nome} - {curso} - {nascimento:dd/MM/yyyy}";
  }
}

class Aluno : IAniversariante, IComparable {
  private string nome, matricula;
  private DateTime nascimento;
  public Aluno(string nome, string matricula, DateTime nascimento) {
    this.nome = nome;
    this.matricula = matricula;
    this.nascimento = nascimento;
  }
  public int CompareTo(object obj) {
    IAniversariante p = (IAniversariante) obj;
    return this.nome.CompareTo(p.GetNome());
  }
  public string GetNome() {
    return nome;
  }
  public DateTime GetNascimento() {
    return nascimento;
  }
  public string GetMatricula() {
    return matricula;
  }
  public override string ToString() {
    return $"{nome} - {matricula} - {nascimento:dd/MM/yyyy}";
  }
}