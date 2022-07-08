using System;
using System.Collections.Generic;

class Conversor {
  private int num;
  private Stack<int> pilha = new Stack<int>();
  public void SetNum(int num) {
    if (num > 0) this.num = num;
  }
  public int GetNum() {
    return num;
  }
  public string Binario() {
    int x = num;
    while (x > 0) {
      pilha.Push(x % 2);
      x = x / 2;
    }
    string s = "";
    while(pilha.Count > 0) {
      s = s + pilha.Pop().ToString();
    }
    return s;
  }
}

class Program {
  public static void Main() {
    int h = 0x401;
    int b = 0b10000000001;
    Console.WriteLine(h);
    Console.WriteLine(b);
    int d = 1025;
    Console.WriteLine($"{d:X}");
    Conversor c = new Conversor();
    c.SetNum(1025);
    Console.WriteLine(c.GetNum());
    Console.WriteLine(c.Binario());
  }
}