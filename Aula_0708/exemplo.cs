using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    int x;
    List<int> lista = new List<int>();
    SortedList<int, int> dic = new SortedList<int, int>();
    SortedSet<int> s = new SortedSet<int>();
    do {
      x = int.Parse(Console.ReadLine());
      lista.Add(x);
      dic.Add(x, 0); // Chave e valor
      s.Add(x);      // Chave
    } while (x != 0);
    Console.WriteLine("Vetor dinâmico");
    foreach(int i in lista)
      Console.WriteLine(i);
    Console.WriteLine("Dicionário Ordenado");
    foreach(KeyValuePair<int, int> i in dic)     
      Console.WriteLine(i.Key + " " + i.Value);
    Console.WriteLine("Set");
    foreach(int i in s)
      Console.WriteLine(i);
  }
}
