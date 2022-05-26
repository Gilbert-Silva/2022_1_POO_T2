using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    // x.titular = "Eduardo";
    x.SetTitular("Eduardo Neto");
    // x.numero = "123-X";
    x.SetNumero("123-X");
    // x.saldo = 1000;  // set
    x.Depositar(1000);
    // Console.WriteLine(x.titular);
    Console.WriteLine(x.GetTitular());
    // Console.WriteLine(x.numero);
    Console.WriteLine(x.GetNumero());
    // Console.WriteLine($"Saldo = {x.saldo}"); // get
    Console.WriteLine($"Saldo = {x.GetSaldo()}"); // get
    x.Sacar(-100);
    Console.WriteLine($"Saldo = {x.GetSaldo()}"); // get
  }
}

class ContaBancaria {
  private string titular;
  private string numero;
  private double saldo;
  public void Depositar(double valor) {
    if (valor > 0) saldo += valor;
    //else Console.WriteLine("Valor deve ser positivo");
  }
  public void Sacar(double valor) {
    if (valor <= saldo && valor > 0) saldo -= valor;
    //else Console.WriteLine("Saldo insuficiente ou valor negativo");
    // Vai ser resolvido com uma notificação de erro
  }
  public double GetSaldo() {
    return saldo;
  }
  public void SetTitular(string s) {
    if (s.IndexOf(' ') != -1) titular = s;
    //else Console.WriteLine("Nome é inválido");
  }
  public string GetTitular() {
    return titular;
  }
  public void SetNumero(string s) {
    if (s.IndexOf('-') != -1) numero = s;
    //else Console.WriteLine("Número é inválido");
  }
  public string GetNumero() {
    return numero;
  }
}