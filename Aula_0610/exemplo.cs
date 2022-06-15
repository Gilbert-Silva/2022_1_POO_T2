using System;

class Program {
  public static void Main() {
    Aluno a = new Aluno("Lucas");
    Console.WriteLine(a.GetNome());
    Console.WriteLine(a);
    object b = new Aluno("Gilbert");
    Console.WriteLine( ((Aluno) b).GetNome());
    Console.WriteLine(b);
  }
}

class Aluno {
  private string nome;
  public Aluno(string nome) {
    this.nome = nome;
  }
  public string GetNome() {
    return nome;
  }
  public override string ToString() {
    return nome;
  }
}