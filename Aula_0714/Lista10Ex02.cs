using System;
using System.Collections;

class Colecao<T> : IEnumerable {
  private T[] objs = new T[10];
  private int k;
  public void Inserir(T obj) {
    objs[k++] = obj;
  }
  public void Excluir(T obj) {
    int pos = -1;
    for (int i = 0; i < k; i++)
      if (objs[i].Equals(obj)) pos = i;
    if (pos != -1) {
      for (int i = pos; i < k - 1; i++)
        objs[i] = objs[i+1];
      k--;  
    }
  }
  
  public IEnumerator GetEnumerator() {
    T[] aux = new T[k];
    Array.Copy(objs, aux, k);
    return aux.GetEnumerator();     
  }
  public T[] Listar() {
    T[] aux = new T[k];
    Array.Copy(objs, aux, k);
    return aux;    
  }
}

class Aluno { }

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    Aluno a2 = new Aluno();
    Console.WriteLine(a1 == a2);
    Console.WriteLine(1 == 2);
    Colecao<string> c = new Colecao<string>();
    c.Inserir("10");
    c.Inserir("Beleza");
    c.Inserir("C#");
    c.Excluir("Beleza");
    //foreach (string x in c.Listar())
    foreach (string x in c)
      Console.WriteLine(x);
  }
}
