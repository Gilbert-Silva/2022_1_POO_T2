using System;

class Program {
  public static void Main() {
    int x = Matematica.MenorValor(10, 3, 4);
    Console.WriteLine(x);
    Console.WriteLine(Matematica.MenorValor(1, 3, 4));
    Console.WriteLine(Matematica.MenorValor(2, 5));
    int[] w = { 5, 8, 9, 3, 2, 5 };
    Console.WriteLine(Matematica.MenorValor(w));
    Console.WriteLine(Matematica.MaiorValor(2, 5));
    int a = 10, b = 20;
    Console.WriteLine($"a = {a}, b = {b}");
    Matematica.TrocarValor(ref a, ref b);
    Console.WriteLine($"a = {a}, b = {b}");
    Matematica.MenorMaiorValor(3, 5, 4, out int m, out int n);
    Console.WriteLine($"Menor = {m}, Maior = {n}");
  }
}

class Matematica {
  public static void MenorMaiorValor(int a, int b, int c, 
    out int menor, out int maior) {
    menor = Matematica.MenorValor(a, b, c);
    maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
  }
  public static void TrocarValor(ref int x, ref int y) {
    int aux = x;
    x = y;
    y = aux;
  }
  public static int MaiorValor(int a, int b) {
    int maior = a;
    if (b > maior) maior = b;
    return maior;
  }
  public static int MenorValor(int[] v) {
    int menor = v[0];
    foreach(int i in v)
      if (i < menor) menor = i;
    return menor;
  }
  public static int MenorValor(int a, int b) {
    int menor = a;
    if (b < menor) menor = b;
    return menor;
  }
  public static int MenorValor(int a, int b, int c) {
    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    return menor;
  }
}