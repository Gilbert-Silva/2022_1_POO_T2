using System;
using System.Collections.Generic;
using System.Linq;

class ApostaLoteria {
  private int a, b, c, d, e, f;
  public ApostaLoteria(int a, int b, int c, int d, int e, int f) {
    SetValores(a, b, c, d, e, f);
  }
  public void SetValores(int a, int b, int c, int d, int e, int f) {
    if (a >= 1 && a <= 60) this.a = a;
    if (b >= 1 && b <= 60) this.b = b;
    if (c >= 1 && c <= 60) this.c = c;
    if (d >= 1 && d <= 60) this.d = d;
    if (e >= 1 && e <= 60) this.e = e;
    if (f >= 1 && f <= 60) this.f = f;
  }
  public void GetValores(out int a, out int b, out int c, 
                         out int d, out int e, out int f) {
    a = this.a;
    b = this.b;
    c = this.c;
    d = this.d;
    e = this.e;
    f = this.f;
  }
  public int GetA() { return a; }
  public int GetB() { return b; }
  public int GetC() { return c; }
  public int GetD() { return d; }
  public int GetE() { return e; }
  public int GetF() { return f; }
  public int ContarAcertos(int v1, int v2, int v3, int v4, int v5, int v6) {
    int n = 0;
    if (a == v1 || a == v2 || a == v3 || a == v4 || a == v5 || a == v6) n++;
    if (b == v1 || b == v2 || b == v3 || b == v4 || b == v5 || b == v6) n++;
    if (c == v1 || c == v2 || c == v3 || c == v4 || c == v5 || c == v6) n++;
    if (d == v1 || d == v2 || d == v3 || d == v4 || d == v5 || d == v6) n++;
    if (e == v1 || e == v2 || e == v3 || e == v4 || e == v5 || e == v6) n++;
    if (f == v1 || f == v2 || f == v3 || f == v4 || f == v5 || f == v6) n++;
    return n;
  }
  public override string ToString() {
    return $"Aposta: {a}, {b}, {c}, {d}, {e}, {f}";
  }
}

class Program {
  public static void Main() {
    //ApostaLoteria x = new ApostaLoteria(1, 2, 3, 4, 5, 6);
    //Console.WriteLine(x);
    //int n = x.ContarAcertos(10, 3, 4, 9, 30, 41);
    //Console.WriteLine(n);

    Console.WriteLine("Informe 6 valores da 1ª aposta");
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s[3]);
    int e = int.Parse(s[4]);
    int f = int.Parse(s[5]);
    ApostaLoteria x = new ApostaLoteria(a, b, c, d, e, f);
    // Expressão Lambda - o resultado é um método
    // Variável do tipo Delegate
    //var r = Console.ReadLine().Split().Select(w => w.Length).ToArray();
    //var r = Console.ReadLine().Split().Select(TamanhodaString).ToArray();
    //Console.WriteLine(r[0] + r[1]);

    Console.WriteLine("Informe 6 valores do resultado");
    s = Console.ReadLine().Split();
    a = int.Parse(s[0]);
    b = int.Parse(s[1]);
    c = int.Parse(s[2]);
    d = int.Parse(s[3]);
    e = int.Parse(s[4]);
    f = int.Parse(s[5]);
    
    Console.WriteLine(x.ContarAcertos(a, b, c, d, e, f));
  }
  public static int TamanhodaString(string w) {
    return w.Length;
  }
}
