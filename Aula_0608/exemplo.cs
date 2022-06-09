using System;

class Program {
  public static void Main() {
    object[] v = { 1, 2.5, "texto", false };
    Console.WriteLine(v[0].GetType());   
    Console.WriteLine(v[1].GetType());  
    Console.WriteLine(v[0]);   
    int i = (int) v[0];
    i++;
    Console.WriteLine(i);  
    string s = (string) v[3];
    Console.WriteLine(s.Substring(0, 2));
  }
}