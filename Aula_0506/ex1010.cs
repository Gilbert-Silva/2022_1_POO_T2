using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();    // s = input()
    string r = Console.ReadLine();
    string[] vs = s.Split();          // vs = s.split(' ')
    string[] vr = r.Split();   
    // string[] v = Console.ReadLine().Split();
    int np1 = int.Parse(vs[1]);       // np1 = int(vs[1])
    double vp1 = double.Parse(vs[2]); // vp1 = float(vs[2])
    int np2 = int.Parse(vr[1]);
    double vp2 = double.Parse(vr[2]);
    for (long x = 0; x < 2000000000; x++);
    double t = np1 * vp1 + np2 * vp2;
    Console.WriteLine($"VALOR A PAGAR: R$ {t:0.00}");
  }
}
