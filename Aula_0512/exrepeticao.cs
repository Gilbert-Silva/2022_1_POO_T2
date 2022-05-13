using System;

class Program {
  public static void Main() {
    double d = 1.5;
    //Console.WriteLine(d.ToString());  
    //Console.WriteLine(d.ToString("0.00"));  
    Console.WriteLine("while");
    int x = 1;
    while (x <= 10)
    {
      Console.WriteLine(x);
      x++;
      //x += 1;
    }

    Console.WriteLine("for");
    for (x = 1;x <= 10;x++) {
      Console.WriteLine(x);
    }
    
    Console.WriteLine("do-while");
    x = 1;
    do {
      Console.WriteLine(x);
      x++;
    } while (x <= 10);

    string s = "Tecnologia";
    foreach (char c in s) {
      Console.WriteLine(c);
    }

    int[] v = { 5, 7, 2, 1, 0, 10 };
    v.Sort();
    Array.Sort(v);
    foreach (int i in v) {
      Console.WriteLine(i);
    }
    Console.WriteLine(v.GetType());
    
  }
}