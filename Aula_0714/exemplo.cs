using System;
using System.Collections.Generic;
using System.IO;

class Professor {
  public string Nome { get; set; }
  public string Curso { get; set; }
  public void FromCSV(string s) {
    string[] v = s.Split(';');
    p.Nome = v[0];
    p.Curso = v[1];    
  }
}

class Program {
  public static void Main() {
    List<Professor> lista = new List<Professor>();
    string s;
    StreamReader f = new StreamReader("prof.csv");
    s = f.ReadLine();
    while (s != null) {
      Professor p = new Professor();
      p.FromCSV(s);
      lista.Add(p);
      s = f.ReadLine();
    }
    f.Close();
    foreach (Professor p in lista)
      Console.WriteLine(p.Nome + " - " + p.Curso);
  }
  public static void Escrever() {
    StreamWriter f = new StreamWriter("prof.csv");
    f.WriteLine("Gilbert;TADS");
    f.WriteLine("Eduardo;TADS");
    f.WriteLine("Carlos;Redes");
    f.WriteLine("Janser;Gestão");
    f.Close();
  }
  public static void Ler() {
    string s;
    StreamReader f = new StreamReader("prof.csv");
    s = f.ReadLine();
    while (s != null) {
      Console.WriteLine(s);
      s = f.ReadLine();
    }
  }
}
