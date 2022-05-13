using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine().ToUpper(); // linha toda
    while (s != "*") {
      char c = s[0];  // 1º caractere
      bool ok = true; // v = todas as letras são iguais
      string[] v = s.Split(); // conjunto com todas as palavras
      foreach(string palavra in v) { // cada palavra
        if (palavra[0] != c) {
          ok = false;      
          break;
        }
      }
      Console.WriteLine(ok ? "Y" : "N");
      s = Console.ReadLine().ToUpper();
    }
  }
}