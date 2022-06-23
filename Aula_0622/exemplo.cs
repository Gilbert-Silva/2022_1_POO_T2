using System;
using System.Threading;
using System.Globalization;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    DateTime d;
    string s;
    do {
      Console.WriteLine("Informe uma data de nascimento");
      s = Console.ReadLine();
    } while (!DateTime.TryParse(s, out d));
    Console.WriteLine(d);
  }
}