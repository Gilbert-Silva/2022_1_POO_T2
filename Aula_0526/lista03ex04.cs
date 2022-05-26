using System;

class Equacao {
  private double a = 1, b, c; // ax^2 + bx + c = 0
  public Equacao(double a, double b, double c) {
    if (a != 0) this.a = a;
    this.b = b;
    this.c = c;
  }
  public double Delta() {
    return b * b - 4 * a * c;
  }
  public void GetABC(out double a, out double b, out double c) {
    a = this.a;
    b = this.b;
    c = this.c;
  }
  public Tuple<double, double, double> GetABC() {
    return Tuple.Create(a, b, c);
  }
  public double GetA() {
    return a;
  }
  public double GetB() {
    return b;
  }
  public double GetC() {
    return c;
  }
  public bool RaizesReais(out double x1, out double x2) {
    x1 = 0;
    x2 = 0;
    if (Delta() < 0) return false;
    x1 = (-b + Math.Sqrt(Delta())) / (2 * a);
    x2 = (-b - Math.Sqrt(Delta())) / (2 * a);
    return true;
  }
}

class Program {
  public static void Main() {
    Equacao eq = new Equacao(1, 0, -4);
    double a, b, c;
    if (eq.RaizesReais(out a, out b)) 
      Console.WriteLine($"As raizes são {a} e {b}");
    else
      Console.WriteLine("Não tem raízes reais");
    eq.GetABC(out a, out b, out c);
    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    var x = eq.GetABC();
    Console.WriteLine(x.GetType());
    Console.WriteLine($"a = {x.Item1}, b = {x.Item2}, c = {x.Item3}");
  }
}