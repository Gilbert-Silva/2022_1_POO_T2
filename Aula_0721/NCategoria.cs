using System;
using System.Collections.Generic;

static class NCategoria {
  private static List<Categoria> categorias = new List<Categoria>();
  public static void Inserir(Categoria c) {
    // Versão inicial, o id é informado pelo usuário
    // categorias.Add(c);
    // Nova versão, o id é auto-incrementado
    int id = 0;
    foreach(Categoria obj in categorias)
      if (obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    categorias.Add(c);
  }
  public static List<Categoria> Listar() {
    categorias.Sort();
    return categorias;
  }
  public static Categoria Listar(int id) {
    foreach(Categoria obj in categorias)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Atualizar(Categoria c) {
    Categoria atual = Listar(c.Id);
    if (atual != null)
      atual.Descricao = c.Descricao;
  }
  public static void Excluir(Categoria c) {
    Categoria atual = Listar(c.Id);
    if (atual != null)
      categorias.Remove(atual);
  }
}
