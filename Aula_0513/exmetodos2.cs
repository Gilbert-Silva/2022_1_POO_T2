using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int x;
    while (!int.TryParse(Console.ReadLine(), out x))
      Console.WriteLine("Valor inválido, digite novamente");
    Console.WriteLine(x);
    Console.WriteLine(Matematica.ValorPI());
    MostrarValor(10);
  }
  public static void MostrarValor(int x) {
    if (x == 0) return;
    Console.WriteLine(x);
    MostrarValor(x - 1);
  }
}

class Matematica {
  private static double ValorPI() {
    return 3.14159;
  }
}
