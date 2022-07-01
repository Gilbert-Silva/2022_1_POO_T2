using System;
using System.Reflection;

class Program {
  
  public static void Main2()
  {
      Console.WriteLine ("\nReflection.MemberInfo");
      // Gets the Type and MemberInfo.
      Type myType = Type.GetType("Paciente");
      MemberInfo[] myMemberInfoArray = myType.GetMembers();
      // Gets and displays the DeclaringType method.
      Console.WriteLine("\nThere are {0} members in {1}.",
          myMemberInfoArray.Length, myType.FullName);
      Console.WriteLine("{0}.", myType.FullName);
      if (myType.IsPublic)
      {
          Console.WriteLine("{0} is public.", myType.FullName);
      }
      foreach (var x in myMemberInfoArray)
        Console.WriteLine(x);
  }
  
  public static void Main() {
    dynamic x;
    x = 10;
    Console.WriteLine(x);
    //Console.WriteLine(x.Nome);
    int y = 10;
    //Console.WriteLine(y.Nome);
    
    Paciente p = new Paciente { Nome = "Lucas",
      Nascimento = DateTime.Parse("2000-08-30") };
    Console.WriteLine(p.Nome);
    Console.WriteLine(p.GetNome());
    Console.WriteLine(p.Idade);
    Console.WriteLine(p.GetIdade());
    Console.WriteLine(p.Idade2);
    Paciente2 p2 = new Paciente2 { Nome = "Elder",
      Nascimento = DateTime.Parse("2000-08-30") };
    Console.WriteLine(p2.Nome);
    Console.WriteLine(p2.Idade);

    x = p;
    Console.WriteLine(x.Nome);
  }
}

class Paciente {
  private string nome;
  private DateTime nascimento;
  public string GetNome() {
    return nome;
  }
  public void SetNome(string value) {
    nome = value;
  }
  public string Nome {
    get { return nome; }
    set { nome = value; }
  }
  public DateTime Nascimento {
    get { return nascimento; }
    set { nascimento = value; }
  }
  public string GetIdade() {
      DateTime hoje = DateTime.Now;
      int anos = hoje.Year - nascimento.Year;
      int meses = hoje.Month - nascimento.Month;
      if (meses < 0) {
        meses += 12;
        anos--;
      }
      return $"{anos} ano(s) e {meses} mes(es)";
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

class Paciente2 {
  public string Nome { get; set; }
  public DateTime Nascimento { get; set; }
  public string Idade {
    get {
      DateTime hoje = DateTime.Now;
      int anos = hoje.Year - Nascimento.Year;
      int meses = hoje.Month - Nascimento.Month;
      if (meses < 0) {
        meses += 12;
        anos--;
      }
      return $"{anos} ano(s) e {meses} mes(es)";
    }
  }
}

