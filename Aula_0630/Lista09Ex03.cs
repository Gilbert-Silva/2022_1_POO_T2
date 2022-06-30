using System;

interface ISorteio {
  int[] Sorteados();
  int Proximo();
}

class Program {
  public static void Main() {
    Console.WriteLine("Escolha o jogo: 1 - Mega, 2 - Bingo");
    int op = int.Parse(Console.ReadLine());
    ISorteio m;
    if (op == 1) m = new Mega();
    else m = new Bingo(10);
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine(m.Proximo());
    Console.WriteLine();
    foreach(int numero in m.Sorteados())
      Console.WriteLine(numero);
  }
}
class Bingo : ISorteio {
  private int numBolas;
  public Bingo(int numBolas) {
    this.numBolas = numBolas;
  }
  public int[] Sorteados() {
    int[] vetor = { 1 };
    return vetor;
  } 
  public int Proximo() {
    return numBolas;
  }
}

class Mega : ISorteio {
  private int[] vetor = new int[6];
  private int pos = 0;
  public Mega() {
    Random r = new Random();
    int k = 0;
    while (k < 6) {
      int numero = r.Next(1, 61);
      if (Array.IndexOf(vetor, numero) == -1)
        vetor[k++] = numero;
    }
  }
  public int[] Sorteados() {
    return vetor;
  }
  public int Proximo() {
    if (pos < 6) return vetor[pos++];
    return -1;
  }

}