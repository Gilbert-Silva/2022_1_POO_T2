using System;
using System.Linq;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    string[] s = Console.ReadLine().Split();
    int[] v = new int[n]; // n = s.Length
    for (int i = 0; i < n; i++)
      v[i] = int.Parse(s[i]);
    int menor = v[0];
    int pos = 0;
    for (int i = 1; i < n; i++) {
      if (v[i] < menor) {
        menor = v[i];
        pos = i;
      }
    }
    //int[] v = s.Select(int.Parse).ToArray(); 
    //int menor = v.Min();
    //int pos = Array.IndexOf(v, menor);
    Console.WriteLine($"Menor valor: {menor}");
    Console.WriteLine($"Posicao: {pos}");
  }
}
