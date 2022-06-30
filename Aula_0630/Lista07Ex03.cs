using System;

class Program {
  public static void Main() {
    Paciente p = new Paciente { Nome = "Lucas",
      Nascimento = DateTime.Parse("2000-08-30") };
    Console.WriteLine(p.Nome);
    Console.WriteLine(p.Idade);
    Console.WriteLine(p.Idade2);
  }
}

class Paciente {
  private string nome;
  private DateTime nascimento;
  public string Nome {
    get { return nome; }
    set { nome = value; }
  }
  public DateTime Nascimento {
    get { return nascimento; }
    set { nascimento = value; }
  }
  public string Idade {
    get {
      DateTime hoje = DateTime.Now;
      int anos = hoje.Year - nascimento.Year;
      int meses = hoje.Month - nascimento.Month;
      if (meses < 0) {
        meses += 12;
        anos--;
      }
      return $"{anos} ano(s) e {meses} mes(es)";
    }
  }
  public string Idade2 {
    get {
      DateTime hoje = DateTime.Now;
      TimeSpan tempo = hoje - nascimento;
      int dias = tempo.Days;
      int anos = dias / 365;
      dias = dias % 365;
      int meses = dias / 30;
      return $"{anos} ano(s) e {meses} mes(es)";
    }
  }
}