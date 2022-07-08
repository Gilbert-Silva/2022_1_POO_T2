using System;
using System.Collections.Generic;
using System.Linq;

class Lote : IComparable {
  public string Numero { get; set; }
  public DateTime Vencimento { get; set; }
  public int Estoque { get; set; }
  public int CompareTo(object obj) {
    Lote r = (Lote) obj;
    if (this.Vencimento == r.Vencimento) 
      return this.Numero.CompareTo(r.Numero);
    return this.Vencimento.CompareTo(r.Vencimento);
  }
  public override string ToString() { return
    $"{Numero} - {Vencimento:dd/MM/yy} - {Estoque}";
  }
}

class Medicamento {
  private List<Lote> lotes = new List<Lote>();
  public string Nome { get; set; }
  public int Qtd { get { return lotes.Count; } }
  public void Inserir(Lote lote) {   // Insert
    lotes.Add(lote);
  }
  public void Excluir(Lote lote) {   // Insert
    lotes.Remove(lote);
  }
  public List<Lote> Listar() {       // Select
    lotes.Sort();
    return lotes;
  }
  public List<Lote> Pesquisar(int mes, int ano) {   // Where
    List<Lote> aux = new List<Lote>();
    foreach(Lote l in this.Listar())
      if (l.Vencimento.Month == mes && 
          l.Vencimento.Year == ano) aux.Add(l);
    return aux;
  }
  public int Total(int mes, int ano) {   // Sum
    int total = 0;
    foreach(Lote l in this.Listar())
      if (l.Vencimento.Month == mes && 
          l.Vencimento.Year == ano) total += l.Estoque;
    return total;
    //return lotes;
  }  
}

class Program {
  public static void Main() {
    Lote l1 = new Lote { Numero = "B2", Estoque = 10,
      Vencimento = DateTime.Parse("2022-12-01") };
    Lote l2 = new Lote { Numero = "A1", Estoque = 20,
      Vencimento = DateTime.Parse("2023-01-01") };
    Lote l3 = new Lote { Numero = "B1", Estoque = 15,
      Vencimento = DateTime.Parse("2022-12-01") };
    Console.WriteLine(l1);    
    Console.WriteLine(l2);    
    Console.WriteLine(l3);    
    Console.WriteLine(l1.CompareTo(l2));    
    Console.WriteLine(l1.CompareTo(l3));    
    Console.WriteLine(l2.CompareTo(l3));   
    Medicamento m = new Medicamento { Nome = "Paracetamol" };
    Console.WriteLine(m.Nome);
    m.Inserir(l1);
    m.Inserir(l2);
    m.Inserir(l3);
    Console.WriteLine(m.Qtd);
    foreach(Lote l in m.Listar())
      Console.WriteLine(l);
    foreach(Lote l in m.Pesquisar(12, 2022))
      Console.WriteLine(l);
    Console.WriteLine(m.Total(12, 2022));
  }
}
