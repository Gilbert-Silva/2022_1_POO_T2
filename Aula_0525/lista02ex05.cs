using System;

class Program{
  public static void Main(){
    Cinema x = new Cinema();
    x.SetDia("qua");
    x.SetHora(14);
    Console.WriteLine(x.Entrada());
  }
}

class Cinema{
  private string dia = "dom";
  private int hora = 0;

  public void SetDia(string dia) {
    if (dia == "dom" || dia == "seg" || dia == "ter" || dia == "qua" ||
        dia == "qui" || dia == "sex" || dia == "sab")
      this.dia = dia;
  }
  public void SetHora(int hora) {
    if (hora >= 0 && hora <= 23) this.hora = hora; 
  }

  public double Entrada() {
    double ingresso = 0;
    dia = dia.ToLower();
    if(dia == "qua"){
      ingresso = 8;
      return ingresso;
    }
    else if(dia == "seg" || dia == "ter" || dia == "qui"){
      ingresso = 16;
    }
    else{
      ingresso = 20;
    }
    if(hora >= 17 && hora < 24){
      ingresso = (ingresso / 2) + ingresso;
      //ingresso += ingresso / 2;
    }
    return ingresso;
  }
}