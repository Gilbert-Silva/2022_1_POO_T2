using System;
using System.IO;

class Aluno {}
class Professor {}

class Triangulo {
  private double b, h;
  public void SetBase(double v) {
    if (v < 0) throw new ArgumentOutOfRangeException();
    b = v;
  }
  public void SetAltura(double v) {
    if (v < 0) throw new ArgumentOutOfRangeException();
    h = v;
  }
  public override string ToString() {
    return $"{b} {h}";
  }
}

class Program {
  public static void Main() {
    try {
      Triangulo t = new Triangulo();
      t.SetBase(10);
      t.SetAltura(-10);
    }
    catch (ArgumentOutOfRangeException) {
      Console.WriteLine("Valores inválidos");
    }
    
    foreach (string line in 
      File.ReadLines("./Aula_0713/exemplo.py"))
        Console.WriteLine(line);

    //int.Parse(null);
    //string s = "Teste";
    //Console.WriteLine(s[10]);
    //s = null;
    // Console.WriteLine(s.Length);
    //object a = new Aluno();
    //Professor p = (Professor) a;
    
    Console.WriteLine("Digite dois valores inteiros");
    try {
      int x = int.Parse(Console.ReadLine());
      int y = int.Parse(Console.ReadLine());
      int z = x / y;
      Console.WriteLine(z);
    }
    catch (FormatException obj) {
      Console.WriteLine("O valor informado não é inteiro");     
      Console.WriteLine(obj.Message);
    }
    catch (DivideByZeroException) {
      Console.WriteLine("Não pode dividir por zero");
    }
    catch (Exception obj) {
      Console.WriteLine("Deu algum erro");
      Console.WriteLine(obj.Message);
    }
    finally {
      Console.WriteLine("Sempre feito");
    }
    Console.WriteLine("Cheguei Aqui!");
  }
}