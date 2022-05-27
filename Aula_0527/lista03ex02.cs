using System;

class Frete {
  private double distancia, peso;
  public Frete(double distancia, double peso) {
    this.distancia = distancia;
    this.peso = peso;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetPeso() {
    return peso;
  }
  public void SetDistancia(double distancia) {
    this.distancia = distancia;
  }
  public void SetPeso(double peso) {
    this.peso = peso;
  }
  public double CalcFrete() {
    return 0.01 * distancia * peso;
  }  
  public override string ToString() {
    return $"Distância = {distancia} km, Peso = {peso} kg";
  }
}

class Program {
  public static void Main() {
    Frete f = new Frete(100, 10);
    Console.WriteLine(f);
    Console.WriteLine(f.GetDistancia());
    Console.WriteLine(f.GetPeso());
    Console.WriteLine(f.CalcFrete());
    f.SetDistancia(150);
    Console.WriteLine(f);
    Console.WriteLine(f.CalcFrete());
  }
}