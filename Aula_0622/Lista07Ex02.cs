using System;

class Program {
  public static void Main() {
    Frete f = new Frete();
    f.Distancia = 10;
    f.Peso = 50;
    double valor = f.ValorFrete;
    Console.WriteLine(f);
    Console.WriteLine($"Valor do frete = R$ {valor:0.00}");
  }
}
class Frete {
  private double distancia, peso;
  public double Distancia {
    set { if (value > 0) distancia = value; }  
    get { return distancia; }
  }
  public double Peso {
    set => peso = value > 0 ? value : 0;
    get => peso;
  }
  public double ValorFrete {
     get { return 0.01 * distancia * peso; }   
  }
  public override string ToString() {
    return $"Distancia = {distancia}, Peso = {peso}";
  }
}