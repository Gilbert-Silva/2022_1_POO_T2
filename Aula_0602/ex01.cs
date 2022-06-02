using System;

class Energia {
  private int mes = 1, ano;
  private double valor;
  public Energia(int mes, int ano, double valor) {
    // SetMes(mes);
    if (mes >= 1 && mes <= 12) this.mes = mes;
    this.ano = ano;
    if (valor > 0) this.valor = valor;
  }
  public void SetMes(int mes) {
    if (mes >= 1 && mes <= 12) this.mes = mes;
  }
  public void SetAno(int ano) {
    this.ano = ano;
  }
  public void SetValor(double valor) {
    if (valor > 0) this.valor = valor;
  }
  public int GetMes() {
    return mes;
  }
  public int GetAno() {
    return ano;
  }
  public double GetValor() {
    return valor;
  }
  public override string ToString() {
    return $"Conta de {mes}/{ano} = R$ {valor:0.00}";
  }
}

class Program {
  public static void Main() {
    Console.WriteLine("Informe mês, ano e valor da 1ª conta");
    int mes = int.Parse(Console.ReadLine());
    int ano = int.Parse(Console.ReadLine());
    double val = double.Parse(Console.ReadLine());
    Energia maior = new Energia(mes, ano, val);
    for (int i = 2; i <= 3; i++) {
      Console.WriteLine($"Informe mês, ano e valor da {i}ª conta");
      mes = int.Parse(Console.ReadLine());
      ano = int.Parse(Console.ReadLine());
      val = double.Parse(Console.ReadLine());
      Energia x = new Energia(mes, ano, val);
      if (x.GetValor() > maior.GetValor()) maior = x;
    }
    Console.WriteLine($"Conta mais alta: {maior}");
  }
}

