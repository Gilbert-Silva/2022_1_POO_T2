using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    Console.WriteLine(x.GetTitular());
    Console.WriteLine(x.GetNumero());
    Console.WriteLine($"Saldo = {x.GetSaldo()}");
    x.SetTitular("Eduardo Neto");
    x.SetNumero("123-X");
    Console.WriteLine(x.GetTitular());
    Console.WriteLine(x.GetNumero());
    Console.WriteLine($"Saldo = {x.GetSaldo()}");
    Console.WriteLine("Após o depósito");
    x.Depositar(1000);
    Console.WriteLine($"Saldo = {x.GetSaldo()}"); // get
    Console.WriteLine("Após o saque");
    x.Sacar(100);
    Console.WriteLine($"Saldo = {x.GetSaldo()}"); // get
    Console.WriteLine(x);
    //Console.WriteLine(x.ToString());
    ContaBancaria y = new ContaBancaria("Gilbert Azevedo", "321-0");
    Console.WriteLine(y);
    Console.WriteLine(y.GetType());
    
  }
}

class ContaBancaria : object {
  private string titular = "Nome do cliente";
  private string numero = "Número da conta";
  private double saldo;

  public ContaBancaria() { }
  
  public ContaBancaria(string titular, string numero) {
    if (titular.IndexOf(' ') != -1) this.titular = titular;
    if (numero.IndexOf('-') != -1) this.numero = numero;
  }
  
  public void SetTitular(string titular) {
    if (titular.IndexOf(' ') != -1) this.titular = titular;
    //else Console.WriteLine("Nome é inválido");
  }
  public string GetTitular() {
    return this.titular;
  }
  
  public void SetNumero(string s) {
    if (s.IndexOf('-') != -1) this.numero = s;
    //else Console.WriteLine("Número é inválido");
  }
  public string GetNumero() {
    return this.numero;
  }
  
  public void Depositar(double valor) {
    // if (valor > 0) this.saldo += valor;
    if (valor > 0) SetSaldo(GetSaldo() + valor);
    //else Console.WriteLine("Valor deve ser positivo");
  }
  public void Sacar(double valor) {
    if (valor <= this.saldo && valor > 0) this.saldo -= valor;
    //else Console.WriteLine("Saldo insuficiente ou valor negativo");
    // Vai ser resolvido com uma notificação de erro
  }
  public double GetSaldo() {
    return saldo;
  }
  private void SetSaldo(double valor) {
    this.saldo = valor;
  }

  public override string ToString () {
    //return "Olá, eu sou uma ContaBancaria";
    return $"Titular = {titular}, Nº = {numero}, Saldo = R${saldo:0.00}";
  }
}