using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Pais {
  public string Nome { get;set; }
  public int Ouro { get;set; }
  public int Prata { get;set; }
  public int Bronze { get;set; }
  public override string ToString() {
    return $"{Nome} - {Ouro} - {Prata} - {Bronze}";
  }
  public string ToCSV() {
    return $"{Nome};{Ouro};{Prata};{Bronze}";
  }
  public void FromCSV(string s) {
    string[] v = s.Split(';');
    Nome = v[0];
    Ouro = int.Parse(v[1]);
    Prata = int.Parse(v[2]);
    Bronze = int.Parse(v[3]);
  }
}

class Program {
  public static void Main() {
    List<Pais> paises;

    StreamReader f = new StreamReader("olimp.xml");
    XmlSerializer xml = new XmlSerializer(typeof(List<Pais>));
    paises = (List<Pais>) xml.Deserialize(f);
    f.Close();
    
    foreach(Pais p in paises)
      Console.WriteLine(p);    
  }

  public static void MainCSV() {
    List<Pais> paises = new List<Pais>();
    StreamReader f = new StreamReader("olimp.csv");
    string s = f.ReadLine();
    while (s != null) {
      Pais p = new Pais();
      p.FromCSV(s);
      paises.Add(p);      
      s = f.ReadLine();
    }
    f.Close();
    foreach(Pais p in paises)
      Console.WriteLine(p);    
  }
                  
  public static void Main2() { // Salvar
    Pais p1 = new Pais { Nome = "Brasil", Ouro = 10, 
                         Prata = 5, Bronze = 15 };
    Pais p2 = new Pais { Nome = "Japão", Ouro = 15, 
                         Prata = 8, Bronze = 5 };
    Pais p3 = new Pais { Nome = "Argentina", Ouro = 4, 
                         Prata = 3, Bronze = 10 };
    Pais p4 = new Pais();
    p4.FromCSV("EUA;10;15;20");
    Console.WriteLine(p1.ToCSV());
    Console.WriteLine(p2.ToCSV());
    Console.WriteLine(p3.ToCSV());
    Console.WriteLine(p4);

    List<Pais> paises = new List<Pais>();
    paises.Add(p1);
    paises.Add(p2);
    paises.Add(p3);
    paises.Add(p4);
    StreamWriter f = new StreamWriter("olimp.csv");
    foreach(Pais p in paises)
      f.WriteLine(p.ToCSV());
    f.Close();

    StreamWriter f2 = new StreamWriter("olimp.xml");
    XmlSerializer xml = new XmlSerializer(typeof(List<Pais>));
    xml.Serialize(f2, paises);
    f2.Close();
  }
}
