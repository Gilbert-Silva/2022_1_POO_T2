using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    DateTime x = DateTime.Now;
    Console.WriteLine(x);
    Console.WriteLine(x.Day);
    Console.WriteLine(x.Month);
    Console.WriteLine(x.Year);
    Console.WriteLine(x.DayOfWeek);
    DateTime y = new DateTime(2022, 1, 1);
    Console.WriteLine(y);
    Console.WriteLine(y.Day);
    Console.WriteLine(y.Month);
    Console.WriteLine(y.Year);
    Console.WriteLine(y.DayOfWeek);
    TimeSpan z = x - y;
    Console.WriteLine(z);
    Console.WriteLine(z.Days);
    Console.WriteLine(z.Hours);

    double d = 1.5;
    Console.WriteLine(d);
    Console.WriteLine($"{d:c2}");
    
  }
}