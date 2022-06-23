using System;

/*
public interface IComparable {
  int CompareTo (object? obj);
}
*/

class Program {
  public static void Main() {
    IComparable a = 10;
    IComparable b = 20;
    Console.WriteLine(a.CompareTo(b));
    //Console.WriteLine(a + b);
    //Jogador c = (Jogador) a;
    //Console.WriteLine(c + c);
    
    /*
    int[] v = { 5, 2, 1, 8, 30, 21, 6 };
    Array.Sort(v);
    foreach(int i in v)
      Console.Write(i + " ");
    Console.WriteLine();
    // Lexicográfica
    string[] w = { "C#", "Java", "C++", "Python", "Assembly", "Basic" };
    Array.Sort(w);
    foreach(string s in w)
      Console.Write(s + " ");
    Console.WriteLine();
    */
    Console.WriteLine("Java".CompareTo("C#"));
    Console.WriteLine("Java".CompareTo("Java"));
    Console.WriteLine("C#".CompareTo("Java"));

    Console.WriteLine(3.CompareTo(5));
    Console.WriteLine(5.CompareTo(5));
    Console.WriteLine(5.CompareTo(3));
    
    Jogador x = new Jogador("Zico", 10);
    object y = new Jogador("Ronaldinho", 9);
    IComparable z = new Jogador("Sócrates", 8);
    Jogador z1 = (Jogador) y;
    Jogador z2 = y as Jogador; 
    x.GetCamisa(); 
    //z.GetCamisa(); // Erro
    z.CompareTo(x);
    //y.CompareTo(x); // Erro
    
    Jogador j1 = new Jogador("Luiz Felipe", 10);
    Jogador j2 = new Jogador("Gilbert", 5);
    Jogador j3 = new Jogador("Redson", 1);
    Jogador j4 = new Jogador("Matheus", 9);
    Jogador j5 = new Jogador("Maria Luiza", 6);
    Jogador j6 = new Jogador("Virgilio", 7);
    Jogador[] js = { j1, j2, j3, j4, j5, j6 };

    Array.Sort(js);
    foreach(Jogador j in js)
      Console.WriteLine(j);
    
    Console.WriteLine(j2.CompareTo(j1));
  }
}
/*
class Array {
  public void Sort(Array v) {
    IComparable x = v[0];
    IComparable y = v[1];
    x.CompareTo(y);
  }
}
*/
class Jogador : IComparable {
  private string nome;
  private int camisa;
  public Jogador(string nome, int camisa) {
    this.nome = nome;
    this.camisa = camisa;
  }
  public int GetCamisa() {
    return camisa;
  }
  public int CompareTo (object obj) {
    Jogador j = (Jogador) obj; // Type-cast
    //if (this.camisa < j.camisa) return -1;
    //else if (this.camisa == j.camisa) return 0;
    //return 1;
    //return this.camisa.CompareTo(j.camisa);
    return this.nome.CompareTo(j.nome);
  }
  public override string ToString() {
    return $"{nome} - {camisa}";
  }
}



