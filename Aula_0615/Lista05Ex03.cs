using System;

enum Pagamento {
  EmAberto, PagoParcial, Pago
}

class Boleto {
  private double valorBoleto, valorPago;
  private Pagamento situacaoPagamento;
  public Boleto(double valor) {
    if (valor > 0) {
      valorBoleto = valor;
      valorPago = 0;
      situacaoPagamento = Pagamento.EmAberto;
    }
  }
  public void Pagar(double valorPago) {
    if (valorPago > 0) {
      this.valorPago = valorPago;
      if (valorPago == valorBoleto)
        situacaoPagamento = Pagamento.Pago;
      else
        situacaoPagamento = Pagamento.PagoParcial;
    }
  }
  public Pagamento Situacao() {
    return situacaoPagamento;
  }
  public override string ToString() {
    return $"Valor = {valorBoleto:c2}, Pago = {valorPago:c2}, Situacao = {situacaoPagamento}";
  }
}

class Program {
  public static void Main() {
    Boleto b = new Boleto(500);
    Console.WriteLine(b);
    b.Pagar(100);
    Console.WriteLine(b);
    b.Pagar(500);
    Console.WriteLine(b);
  }
}