using System;

class Data {
  private int dia = 1, mes = 1, ano = 1;
  public Data(string data) {
    string[] v = data.Split('/');
    int d = int.Parse(v[0]);   
    int m = int.Parse(v[1]);   
    int a = int.Parse(v[2]);   
    SetData(d, m, a);
  }
  public Data(int dia, int mes, int ano) {
    if (DataValida(dia, mes, ano)) {
      this.dia = dia;
      this.mes = mes;
      this.ano = ano;
    }
  }
  private bool DataValida(int dia, int mes, int ano) {
    int max = 31;
    switch(mes) {
      case 2: max = Bissexto(dia, mes, ano) ? 29 : 28; break;
      case 4: case 6:
      case 9: case 11: max = 30; break;
    }
    return dia >= 1 && dia <= max && mes >= 1 && mes <= 12 && ano != 0;    
  }
  private bool Bissexto(int dia, int mes, int ano) {
    return (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
  }
  public void SetData(int dia, int mes, int ano) {
    if (DataValida(dia, mes, ano)) {
      this.dia = dia;
      this.mes = mes;
      this.ano = ano;
    }
    // else throw new ArgumentOutOfRangeException("Data Inválida");
  }
  public override string ToString() {
    return $"{this.dia:00}/{this.mes:00}/{this.ano:0000}";
  }
  public int GetDia() {
    return dia;
  }
  public int GetMes() {
    return mes;
  }
  public int GetAno() {
    return ano;
  }
}

class Program {
  public static void Main() {
    //Data d = new Data(26, 5, 2022);
    Data d = new Data("26/5/2022");
    Console.WriteLine(d);
    d.SetData(28, 2, 2022);
    Console.WriteLine(d);
    Console.WriteLine(d.GetDia());
    Console.WriteLine(d.GetMes());
    Console.WriteLine(d.GetAno());
    DateTime x = new DateTime(2022, 2, 28);
    Console.WriteLine(x);
  }
}