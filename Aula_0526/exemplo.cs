using System;

class Program {
  public static void Main() {
    int[] v = new int[5];
    foreach(int x in v) 
      Console.WriteLine(x);
    Aluno[] w = new Aluno[5];
    foreach(Aluno y in w) 
      Console.WriteLine(y);
    w[0] = new Aluno();
  }
}

class Aluno {
  
}